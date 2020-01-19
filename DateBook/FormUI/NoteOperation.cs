using DateBook.BLL.Concrete;
using DateBook.DAL.Concrete;
using DateBook.DAL.Entity;
using DateBook.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBook.FormUI
{
    public partial class NoteOperation : Form
    {
        NoteManager noteManager;
        public NoteOperation()
        {
            InitializeComponent();
            noteManager = new NoteManager(new NoteDal());
        }

        private void Note_Load(object sender, EventArgs e)
        {
            CalculateToday();
            GetAll();

        }

        void CalculateToday()
        {
            lblToday.Text = DateTime.Today.ToString("D");
        }

        private void tbxPrice_TextChanged(object sender, EventArgs e)
        {
            lblStringMoney.Text = $"{Helper.StringMoney(int.Parse(txtPaymentAmount.Text == "" ? "0" : txtPaymentAmount.Text))} TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNote();
            Helper.ClearForm(grpNote);
        }



        void AddNote()
        {
            try
            {
                Note note = new Note
                {
                    Tittle = txtTittle.Text,
                    Description = rtbDescription.Text,
                    FinishDate = dtpFinishDate.Value,
                    PaymentAmount = Convert.ToDecimal(txtPaymentAmount.Text),
                };
                noteManager.Add(note);
                MessageBox.Show("Notunuz Kaydedilmiştir");
                GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void GetAll()
        {
            dgvNoteList.DataSource = noteManager.GetAll().Select(x => new
            {
                BitisTarihi = x.FinishDate,
                Baslık = x.Tittle,
                Aciklama = x.Description,
                Tutar = x.PaymentAmount
            }).ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Helper.Sms();
        }
    }
}
