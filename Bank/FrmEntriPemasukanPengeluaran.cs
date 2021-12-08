using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class FrmEntriPemasukanPengeluaran : Form
    {

        public delegate void CreateUpdateEventHandler(Bank bank);

        public event CreateUpdateEventHandler OnCreate;

        // constructor default
        public FrmEntriPemasukanPengeluaran()
        {
            InitializeComponent();
            cmbDebitKredit.SelectedIndex = 0;
        }

        public FrmEntriPemasukanPengeluaran(string header, string noRekening, string nasabah)
            : this() // panggil constructor default
        {
            this.Text = header;
            lblHeader.Text = header;

            txtNoRekening.Text = noRekening;
            txtNasabah.Text = nasabah;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank();
            bank.no = txtNoRekening.Text;
            bank.nasabah = txtNasabah.Text;
            bank.tanggal = dtpTanggal.Text;
            bank.nominal = Int32.Parse(txtNominal.Text);
            bank.jenis = cmbDebitKredit.Text;

            OnCreate(bank);

            txtNominal.Text = "0";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
