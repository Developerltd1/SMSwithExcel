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
            await ProcessExcelAsync(_FileName);
        }
        private void comboBoxSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadExcelToDataGridView(_FileName);
        }
        
        #region Methods
        private async Task ProcessExcelAsync(string filePath)
        {
            //ISheet sheet = workbook.GetSheetAt(0); // Get the first sheet
            string _combo = comboBoxSheets.SelectedItem.ToString();
            ISheet sheet = workbook.GetSheet(_combo); // Replace with your sheet name
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
            ICell mobileCell = null;
            string RowNo = null;
            string SNo = null;
            string MobileNumber = null;
            string Name = null;
            string Details = null;
            string Refrence = null;
            ContactCreateMdl.Request requestMdl = new ContactCreateMdl.Request();

            for (int row = 1; row <= validMobileNumberCount; row++) // Skip header
            {
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

                statusCell = currentRow.CreateCell(5); // Assuming column 3 is for status
                statusCell.SetCellValue("Pending");
                statusCell.CellStyle = orangeStyle; // Set as Pending (Orange)
                dt.Rows[row - 1][5] = "Pending"; // Update GridView
                requestMdl.Status = "Pending"; // Update DbTable: tblContacts
                try
                {
                    RowNo = row.ToString();
                    requestMdl.LoopRowNo = row; // Update DbTable: tblContacts
                    SNo = currentRow.GetCell(0)?.ToString(); //S#
                    requestMdl.SheetSNo = Convert.ToInt32(SNo); // Update DbTable: tblContacts
                    MobileNumber = currentRow.GetCell(1)?.ToString()?.Trim(); //Mobile Number

                    Name = currentRow.GetCell(2)?.ToString(); //Name
                    requestMdl.Name = Name; // Update DbTable: tblContacts
                    Details = currentRow.GetCell(3)?.ToString(); //Details
                    requestMdl.Description = Details; // Update DbTable: tblContacts
                    Refrence = currentRow.GetCell(4)?.ToString(); //Refrence
                    requestMdl.RefrenceName = Refrence; // Update DbTable: tblContacts

                    if (!string.IsNullOrWhiteSpace(MobileNumber) && MobileNumber.Count(char.IsDigit) >= 10)
                    {
                        MobileNumber = FilterNumber.FormatPhoneNumber(MobileNumber);
                        requestMdl.RefrenceName = MobileNumber; // Update DbTable: tblContacts  --FilterNumber
                        statusCell.CellStyle = greenStyle; // Set as Read (Green)
                        //////mobileCell = currentRow.CreateCell(1); // Assuming column 3 is for status
                        //////mobileCell.SetCellValue(MobileNumber);
                        statusCell.SetCellValue("Saved");
                        //////dt.Rows[row - 1][1] = MobileNumber; // Update GridView
                        dt.Rows[row - 1][5] = "Saved"; // Update GridView
                        requestMdl.Status = "Saved"; // Update DbTable: tblContacts

                        #region DbInsert
                      // var response = new ContactServices().CreateAsync(requestMdl);
                      // progressBar1 //here...
                        #endregion

                    }
                    else
                    {
                        statusCell.SetCellValue("Invalid");
                        statusCell.CellStyle = redStyle; // Set as Failed (Red)
                        dt.Rows[row - 1][5] = "Invalid"; // Update GridView
                        requestMdl.Status = "Invalid"; // Update DbTable: tblContacts
                    }
                }
                catch
                {
                    statusCell.SetCellValue("Failed");
                    statusCell.CellStyle = redStyle; // Set as Failed (Red)
                    dt.Rows[row - 1][5] = "Failed"; // Update GridView
                    requestMdl.Status = "Failed"; // Update DbTable: tblContacts
                }

                

                // ✅ Batch update the DataGridView after processing all rows
                gdvExcel.Invoke(new Action(() =>
                {
                    //////gdvExcel.Rows[row].Cells["MobileNumber"].Value = dt.Rows[row - 1][1].ToString(); // ✅ Update existing column
                    gdvExcel.Rows[row].Cells["Status"].Value = dt.Rows[row - 1][5].ToString(); // ✅ Update existing column
                }));


            }
            
            
            gdvExcel.Invoke(new Action(() =>
            {
                gdvExcel.Refresh();
            }));
            // ✅ Ensure workbook is fully loaded before writing
            using (FileStream outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                workbook.Write(outFile);
            }
            workbook.Close(); // Close the workbook properly
            MessageBox.Show("Processing Complete! Open the file to see the status colors.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
