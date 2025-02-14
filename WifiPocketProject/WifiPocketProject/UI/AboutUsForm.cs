using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiPocketProject.UI
{
    public partial class AboutUsForm : Form//BasetForm
    {
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {

            #region Code

            string filePath = @"D:\Company\AppsparqTech\0.ALL_ASSETS\SupportedProjects\WifiPocket\SMSwithExcel\ExcelContacts\Original\naqashtransfer@gmail.xlsx11";
            string sheetName = "naqashtransfer@gmail11";

            // Ensure file is not locked
            WaitForFileRelease(filePath);

            try
            {
                // Open the Excel file
                IWorkbook workbook;
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    workbook = new XSSFWorkbook(file);
                }

                // Get the sheet by name
                ISheet sheet = workbook.GetSheet(sheetName);
                if (sheet == null)
                {
                    Console.WriteLine($"Sheet '{sheetName}' not found.");
                    return;
                }

                // Read headers (First Row)
                IRow headerRow = sheet.GetRow(0);
                int firstNameIndex = FindColumnIndex(headerRow, "First Name");
                int middleNameIndex = FindColumnIndex(headerRow, "Middle Name");
                int lastNameIndex = FindColumnIndex(headerRow, "Last Name");
                int orgNameIndex = FindColumnIndex(headerRow, "Organization Name");

                if (firstNameIndex == -1 || middleNameIndex == -1 || lastNameIndex == -1 || orgNameIndex == -1)
                {
                    Console.WriteLine("One or more required columns are missing!");
                    return;
                }

                // Loop through rows (starting from row 1)
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null) continue;

                    string firstName = GetCellValue(row, firstNameIndex);
                    string middleName = GetCellValue(row, middleNameIndex);
                    string lastName = GetCellValue(row, lastNameIndex);
                    string orgName = GetCellValue(row, orgNameIndex);

                    // Merge names into the "First Name" column
                    string mergedName = $"{firstName} - {middleName} - {lastName} - {orgName}".Replace(" -  - ", " - ").TrimEnd('-');
                    row.GetCell(firstNameIndex).SetCellValue(mergedName);
                }

                // Save back to the same file
                using (FileStream outFile = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.None))
                {
                    workbook.Write(outFile);
                }

                // Close workbook
                workbook.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Console.WriteLine("Excel file updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            #endregion
        }



        // Wait for the file to be released
        static void WaitForFileRelease(string filePath)
        {
            bool fileAvailable = false;
            while (!fileAvailable)
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {
                        fileAvailable = true;
                    }
                }
                catch (IOException)
                {
                    Thread.Sleep(500);
                }
            }
        }

        // Find column index by header name
        static int FindColumnIndex(IRow headerRow, string columnName)
        {
            for (int i = 0; i < headerRow.LastCellNum; i++)
            {
                if (headerRow.GetCell(i).StringCellValue.Trim() == columnName)
                {
                    return i;
                }
            }
            return -1; // Column not found
        }

        // Get cell value safely
        static string GetCellValue(IRow row, int index)
        {
            return row.GetCell(index)?.ToString() ?? "";
        }

    }
}









