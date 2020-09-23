namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCooperation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKadai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActionCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDevCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(14, 24);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 19);
            this.txtProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "製品種別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "連携種別(固定)";
            // 
            // txtCooperation
            // 
            this.txtCooperation.Location = new System.Drawing.Point(14, 67);
            this.txtCooperation.Name = "txtCooperation";
            this.txtCooperation.Size = new System.Drawing.Size(100, 19);
            this.txtCooperation.TabIndex = 3;
            this.txtCooperation.Text = "ResearchBulletin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "課題内容";
            // 
            // txtKadai
            // 
            this.txtKadai.Location = new System.Drawing.Point(14, 108);
            this.txtKadai.Name = "txtKadai";
            this.txtKadai.Size = new System.Drawing.Size(494, 19);
            this.txtKadai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "対策内容";
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(14, 245);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(494, 19);
            this.txtAction.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(433, 285);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "基準No.";
            // 
            // txtActionCode
            // 
            this.txtActionCode.Location = new System.Drawing.Point(14, 206);
            this.txtActionCode.Name = "txtActionCode";
            this.txtActionCode.Size = new System.Drawing.Size(494, 19);
            this.txtActionCode.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "派生";
            // 
            // txtDevCode
            // 
            this.txtDevCode.Location = new System.Drawing.Point(16, 156);
            this.txtDevCode.Name = "txtDevCode";
            this.txtDevCode.Size = new System.Drawing.Size(494, 19);
            this.txtDevCode.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 316);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDevCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActionCode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKadai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCooperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCooperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKadai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActionCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDevCode;
    }
}

