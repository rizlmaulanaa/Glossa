// form untuk quiz pilihan ganda
// soal diacak menggunakan service
// user memilih salah satu definisi

using GlossaryApp.Models;
using GlossaryApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GlossaryApp
{
    public partial class QuizForm : Form
    {
        private readonly GlossaryService _service;
        private GlossaryItem _currentItem;
        private List<string> _options;

        public QuizForm(GlossaryService service)
        {
            InitializeComponent();
            _service = service;
            GenerateQuiz();
        }

        private void GenerateQuiz()
        {
            // ambil item acak
            _currentItem = _service.GetRandomItem();

            // ambil 3 pilihan salah + 1 benar
            _options = _service.GetRandomOptions(_currentItem.Definition, 3);
            _options.Add(_currentItem.Definition);

            // acak urutan
            _options = _options.OrderBy(x => Guid.NewGuid()).ToList();

            labelQuestion.Text = $"Apa definisi dari: {_currentItem.Term}?";

            rb1.Text = _options[0];
            rb2.Text = _options[1];
            rb3.Text = _options[2];
            rb4.Text = _options[3];

            // reset radio
            rb1.Checked = rb2.Checked = rb3.Checked = rb4.Checked = false;

            lblResult.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var selected = "";

            if (rb1.Checked) selected = rb1.Text;
            if (rb2.Checked) selected = rb2.Text;
            if (rb3.Checked) selected = rb3.Text;
            if (rb4.Checked) selected = rb4.Text;

            if (selected == "")
            {
                MessageBox.Show("pilih jawaban dulu");
                return;
            }

            if (selected == _currentItem.Definition)
                lblResult.Text = "✔ benar!";
            else
                lblResult.Text = "✘ salah!";
        }

        private void btnShowDef_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_currentItem.Definition, "Definisi");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GenerateQuiz();
        }
    }
}
