
namespace _02_Mayın_Tarlası_Oyunu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTekrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKolay = new System.Windows.Forms.Button();
            this.btnOrta = new System.Windows.Forms.Button();
            this.btnZor = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // btnTekrar
            // 
            this.btnTekrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTekrar.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekrar.Location = new System.Drawing.Point(320, 12);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(92, 53);
            this.btnTekrar.TabIndex = 1;
            this.btnTekrar.Text = "TEKRAR";
            this.btnTekrar.UseVisualStyleBackColor = false;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKolay
            // 
            this.btnKolay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKolay.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKolay.ForeColor = System.Drawing.Color.Lime;
            this.btnKolay.Location = new System.Drawing.Point(76, 26);
            this.btnKolay.Name = "btnKolay";
            this.btnKolay.Size = new System.Drawing.Size(75, 23);
            this.btnKolay.TabIndex = 2;
            this.btnKolay.Text = "KOLAY";
            this.btnKolay.UseVisualStyleBackColor = false;
            this.btnKolay.Click += new System.EventHandler(this.btnKolay_Click);
            // 
            // btnOrta
            // 
            this.btnOrta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOrta.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrta.ForeColor = System.Drawing.Color.Blue;
            this.btnOrta.Location = new System.Drawing.Point(157, 26);
            this.btnOrta.Name = "btnOrta";
            this.btnOrta.Size = new System.Drawing.Size(75, 23);
            this.btnOrta.TabIndex = 2;
            this.btnOrta.Text = "ORTA";
            this.btnOrta.UseVisualStyleBackColor = false;
            this.btnOrta.Click += new System.EventHandler(this.btnOrta_Click);
            // 
            // btnZor
            // 
            this.btnZor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnZor.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZor.Location = new System.Drawing.Point(238, 26);
            this.btnZor.Name = "btnZor";
            this.btnZor.Size = new System.Drawing.Size(75, 23);
            this.btnZor.TabIndex = 2;
            this.btnZor.Text = "ZOR";
            this.btnZor.UseVisualStyleBackColor = false;
            this.btnZor.Click += new System.EventHandler(this.btnZor_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimer.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.ForeColor = System.Drawing.Color.Navy;
            this.lblTimer.Location = new System.Drawing.Point(21, 26);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 19);
            this.lblTimer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 482);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnZor);
            this.Controls.Add(this.btnOrta);
            this.Controls.Add(this.btnKolay);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTekrar;
        private System.Windows.Forms.Button btnKolay;
        private System.Windows.Forms.Button btnOrta;
        private System.Windows.Forms.Button btnZor;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

