using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DUMP
{
	public partial class FrmMap : Form
	{
		private Log _log;

		public FrmMap()
		{
			InitializeComponent();

			this.webMap.Refresh(WebBrowserRefreshOption.Completely);
			//this.webMap.Document.Cookie.Remove(0, this.webMap.Document.Cookie.Length);
			this.webMap.Navigate("http://localhost");
		}

		private void FrmMap_Load(object sender, EventArgs e)
		{
		}

		private void alertTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// call javascript function on web page
			if (this.webMap.Document != null)
			{
				object[] obj = new object[2];
				obj[0] = "대한 상공회의소";
				obj[1] = "서울시 강서구 화곡동";

				webMap.Document.InvokeScript("test", obj);
			}
		}

		private void addMarkerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddMarkeronMap(37.542658, 126.842199);
		}

		private void AddMarkeronMap(double lat, double lng)
		{
			// call javascript function on web page
			if (this.webMap.Document != null)
			{
				object[] obj = new object[2];
				obj[0] = lat;
				obj[1] = lng;

				webMap.Document.InvokeScript(MapFunc.AddMarker, obj);
			}
		}

		private void getCenterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// call javascript function on web page
			if (this.webMap.Document != null)
			{
				HtmlDocument doc = webMap.Document;
				String result = doc.InvokeScript(MapFunc.GetCenter).ToString();

				//JAVASCRIPT에서 JSON형태로 데이터를 리턴
				MessageBox.Show(result.ToString());

				//JArray json = JArray.Parse(result);
				JObject json = JObject.Parse(result);
				MessageBox.Show(json.Count.ToString());
				MessageBox.Show(json["lat"].ToString());

				MessageBox.Show(json["lng"].ToString());
			}
		}

		private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string file = Application.StartupPath + "\\data\\park_seoul_gangseogu.xls";
			G2IS_APServer.DataHandler datahander = new G2IS_APServer.DataHandler();
			DataTable dt = datahander.GetDataTablefromExcel(file);

			WriteLog(dt.Rows.Count.ToString() + "건 로드가 되었습니다.");

			foreach (DataRow row in dt.Rows)
			{
				AddMarkeronMap((double)row["latitude"] + 0.000060, (double)row["longitude"]);
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FactoryLog();
		}

		private void WriteLog(string msg)
		{
			FactoryLog();

			_log.richTextBox2.Text += msg + Environment.NewLine;
		}

		private void FactoryLog()
		{
			if (_log == null)
			{
				_log = new Log();
				_log.StartPosition = FormStartPosition.Manual;
				_log.Location = new Point(this.Location.X + this.Width, this.Location.Y);
				_log.Show();
			}
		}
	}

	static class MapFunc
	{
		public const string AddMarker = "AddMarker";
		public const string GetCenter = "GetCenter";
	}
}
