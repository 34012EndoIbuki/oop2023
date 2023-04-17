
namespace WindowsFromApp1 {
    partial class From1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(12, 28);
            this.tbNum.Multiline = true;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(203, 49);
            this.tbNum.TabIndex = 1;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(287, 28);
            this.tbNum2.Multiline = true;
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(220, 49);
            this.tbNum2.TabIndex = 1;
            // 
            // tbAns
            // 
            this.tbAns.Location = new System.Drawing.Point(582, 28);
            this.tbAns.Multiline = true;
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(206, 49);
            this.tbAns.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(535, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(232, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.button1);
            this.Name = "From1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.From1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}