namespace DUMP
{
	partial class FrmMap
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.mnuMap = new System.Windows.Forms.MenuStrip();
			this.단위테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alertTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addMarkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aPIServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.webMap = new System.Windows.Forms.WebBrowser();
			this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMap.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMap
			// 
			this.mnuMap.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.단위테스트ToolStripMenuItem,
            this.aPIServerToolStripMenuItem,
            this.logToolStripMenuItem});
			this.mnuMap.Location = new System.Drawing.Point(0, 0);
			this.mnuMap.Name = "mnuMap";
			this.mnuMap.Size = new System.Drawing.Size(867, 28);
			this.mnuMap.TabIndex = 0;
			this.mnuMap.Text = "menuStrip1";
			// 
			// 단위테스트ToolStripMenuItem
			// 
			this.단위테스트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertTestToolStripMenuItem,
            this.addMarkerToolStripMenuItem,
            this.getCenterToolStripMenuItem});
			this.단위테스트ToolStripMenuItem.Name = "단위테스트ToolStripMenuItem";
			this.단위테스트ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
			this.단위테스트ToolStripMenuItem.Text = "단위 테스트";
			// 
			// alertTestToolStripMenuItem
			// 
			this.alertTestToolStripMenuItem.Name = "alertTestToolStripMenuItem";
			this.alertTestToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
			this.alertTestToolStripMenuItem.Text = "Alert Test";
			this.alertTestToolStripMenuItem.Click += new System.EventHandler(this.alertTestToolStripMenuItem_Click);
			// 
			// addMarkerToolStripMenuItem
			// 
			this.addMarkerToolStripMenuItem.Name = "addMarkerToolStripMenuItem";
			this.addMarkerToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
			this.addMarkerToolStripMenuItem.Text = "Add Marker";
			this.addMarkerToolStripMenuItem.Click += new System.EventHandler(this.addMarkerToolStripMenuItem_Click);
			// 
			// getCenterToolStripMenuItem
			// 
			this.getCenterToolStripMenuItem.Name = "getCenterToolStripMenuItem";
			this.getCenterToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
			this.getCenterToolStripMenuItem.Text = "Get Center";
			this.getCenterToolStripMenuItem.Click += new System.EventHandler(this.getCenterToolStripMenuItem_Click);
			// 
			// aPIServerToolStripMenuItem
			// 
			this.aPIServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem});
			this.aPIServerToolStripMenuItem.Name = "aPIServerToolStripMenuItem";
			this.aPIServerToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.aPIServerToolStripMenuItem.Text = "API Server";
			// 
			// loadDataToolStripMenuItem
			// 
			this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
			this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.loadDataToolStripMenuItem.Text = "Load Data";
			this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
			// 
			// webMap
			// 
			this.webMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webMap.Location = new System.Drawing.Point(0, 28);
			this.webMap.MinimumSize = new System.Drawing.Size(20, 20);
			this.webMap.Name = "webMap";
			this.webMap.Size = new System.Drawing.Size(867, 617);
			this.webMap.TabIndex = 1;
			// 
			// logToolStripMenuItem
			// 
			this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.logToolStripMenuItem.Name = "logToolStripMenuItem";
			this.logToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.logToolStripMenuItem.Text = "Log";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.closeToolStripMenuItem.Text = "Close";
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 645);
			this.Controls.Add(this.webMap);
			this.Controls.Add(this.mnuMap);
			this.MainMenuStrip = this.mnuMap;
			this.Name = "FrmMap";
			this.Text = "Map Dump";
			this.Load += new System.EventHandler(this.FrmMap_Load);
			this.mnuMap.ResumeLayout(false);
			this.mnuMap.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMap;
		private System.Windows.Forms.ToolStripMenuItem 단위테스트ToolStripMenuItem;
		private System.Windows.Forms.WebBrowser webMap;
		private System.Windows.Forms.ToolStripMenuItem alertTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addMarkerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getCenterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aPIServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
	}
}

