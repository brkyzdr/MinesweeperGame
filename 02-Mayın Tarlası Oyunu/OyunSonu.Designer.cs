
namespace _02_Mayın_Tarlası_Oyunu
{
    partial class OyunSonu
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOyunSonu = new System.Windows.Forms.TextBox();
            this.txtSeviye = new System.Windows.Forms.TextBox();
            this.txtSkor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(229, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seviye";
            // 
            // txtOyunSonu
            // 
            this.txtOyunSonu.BackColor = System.Drawing.SystemColors.Control;
            this.txtOyunSonu.Enabled = false;
            this.txtOyunSonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOyunSonu.Location = new System.Drawing.Point(35, 26);
            this.txtOyunSonu.Multiline = true;
            this.txtOyunSonu.Name = "txtOyunSonu";
            this.txtOyunSonu.Size = new System.Drawing.Size(337, 69);
            this.txtOyunSonu.TabIndex = 1;
            // 
            // txtSeviye
            // 
            this.txtSeviye.Enabled = false;
            this.txtSeviye.Location = new System.Drawing.Point(93, 115);
            this.txtSeviye.Name = "txtSeviye";
            this.txtSeviye.Size = new System.Drawing.Size(100, 20);
            this.txtSeviye.TabIndex = 2;
            // 
            // txtSkor
            // 
            this.txtSkor.Enabled = false;
            this.txtSkor.Location = new System.Drawing.Point(274, 116);
            this.txtSkor.Name = "txtSkor";
            this.txtSkor.Size = new System.Drawing.Size(98, 20);
            this.txtSkor.TabIndex = 3;
            // 
            // OyunSonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 161);
            this.Controls.Add(this.txtSkor);
            this.Controls.Add(this.txtSeviye);
            this.Controls.Add(this.txtOyunSonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OyunSonu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Son";
            this.Load += new System.EventHandler(this.OyunSonu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOyunSonu;
        private System.Windows.Forms.TextBox txtSeviye;
        private System.Windows.Forms.TextBox txtSkor;
    }
}