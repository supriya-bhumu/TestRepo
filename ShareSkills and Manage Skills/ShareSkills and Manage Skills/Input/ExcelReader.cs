using System;
using CompetitionTask1.Pages;
using System.Linq;
using System.Text;
using CompetitionTask1.Tests;
using ExcelDataReader;
using System.Data;
using CompetitionTask1.Input;
using System.IO;
using CompetitionTask1.Utilities;

namespace CompetitionTask1.Input
{
    class ExcelReader
    {

        static List<Datacollection> dataCol = new List<Datacollection>();

        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }

        }

        public static void ClearData()
        {

            dataCol.Clear();
        }

        public static DataTable ExcelToDataTable(FileStream stream, string sheetname)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            //create open xmlreader via excel readerfactory
            //create open xmlreader reads the .xlsx files

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            //set the first row as coloumn name

            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }

            });

            //get the table into datacollection table

            DataTableCollection table = result.Tables;

            //store it in data table

            DataTable resultTable = table[sheetname];
            return resultTable;

        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //retrieve data using LINQ to reduce much of iteration

                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //retrieve data throughlambda

                return data.ToString();

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception occured in ExcelLib class ReadData Method" + Environment.NewLine + e.Message);
                return null;
            }
        }
        public static void ReadDataTable(FileStream stream, string sheetname)
        {

            DataTable table = ExcelToDataTable(stream, sheetname);

            //total row count = table.row.count;

            //iterate throught the rows and columns of the table

            for (int row = 0; row < table.Rows.Count; row++)
            {
                Datacollection data;

                //console.writeline("Row Nmuber is" + (row + 1));
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    data = new Datacollection();
                    data.rowNumber = row + 1;
                    data.colName = table.Columns[col].ColumnName;
                    data.colValue = table.Rows[row][col].ToString();
                    dataCol.Add(data);

                }

            }

        }

    } 
}
