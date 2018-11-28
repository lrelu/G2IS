using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace DataAPI
{
	public partial class Form1 : Form
    {
		private string _constr;
		private OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();
        }

		private void btnLoad_Click(object sender, EventArgs e)
		{
			this.rtxtResult.Text += "No API" + Environment.NewLine;
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			FileInfo fi = new FileInfo(Application.StartupPath + "\\data\\park_seoul_gangseogu.xls");
			
			this._constr = TempLib.ConnectionStringbyExt(fi.Extension, fi.FullName);
			
			this.rtxtResult.Text += "_constr: " + this._constr + Environment.NewLine;

			using (this._conn = new OleDbConnection(this._constr))
			{
				OleDbCommand cmd = _conn.CreateCommand();
				cmd.CommandText = "select * from [data$]";
				OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

				DataSet ds = new DataSet();
				adapter.Fill(ds);

				this.rtxtResult.Text += "Load count: " + ds.Tables[0].Rows.Count + Environment.NewLine;

				this.dgvData.DataSource = ds.Tables[0];

				this.dgvData.AutoGenerateColumns = true;
				this.dgvData.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
				this.dgvData.AutoResizeColumnHeadersHeight();

			}
		}
	}
}
