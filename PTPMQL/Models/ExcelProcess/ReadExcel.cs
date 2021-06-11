using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace PTPMQL.Models.ExcelProcess
{
	public class ReadExcel
	{
		public DataTable ReadDataFromExcelFile(string filepath)
		{
			string connectionString = "";
			string fileExtention = filepath.Substring(filepath.Length - 4).ToLower();
			if (fileExtention.IndexOf(".xlsx") == 0)
			{
				//xlsx
				connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + filepath + ";Extended Properties=\"Excel 12.0 Xml;HDR=NO\"";
			}
			else if (fileExtention.IndexOf(".xls") == 0)
			{
				//xls
				connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0";
			}
			// Tạo đối tượng kết nối
			OleDbConnection oledbConn = new OleDbConnection(connectionString);
			DataTable data = null;
			try
			{
				// Mở kết nối
				oledbConn.Open();

				// Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
				OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

				// Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
				OleDbDataAdapter oleda = new OleDbDataAdapter();

				oleda.SelectCommand = cmd;

				// Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
				DataSet ds = new DataSet();

				// Đổ đữ liệu từ tập excel vào DataSet
				oleda.Fill(ds);

				data = ds.Tables[0];
			}
			catch
			{
			}
			finally
			{
				// Đóng chuỗi kết nối
				oledbConn.Close();
			}
			return data;
		}
	}
}