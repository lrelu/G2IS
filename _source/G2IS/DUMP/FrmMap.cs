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
		public FrmMap()
		{
			InitializeComponent();
			this.webMap.Navigate("http://localhost");
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
			// call javascript function on web page
			if (this.webMap.Document != null)
			{
				object[] obj = new object[2];
				obj[0] = 37.542658;
				obj[1] = 126.842199;

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
	}

	static class MapFunc
	{
		public const string AddMarker = "AddMarker";
		public const string GetCenter = "GetCenter";
	}
}
