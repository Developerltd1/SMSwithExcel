using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;  // For .xlsx files
using NPOI.HSSF.UserModel;  // For .xls files
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using WifiPocketProject.CommonCode;
using Domain.Contacts;
using BusinessLogic.Services;
using Domain.Exceptions;



namespace WifiPocketProject.UI
{
    public partial class ExportData : BaseForm//Form
    {
        public static string _FileName { get; set; }
        IWorkbook workbook;
        public static List<int> validRows;
        public ExportData()
        {
            InitializeComponent();
        }
        private void ExportData_Load(object sender, EventArgs e)
        {
        }
        private async void btnLoadExcelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _FileName = openFileDialog.FileName;

            }
            using (FileStream file = new FileStream(_FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (_FileName.EndsWith(".xlsx"))
                    workbook = new XSSFWorkbook(file);
                else
                    workbook = new HSSFWorkbook(file);
            }

            #region ComboBox
            comboBoxSheets.Items.Clear(); // Clear previous items
            for (int i = 0; i < workbook.NumberOfSheets; i++)
            {
                comboBoxSheets.Items.Add(workbook.GetSheetName(i)); // Add sheet name to ComboBox
            }
            if (comboBoxSheets.Items.Count > 0)
                comboBoxSheets.SelectedIndex = 0; // Select first sheet by default
            #endregion

        }

