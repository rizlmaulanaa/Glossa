// form untuk menambah atau mengedit glosarium
// ui simple: textbox istilah, textbox definisi, combobox kategori

using GlossaryApp.Models;
using System;
using System.Windows.Forms;

namespace GlossaryApp
{
    public partial class AddEditForm : Form
    {
        public GlossaryItem Data { get; private set; }

        public AddEditForm(GlossaryItem item = null)
        {
            InitializeComponent();

            // isi combobox kategori
            comboCategory.DataSource = Enum.GetValues(typeof(GlossaryCategory));

            // jika edit mode
            if (item != null)
            {
                txtTerm.Text = item.Term;
                txtDefinition.Text = item.Definition;
                comboCategory.SelectedItem = item.Category;
                Data = item;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validasi sederhana
            if (txtTerm.Text.Trim() == "" || txtDefinition.Text.Trim() == "")
            {
                MessageBox.Show("istilah dan definisi tidak boleh kosong");
                return;
            }

            // jika add
            if (Data == null)
                Data = new GlossaryItem();

            // isi data
            Data.Term = txtTerm.Text.Trim();
            Data.Definition = txtDefinition.Text.Trim();
            Data.Category = (GlossaryCategory)comboCategory.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
