﻿
namespace KindergartenJoy.Forme
{
    partial class FormUpisDjece
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpol = new System.Windows.Forms.TextBox();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.btnUpisiDijete = new System.Windows.Forms.Button();
            this.dtpDatumRođenja = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum Rođenja:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(167, 34);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(167, 86);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oib:";
            // 
            // txtSpol
            // 
            this.txtSpol.Location = new System.Drawing.Point(167, 135);
            this.txtSpol.Name = "txtSpol";
            this.txtSpol.Size = new System.Drawing.Size(100, 20);
            this.txtSpol.TabIndex = 7;
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(167, 243);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(100, 20);
            this.txtOib.TabIndex = 9;
            // 
            // btnUpisiDijete
            // 
            this.btnUpisiDijete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpisiDijete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpisiDijete.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpisiDijete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpisiDijete.Location = new System.Drawing.Point(81, 308);
            this.btnUpisiDijete.Name = "btnUpisiDijete";
            this.btnUpisiDijete.Size = new System.Drawing.Size(146, 42);
            this.btnUpisiDijete.TabIndex = 10;
            this.btnUpisiDijete.Text = "UPIŠI DIJETE";
            this.btnUpisiDijete.UseVisualStyleBackColor = false;
            this.btnUpisiDijete.Click += new System.EventHandler(this.btnUpisiDijete_Click);
            // 
            // dtpDatumRođenja
            // 
            this.dtpDatumRođenja.Location = new System.Drawing.Point(167, 190);
            this.dtpDatumRođenja.Name = "dtpDatumRođenja";
            this.dtpDatumRođenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRođenja.TabIndex = 11;
            // 
            // FormUpisDjece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDatumRođenja);
            this.Controls.Add(this.btnUpisiDijete);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.txtSpol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpisDjece";
            this.Text = "FormUpisDjece";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpol;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Button btnUpisiDijete;
        private System.Windows.Forms.DateTimePicker dtpDatumRođenja;
    }
}