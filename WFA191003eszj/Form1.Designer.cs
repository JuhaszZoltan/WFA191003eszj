namespace WFA191003eszj
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.btnHozzaAd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.tbTippek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos neve:";
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(192, 25);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(219, 34);
            this.tbNev.TabIndex = 1;
            // 
            // btnHozzaAd
            // 
            this.btnHozzaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaAd.Location = new System.Drawing.Point(92, 127);
            this.btnHozzaAd.Name = "btnHozzaAd";
            this.btnHozzaAd.Size = new System.Drawing.Size(414, 43);
            this.btnHozzaAd.TabIndex = 2;
            this.btnHozzaAd.Text = "Játékos hozzáadása";
            this.btnHozzaAd.UseVisualStyleBackColor = true;
            this.btnHozzaAd.Click += new System.EventHandler(this.BtnHozzaAd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Játékos tippjei:";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDb.Location = new System.Drawing.Point(512, 68);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(73, 29);
            this.lblDb.TabIndex = 0;
            this.lblDb.Text = "## db";
            // 
            // tbTippek
            // 
            this.tbTippek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTippek.Location = new System.Drawing.Point(192, 65);
            this.tbTippek.Name = "tbTippek";
            this.tbTippek.Size = new System.Drawing.Size(314, 34);
            this.tbTippek.TabIndex = 1;
            this.tbTippek.TextChanged += new System.EventHandler(this.TbTippek_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 193);
            this.Controls.Add(this.btnHozzaAd);
            this.Controls.Add(this.tbTippek);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Egyszámjáték GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Button btnHozzaAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.TextBox tbTippek;
    }
}

