
namespace Bank
{
    partial class FrmEntriPemasukanPengeluaran
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDebitKredit = new System.Windows.Forms.ComboBox();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNasabah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoRekening = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 38);
            this.panel2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDebitKredit
            // 
            this.cmbDebitKredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDebitKredit.FormattingEnabled = true;
            this.cmbDebitKredit.Items.AddRange(new object[] {
            "Debit",
            "Kredit"});
            this.cmbDebitKredit.Location = new System.Drawing.Point(91, 161);
            this.cmbDebitKredit.Name = "cmbDebitKredit";
            this.cmbDebitKredit.Size = new System.Drawing.Size(100, 21);
            this.cmbDebitKredit.TabIndex = 16;
            // 
            // txtNominal
            // 
            this.txtNominal.Location = new System.Drawing.Point(91, 135);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(100, 20);
            this.txtNominal.TabIndex = 14;
            this.txtNominal.Text = "0";
            this.txtNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Debit/Kredit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nominal";
            // 
            // txtNasabah
            // 
            this.txtNasabah.Enabled = false;
            this.txtNasabah.Location = new System.Drawing.Point(91, 81);
            this.txtNasabah.Name = "txtNasabah";
            this.txtNasabah.Size = new System.Drawing.Size(234, 20);
            this.txtNasabah.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nasabah";
            // 
            // txtNoRekening
            // 
            this.txtNoRekening.Enabled = false;
            this.txtNoRekening.Location = new System.Drawing.Point(91, 52);
            this.txtNoRekening.Name = "txtNoRekening";
            this.txtNoRekening.Size = new System.Drawing.Size(100, 20);
            this.txtNoRekening.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "No. Rekening";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 38);
            this.panel1.TabIndex = 15;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(4, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(52, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "lblHeader";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(91, 109);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(100, 20);
            this.dtpTanggal.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tanggal";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmEntriPemasukanPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 269);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbDebitKredit);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNasabah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoRekening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.label5);
            this.Name = "FrmEntriPemasukanPengeluaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntriPemasukanPengeluaran";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbDebitKredit;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNasabah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoRekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}