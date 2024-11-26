namespace ProductManager
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.btnCategoryProcess = new System.Windows.Forms.Button();
            this.btnProductProcess = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCategoryProcess
            // 
            this.btnCategoryProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategoryProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCategoryProcess.Location = new System.Drawing.Point(30, 225);
            this.btnCategoryProcess.Name = "btnCategoryProcess";
            this.btnCategoryProcess.Size = new System.Drawing.Size(356, 71);
            this.btnCategoryProcess.TabIndex = 0;
            this.btnCategoryProcess.Text = "Kategori İşlemleri";
            this.btnCategoryProcess.UseVisualStyleBackColor = false;
            this.btnCategoryProcess.Click += new System.EventHandler(this.btnCategoryProcess_Click);
            // 
            // btnProductProcess
            // 
            this.btnProductProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProductProcess.Location = new System.Drawing.Point(30, 321);
            this.btnProductProcess.Name = "btnProductProcess";
            this.btnProductProcess.Size = new System.Drawing.Size(356, 71);
            this.btnProductProcess.TabIndex = 1;
            this.btnProductProcess.Text = "Ürün İşlemleri";
            this.btnProductProcess.UseVisualStyleBackColor = false;
            this.btnProductProcess.Click += new System.EventHandler(this.btnProductProcess_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstatistik.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIstatistik.Location = new System.Drawing.Point(30, 417);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(356, 71);
            this.btnIstatistik.TabIndex = 2;
            this.btnIstatistik.Text = "İstatistikler";
            this.btnIstatistik.UseVisualStyleBackColor = false;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Yönetimi";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnProductProcess);
            this.Controls.Add(this.btnCategoryProcess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 600);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryProcess;
        private System.Windows.Forms.Button btnProductProcess;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Label label1;
    }
}