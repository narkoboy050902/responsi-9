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
    public partial class FrmNasabah : Form
    {
        private int totalDebit = 0;
        private int totalKredit = 0;


        private IList<Bank> listOfBank = new List<Bank>();

        public FrmNasabah()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            lvwHistoriPemasukanPengeluaran.View = View.Details;
            lvwHistoriPemasukanPengeluaran.FullRowSelect = true;
            lvwHistoriPemasukanPengeluaran.GridLines = true;

            lvwHistoriPemasukanPengeluaran.Columns.Add("No.", 40, HorizontalAlignment.Center);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Tanggal", 100, HorizontalAlignment.Center);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Debit", 100, HorizontalAlignment.Right);
            lvwHistoriPemasukanPengeluaran.Columns.Add("Kredit", 100, HorizontalAlignment.Right);
        }

        private void FrmEntry_OnCreate(Bank bank)
        {
            listOfBank.Add(bank);
            int noUrut = lvwHistoriPemasukanPengeluaran.Items.Count + 1;
            ListViewItem item = new ListViewItem(String.Format("{0}", noUrut));
            
            item.SubItems.Add(bank.tanggal);
            if (bank.jenis == "Kredit")
            {
                totalKredit += bank.nominal;
                item.SubItems.Add("0");
                item.SubItems.Add(String.Format("{0}", bank.nominal));
            }
            else
            {
                totalDebit += bank.nominal;
                item.SubItems.Add(String.Format("{0}", bank.nominal));
                item.SubItems.Add("0");
            }
            lblTotalDebit.Text = String.Format("{0}", totalDebit);
            lblTotalKredit.Text = String.Format("{0}", totalKredit);

            lvwHistoriPemasukanPengeluaran.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string header = "Entri Pemasukan / Pengeluaran";
            string noRekening = txtNoRekening.Text;
            string nasabah = txtNasabah.Text;
            FrmEntriPemasukanPengeluaran frmEntry = new FrmEntriPemasukanPengeluaran(header, noRekening, nasabah
                );
            frmEntry.OnCreate += FrmEntry_OnCreate;
            frmEntry.ShowDialog();
        }
    }
}
