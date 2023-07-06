
namespace CalendarApp {
    partial class btPMonth {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btMYear = new System.Windows.Forms.Button();
            this.btPYear = new System.Windows.Forms.Button();
            this.btMMonth = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btMDay = new System.Windows.Forms.Button();
            this.btPDay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(104, 54);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(18, 90);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(127, 82);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(389, 56);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(389, 382);
            this.tbMessage.TabIndex = 3;
            // 
            // btMYear
            // 
            this.btMYear.Location = new System.Drawing.Point(23, 181);
            this.btMYear.Name = "btMYear";
            this.btMYear.Size = new System.Drawing.Size(75, 57);
            this.btMYear.TabIndex = 4;
            this.btMYear.Text = "-年";
            this.btMYear.UseVisualStyleBackColor = true;
            // 
            // btPYear
            // 
            this.btPYear.Location = new System.Drawing.Point(23, 244);
            this.btPYear.Name = "btPYear";
            this.btPYear.Size = new System.Drawing.Size(75, 57);
            this.btPYear.TabIndex = 4;
            this.btPYear.Text = "+年";
            this.btPYear.UseVisualStyleBackColor = true;
            // 
            // btMMonth
            // 
            this.btMMonth.Location = new System.Drawing.Point(104, 181);
            this.btMMonth.Name = "btMMonth";
            this.btMMonth.Size = new System.Drawing.Size(75, 57);
            this.btMMonth.TabIndex = 4;
            this.btMMonth.Text = "-月";
            this.btMMonth.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(104, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 57);
            this.button8.TabIndex = 4;
            this.button8.Text = "+月";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btMDay
            // 
            this.btMDay.Location = new System.Drawing.Point(185, 181);
            this.btMDay.Name = "btMDay";
            this.btMDay.Size = new System.Drawing.Size(75, 57);
            this.btMDay.TabIndex = 4;
            this.btMDay.Text = "-日";
            this.btMDay.UseVisualStyleBackColor = true;
            this.btMDay.Click += new System.EventHandler(this.btMDay_Click);
            // 
            // btPDay
            // 
            this.btPDay.Location = new System.Drawing.Point(185, 244);
            this.btPDay.Name = "btPDay";
            this.btPDay.Size = new System.Drawing.Size(75, 57);
            this.btPDay.TabIndex = 4;
            this.btPDay.Text = "+日";
            this.btPDay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "現在時刻";
            // 
            // timeText
            // 
            this.timeText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeText.Location = new System.Drawing.Point(124, 402);
            this.timeText.Multiline = true;
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(259, 36);
            this.timeText.TabIndex = 6;
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(170, 91);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(124, 81);
            this.btAge.TabIndex = 7;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 1000;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // btPMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMDay);
            this.Controls.Add(this.btPDay);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btMMonth);
            this.Controls.Add(this.btPYear);
            this.Controls.Add(this.btMYear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "btPMonth";
            this.Text = "カレンダーアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btMYear;
        private System.Windows.Forms.Button btPYear;
        private System.Windows.Forms.Button btMMonth;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btMDay;
        private System.Windows.Forms.Button btPDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}