        private async void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_FileName))
                {
                    if (gdvExcel.Rows.Count > 0)
                        await ProcessExcelAsync(_FileName);
                    else
                        MessageBox.Show("Grid is not Load");
                }
                else
                {
                    MessageBox.Show("Please Select File");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void comboBoxSheets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Methods
        private async Task ProcessExcelAsync(string filePath)
        {
            ContactCreateMdl.Request requestMdl = new ContactCreateMdl.Request();

            //ISheet sheet = workbook.GetSheetAt(0); // Get the first sheet
            string _combo = comboBoxSheets.SelectedItem.ToString();
            ISheet sheet = workbook.GetSheet(_combo); // Replace with your sheet name
            requestMdl.SheetName = _combo;
            if (sheet == null)
                throw new Exception("Sheet not found.");

            ICellStyle greenStyle = CreateCellStyle(workbook, IndexedColors.LightGreen.Index);
            ICellStyle redStyle = CreateCellStyle(workbook, IndexedColors.Red.Index);
            ICellStyle orangeStyle = CreateCellStyle(workbook, IndexedColors.Orange.Index);

            #region GdvExcel to Dt

            DataTable dt = new DataTable();
            // Add columns to DataTable
            foreach (DataGridViewColumn column in gdvExcel.Columns)
            {
                dt.Columns.Add(column.HeaderText); // Use column names as DataTable headers
            }
            // Add rows to DataTable
            foreach (DataGridViewRow row in gdvExcel.Rows)
            {
                if (!row.IsNewRow) // Skip the empty row at the bottom
                {
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < gdvExcel.Columns.Count; j++)
                    {
                        dr[j] = row.Cells[j].Value ?? DBNull.Value;
                    }
                    dt.Rows.Add(dr);
                }
            }

            #endregion

            // 🔹 Get only valid rows where MobileNumber is filled
            List<int> validRows = GetValidMobileNumberRows(sheet);
            int validMobileNumberCount = validRows.Count; // Total valid numbers found

            IRow currentRow = null;
            string MobileNumber0 = null;
            ICell statusCell = null;
            ICell duplicateCell = null;
            ICell mobileCell = null;
            //string RowNo = null;
            //string SNo = null;
            string MobileNumber = null;
            //string Name = null;
            //string Details = null;
            //string Refrence = null;


            #region ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = validMobileNumberCount;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            #endregion

            for (int row = 1; row <= validMobileNumberCount; row++) // Skip header
            {
                
                progressBar1.Invoke(new Action(() =>
                {
                    progressBar1.PerformStep();
                    progressBar1.Refresh();
                }));

                currentRow = sheet.GetRow(row);
                if (currentRow == null) continue;

                #region Comminted
                ////MobileNumber0 = currentRow.GetCell(1)?.ToString()?.Trim(); // Read Mobile Number column
                //// If MobileNumber column is empty, stop processing further rows
                //if (MobileNumber0.Count(char.IsDigit) < 10)
                //    continue;

                // If MobileNumber is invalid, mark it and continue
                //////if (string.IsNullOrWhiteSpace(MobileNumber0) || MobileNumber0.Count(char.IsDigit) < 10)
                //////{
                //////    currentRow.CreateCell(5).SetCellValue("Invalid");
                //////    currentRow.GetCell(5).CellStyle = redStyle;
                //////    dt.Rows[row - 1][5] = "Invalid"; // Update GridView
                //////    continue;
                //////} 
                #endregion
                requestMdl.ChechStatus = currentRow.GetCell(6)?.ToString(); //After Status Col
               
                if (!string.IsNullOrEmpty(requestMdl.ChechStatus))
                {
                    if (requestMdl.ChechStatus.Contains("uplicate"))
                    {
                        continue;
                    }
                }

                duplicateCell = currentRow.CreateCell(6); // Assuming column 3 is for status
                statusCell = currentRow.CreateCell(5); // Assuming column 3 is for status

                try
                {
                    requestMdl.LoopRowNo = row.ToString();
                    requestMdl.SheetSNo = currentRow.GetCell(0)?.ToString(); //S#
                    MobileNumber = currentRow.GetCell(1)?.ToString()?.Trim(); //Mobile Number
                    requestMdl.Name = currentRow.GetCell(2)?.ToString(); //Name
                    requestMdl.Description = currentRow.GetCell(3)?.ToString(); //Details
                    requestMdl.RefrenceName = currentRow.GetCell(4)?.ToString(); //Refrence

                    if (!string.IsNullOrWhiteSpace(MobileNumber) && MobileNumber.Count(char.IsDigit) >= 10)
                    {
                        requestMdl.MobileNumber = FilterNumber.FormatPhoneNumber(MobileNumber);
                        statusCell.CellStyle = greenStyle; // Set as Read (Green)
                        statusCell.SetCellValue("Saved");
                        dt.Rows[row - 1][5] = "Saved"; // Update GridView
                        requestMdl.Status = "Saved"; // Update DbTable: tblContacts

                        //////mobileCell = currentRow.CreateCell(1); // Assuming column 3 is for status
                        //////mobileCell.SetCellValue(MobileNumber);
                        //////dt.Rows[row - 1][1] = MobileNumber; // Update GridView
                    }
                    else
                    {
                        statusCell.SetCellValue("Invalid");
                        statusCell.CellStyle = redStyle; // Set as Failed (Red)
                        dt.Rows[row - 1][5] = "Invalid"; // Update GridView
                        requestMdl.Status = "Invalid"; // Update DbTable: tblContacts
                    }
                    #region DbInsert
                    int IsMobileNumberExists = 0;
                    var response = new ContactServices().CreateAsync(requestMdl, out IsMobileNumberExists);
                    if (IsMobileNumberExists > 0)
                    {
                        duplicateCell.CellStyle = orangeStyle; // Set as Failed (Red)
                        duplicateCell.SetCellValue("Duplicate: " + IsMobileNumberExists);

                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    statusCell.SetCellValue("Failed");
                    statusCell.CellStyle = redStyle; // Set as Failed (Red)
                    dt.Rows[row - 1][5] = "Failed"; // Update GridView
                    requestMdl.Status = "Failed"; // Update DbTable: tblContacts
                    #region DbInsert
                    ExceptionMdl.Request requestException = new ExceptionMdl.Request();
                    requestException.ErrorMessage = ex.Message;
                    requestException.ErrorInnerMessage = ex.InnerException.ToString();
                    requestException.FuncationName = "ProcessExcelAsync";
                    requestException.SheetSNo = row.ToString();
                    requestException.SheetName = _combo;  //SheetName
                    var response = new ContactServices().ExceptionAsync(requestException);
                    #endregion
                }



                // ✅ Batch update the DataGridView after processing all rows
                gdvExcel.Invoke(new Action(() =>
                {
                    //////gdvExcel.Rows[row].Cells["MobileNumber"].Value = dt.Rows[row - 1][1].ToString(); // ✅ Update existing column
                    gdvExcel.Rows[row].Cells["Status"].Value = dt.Rows[row - 1][5].ToString(); // ✅ Update existing column
                }));


            }




            // ✅ Ensure workbook is fully loaded before writing
            using (FileStream outFile = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                workbook.Write(outFile);
            }
            workbook.Close(); // Close the workbook properly
            workbook = null; // Ensure it's disposed

            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Value = validMobileNumberCount;
            }));
            gdvExcel.Invoke(new Action(() =>
            {
                MessageBox.Show("Processing Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //gdvExcel.DataSource = null;
                //gdvExcel.Rows.Clear();
                gdvExcel.Refresh();
                comboBoxSheets.Text = null;
                _FileName = null;
            }));
        }





        // ✅ Separate function to count and return rows where "Mobile Number" has data
        private List<int> GetValidMobileNumberRows(ISheet sheet)
        {
            validRows = new List<int>();

            for (int row = 1; row <= sheet.LastRowNum; row++) // Skip header row (row 0)
            {
                IRow currentRow = sheet.GetRow(row);
                if (currentRow == null) continue;

                string MobileNumber = currentRow.GetCell(1)?.ToString()?.Trim(); // Read Mobile Number column

                // If MobileNumber is valid, store the row index
                if (!string.IsNullOrWhiteSpace(MobileNumber))
                {
                    validRows.Add(row);
                }
            }

            return validRows; // Return only valid row indexes
        }
        private ICellStyle CreateCellStyle(IWorkbook workbook, short colorIndex)
        {
            ICellStyle style = workbook.CreateCellStyle();
            style.FillForegroundColor = colorIndex;
            style.FillPattern = FillPattern.SolidForeground;
            return style;
        }
        private async Task LoadExcelToDataGridView(string filePath)
        {

            try
            {
                await Task.Run(() =>
                {
                    using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        //////string _combo = comboBoxSheets.SelectedItem.ToString();
                        /// // Capture the UI value before running the background task
                        string _combo = "";
                        comboBoxSheets.Invoke((MethodInvoker)(() =>
                        {
                            _combo = comboBoxSheets.SelectedItem?.ToString() ?? "";
                        }));
                        if (string.IsNullOrEmpty(_combo))
                        {
                            return;
                        }
                        ISheet sheet = workbook.GetSheet(_combo); // Replace with your sheet name
                        List<int> validRows = GetValidMobileNumberRows(sheet);
                        DataTable dt = new DataTable();
                        IRow headerRow = sheet.GetRow(0);


                        int columnCount = headerRow.LastCellNum; // Get total columns in the header

                        // 🔹 Ensure DataTable has the same number of columns as the Excel file
                        for (int i = 0; i < columnCount; i++)
                        {
                            string columnName = headerRow.GetCell(i)?.ToString() ?? $"Column{i + 1}";
                            if (!dt.Columns.Contains(columnName)) // Avoid duplicate column names
                                dt.Columns.Add(columnName);
                        }

                        // 🔹 Read data and add rows dynamically
                        for (int i = 0; i <= validRows.Count; i++) // Skip header row
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue;

                            DataRow dr = dt.NewRow();
                            for (int j = 0; j < columnCount; j++)
                            {
                                dr[j] = row.GetCell(j)?.ToString()?.Trim() ?? ""; // Handle empty cells
                            }

                            dt.Rows.Add(dr);
                        }
                        // ✅ Update UI safely using Invoke
                        gdvExcel.Invoke((MethodInvoker)(() =>
                        {
                            gdvExcel.Rows.Clear();
                            foreach (DataRow r in dt.Rows)
                            {
                                gdvExcel.Rows.Add(
                                    r["S#"].ToString(), r["Mobile Number"].ToString(), r["Name"].ToString(), r["Details"].ToString(), r["Refrence"].ToString(), r["Status"].ToString());
                            }
                        }));
                        ////workbook.Close();
                    }
                });
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {


        }

        private void comboBoxSheets_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_FileName))
                    LoadExcelToDataGridView(_FileName);

                else
                    MessageBox.Show("Please Select File");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
