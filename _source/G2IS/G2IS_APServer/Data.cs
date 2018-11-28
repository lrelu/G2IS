using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace G2IS_APServer
{
	public class DataHandler
	{
		private string _constr;
		private OleDbConnection _conn;

		/// <summary>
		/// xls, xlsx의 버전차이로 커넥션 스트링이 달라지기 때문에 처리
		/// </summary>
		/// <param name="ext">확장자</param>
		/// <param name="fileName">파일이름(전체경로 포함)</param>
		/// <returns></returns>
		private string ConnectionStringbyExt(string ext, string fileName)
		{
			string connectionString = string.Empty;

			switch (ext.ToUpper())
			{
				case ".XLS":
					connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
					break;
				case ".XLSX":
					connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
					break;
				default:
					break;
			}

			return connectionString;
		}

		/// <summary>
		/// 엑셀파일에서 data시트 데이터 읽어오기
		/// </summary>
		/// <param name="fileName">엑셀파일 경로(전체경로포함)</param>
		/// <returns></returns>
		public DataTable GetDataTablefromExcel(string fileName)
		{
			// 엑셀파일에 접근하기 위한 커넥션 스트링 생성
			_constr = ConnectionStringbyExt(Path.GetExtension(fileName), fileName);

			// 리턴 결과셋
			DataSet ds = new DataSet("excel_data");

			using (_conn = new OleDbConnection(_constr))
			{
				// interop 방식은 느리고, DataSet 활용이 어렵기 때문에 Ole DB 방식으로 엑셀파일에 접근
				OleDbCommand cmd = _conn.CreateCommand();
				cmd.CommandText = "select name, latitude, longitude, area from [data$];";
				OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
				
				if (adapter.Fill(ds, "excel_data") <= 0)
					return null;
			}

			return ds.Tables["excel_data"];
		}
	}
}
