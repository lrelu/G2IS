namespace DataAPI
{
    partial class Form1
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.rtxtResult = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(13, 8);
			this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(182, 109);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Json";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.Location = new System.Drawing.Point(199, 8);
			this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(182, 109);
			this.btnExcel.TabIndex = 0;
			this.btnExcel.Text = "Excel";
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// dgvData
			// 
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Location = new System.Drawing.Point(13, 219);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowTemplate.Height = 27;
			this.dgvData.Size = new System.Drawing.Size(865, 333);
			this.dgvData.TabIndex = 1;
			// 
			// rtxtResult
			// 
			this.rtxtResult.Location = new System.Drawing.Point(13, 123);
			this.rtxtResult.Name = "rtxtResult";
			this.rtxtResult.Size = new System.Drawing.Size(865, 90);
			this.rtxtResult.TabIndex = 2;
			this.rtxtResult.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 564);
			this.Controls.Add(this.rtxtResult);
			this.Controls.Add(this.dgvData);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.btnLoad);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.RichTextBox rtxtResult;
	}
}

