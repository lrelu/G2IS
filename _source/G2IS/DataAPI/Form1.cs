using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.OleDb;
using System.IO;
=======
using System.Xml;
>>>>>>> master

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

<<<<<<< HEAD
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
=======
        private void btnLoad_Click(object sender, EventArgs e)
        {
            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient() { Encoding = Encoding.UTF8 };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");
            str.Append("?serviceKey=인증키"); //인증키
            str.Append("&secnNm=" + "kakao");//종목명
            str.Append("&pageNo=1");//페이지 수
            str.Append("&numOfRows=200");//읽어올 데이터 수
            str.Append("&martTpcd=11");//주식시장종류 : 11은 유가증권시장

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList xnList = doc.GetElementsByTagName("item");

            mainGridview.Rows.Clear();

            foreach (XmlNode xn in xnList)
            {
                mainGridview.Rows.Add(xn["isin"].InnerText, xn["issuDt"].InnerText

                                    , xn["korSecnNm"].InnerText, xn["secnKacdNm"].InnerText

                                    , xn["shotnIsin"].InnerText);

            }

            mainGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
>>>>>>> master
}
