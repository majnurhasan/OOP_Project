using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;

namespace OOP_Project.Classes
{
    //Put ExcelDataReader related things here
    //Still Experimental
    public class ExcelDataReader
    {
        private static string filePath = ""; //Insert file path here
        static FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
        static IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
        //DataSet result = excelReader.AsDataSet();

        //while (excelReader.Read())
        //{
        //excelReader.GetInt32(0);
        //}

        //excelReader.Close();
    }


}
