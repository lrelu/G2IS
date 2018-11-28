using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPI
{
	public class TempLib
	{
		public static string ConnectionStringbyExt(string ext, string path)
		{
			string connectionString = string.Empty;

			switch (ext.ToUpper())
			{
				case ".XLS":
					connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
					break;
				case ".XLSX":
					connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
					break;
				default:
					break;
			}

			return connectionString;
		}
	}
}
