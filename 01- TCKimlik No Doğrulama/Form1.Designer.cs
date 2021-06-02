
namespace _01__TCKimlik_No_Doğrulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.lblIsim = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.lblDogumYili = new System.Windows.Forms.Label();
            this.txtDogumYili = new System.Windows.Forms.TextBox();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDogumYili);
            this.groupBox1.Controls.Add(this.lblDogumYili);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.lblSoyisim);
            this.groupBox1.Controls.Add(this.txtTcKimlikNo);
            this.groupBox1.Controls.Add(this.lblTcKimlikNo);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.lblIsim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKontrolEt);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem";
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(6, 19);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(151, 215);
            this.btnKontrolEt.TabIndex = 0;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(3, 85);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(25, 13);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(6, 101);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(262, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(3, 134);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(42, 13);
            this.lblSoyisim.TabIndex = 0;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(6, 150);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(262, 20);
            this.txtSoyisim.TabIndex = 2;
            // 
            // lblDogumYili
            // 
            this.lblDogumYili.AutoSize = true;
            this.lblDogumYili.Location = new System.Drawing.Point(3, 182);
            this.lblDogumYili.Name = "lblDogumYili";
            this.lblDogumYili.Size = new System.Drawing.Size(57, 13);
            this.lblDogumYili.TabIndex = 0;
            this.lblDogumYili.Text = "Doğum Yılı";
            // 
            // txtDogumYili
            // 
            this.txtDogumYili.Location = new System.Drawing.Point(6, 198);
            this.txtDogumYili.Name = "txtDogumYili";
            this.txtDogumYili.Size = new System.Drawing.Size(262, 20);
            this.txtDogumYili.TabIndex = 3;
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(3, 34);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(68, 13);
            this.lblTcKimlikNo.TabIndex = 0;
            this.lblTcKimlikNo.Text = "TC Kimlik No";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(6, 50);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(262, 20);
            this.txtTcKimlikNo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T.C Kimlik No Doğrulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDogumYili;
        private System.Windows.Forms.Label lblDogumYili;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label lblTcKimlikNo;
    }
}

