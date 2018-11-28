using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadTemp
{
	public partial class Form1 : Form
	{
		private Thread _thread;

		public Form1()
		{
			InitializeComponent();
			this._thread = new Thread(new ThreadStart(Run));
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (this._thread.ThreadState != ThreadState.Running)
				this._thread.Start();
			else
				this.rtxtResult.Text += "현재 스레드상태: " + this._thread.ThreadState.ToString() + "\n";
		}

		private void Run()
		{
			while (true)
			{
				this.rtxtResult.Text += "데이터베이스 저장\n";
				this.textBox1.Text = this._thread.ThreadState.ToString();
				Thread.Sleep(300);
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			this._thread.Interrupt();
			this.textBox1.Text = this._thread.ThreadState.ToString();
			this.textBox1.Text = this._thread.IsAlive.ToString();
		}
	}
}
