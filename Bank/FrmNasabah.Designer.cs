﻿
namespace Bank
{
    partial class FrmNasabah
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
            this.lvwHistoriPemasukanPengeluaran = new System.Windows.Forms.ListView();
            this.txtNasabah = new System.Windows.Forms.TextBox();
            this.lblTotalKredit = new System.Windows.Forms.Label();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoRekening = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwHistoriPemasukanPengeluaran
            // 
            this.lvwHistoriPemasukanPengeluaran.HideSelection = false;
            this.lvwHistoriPemasukanPengeluaran.Location = new System.Drawing.Point(12, 90);
            this.lvwHistoriPemasukanPengeluaran.Name = "lvwHistoriPemasukanPengeluaran";
            this.lvwHistoriPemasukanPengeluaran.Size = new System.Drawing.Size(348, 213);
            this.lvwHistoriPemasukanPengeluaran.TabIndex = 8;
            this.lvwHistoriPemasukanPengeluaran.UseCompatibleStateImageBehavior = false;
            // 
            // txtNasabah
            // 
            this.txtNasabah.Location = new System.Drawing.Point(88, 45);
            this.txtNasabah.Name = "txtNasabah";
            this.txtNasabah.Size = new System.Drawing.Size(234, 20);
            this.txtNasabah.TabIndex = 7;
            // 
            // lblTotalKredit
            // 
            this.lblTotalKredit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalKredit.Location = new System.Drawing.Point(255, 306);
            this.lblTotalKredit.Name = "lblTotalKredit";
            this.lblTotalKredit.Size = new System.Drawing.Size(100, 20);
            this.lblTotalKredit.TabIndex = 11;
            this.lblTotalKredit.Text = "0";
            this.lblTotalKredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalDebit.Location = new System.Drawing.Point(152, 306);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(100, 20);
            this.lblTotalDebit.TabIndex = 10;
            this.lblTotalDebit.Text = "0";
            this.lblTotalDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nasabah";
            // 
            // txtNoRekening
            // 
            this.txtNoRekening.Location = new System.Drawing.Point(88, 16);
            this.txtNoRekening.Name = "txtNoRekening";
            this.txtNoRekening.Size = new System.Drawing.Size(100, 20);
            this.txtNoRekening.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "No. Rekening";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Input Pemasukan/Pengeluaran";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvwHistoriPemasukanPengeluaran);
            this.Controls.Add(this.txtNasabah);
            this.Controls.Add(this.lblTotalKredit);
            this.Controls.Add(this.lblTotalDebit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoRekening);
            this.Controls.Add(this.label1);
            this.Name = "FrmNasabah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nasabah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvwHistoriPemasukanPengeluaran;
        private System.Windows.Forms.TextBox txtNasabah;
        private System.Windows.Forms.Label lblTotalKredit;
        private System.Windows.Forms.Label lblTotalDebit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoRekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

