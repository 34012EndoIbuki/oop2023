
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvUrl = new System.Windows.Forms.DataGridView();
            this.statasLabelDisp = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInfoText = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrl)).BeginInit();
            this.statasLabelDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(13, 13);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(599, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(618, 13);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(13, 61);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(376, 292);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrowser.Location = new System.Drawing.Point(13, 359);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(767, 250);
            this.wbBrowser.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(700, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 31);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "登録";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvUrl
            // 
            this.dgvUrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrl.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvUrl.Location = new System.Drawing.Point(405, 61);
            this.dgvUrl.Name = "dgvUrl";
            this.dgvUrl.RowTemplate.Height = 21;
            this.dgvUrl.Size = new System.Drawing.Size(370, 292);
            this.dgvUrl.TabIndex = 5;
            this.dgvUrl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrl_CellClick);
            // 
            // statasLabelDisp
            // 
            this.statasLabelDisp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInfoText});
            this.statasLabelDisp.Location = new System.Drawing.Point(0, 597);
            this.statasLabelDisp.Name = "statasLabelDisp";
            this.statasLabelDisp.Size = new System.Drawing.Size(800, 22);
            this.statasLabelDisp.TabIndex = 6;
            this.statasLabelDisp.Text = "statusStrip1";
            this.statasLabelDisp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statasLabelDisp_ItemClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsInfoText
            // 
            this.tsInfoText.Name = "tsInfoText";
            this.tsInfoText.Size = new System.Drawing.Size(42, 17);
            this.tsInfoText.Text = "テキスト";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statasLabelDisp);
            this.Controls.Add(this.dgvUrl);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrl)).EndInit();
            this.statasLabelDisp.ResumeLayout(false);
            this.statasLabelDisp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dgvUrl;
        private System.Windows.Forms.StatusStrip statasLabelDisp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsInfoText;
    }
}

