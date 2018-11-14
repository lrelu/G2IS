using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				String str = doc.InvokeScript(MapFunc.GetCenter).ToString();
				//object result = webMap.Document.InvokeScript(MapFunc.GetCenter);
				//MessageBox.Show(result.ToString());
				MessageBox.Show(str);
			}
		}
	}

	static class MapFunc
	{
		public const string AddMarker = "AddMarker";
		public const string GetCenter = "GetCenter";
	}
}
