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
using System.Xml;

namespace DataAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
}
