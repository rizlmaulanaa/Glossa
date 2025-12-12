// form utama aplikasi glosarium
// menyediakan fitur crud, filter kategori, dan membuka mode quiz
// tampilan dibuat modern sederhana dengan spacing dan padding

using GlossaryApp.Models;
using GlossaryApp.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GlossaryApp
{
    public partial class MainForm : Form
    {
        private readonly GlossaryService _service;

        public MainForm()
        {
            InitializeComponent();
            _service = new GlossaryService();

            // isi dropdown kategori
            comboFilter.DataSource = Enum.GetValues(typeof(GlossaryCategory));

            RefreshData();
        }

        private void RefreshData()
        {
            // ambil kategori aktif
            var selected = (GlossaryCategory)comboFilter.SelectedItem;

            // ambil data sesuai kategori
            var data = _service.GetByCategory(selected);

            dataGrid.DataSource = data
                .Select(x => new
                {
                    x.Id,
                    x.Term,
                    x.Definition,
                    Category = x.Category.ToString()
                })
                .ToList();

            labelCount.Text = $"jumlah istilah: {data.Count}";
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                _service.Add(form.Data);
                RefreshData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("pilih baris dulu");
                return;
            }

            int id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);
            var item = _service.GetAll().First(x => x.Id == id);

            var form = new AddEditForm(item);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _service.Update(form.Data);
                RefreshData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("pilih baris dulu");
                return;
            }

            int id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("hapus data ini?", "konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.Delete(id);
                RefreshData();
            }
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            var quiz = new QuizForm(_service);
            quiz.ShowDialog();
        }
    }
}
