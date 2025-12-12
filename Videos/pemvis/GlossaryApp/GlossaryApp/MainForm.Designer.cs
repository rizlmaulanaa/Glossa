namespace GlossaryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label labelTitle;
        private DataGridView dataGrid;
        private ComboBox comboFilter;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnQuiz;
        private Label labelFilter;
        private Label labelCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            labelTitle = new Label();
            dataGrid = new DataGridView();
            comboFilter = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnQuiz = new Button();
            labelFilter = new Label();
            labelCount = new Label();

            SuspendLayout();

            // ===== HEADER PANEL =====
            headerPanel.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;

            labelTitle.Text = "📘 Aplikasi Glosarium Pemrograman";
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Location = new System.Drawing.Point(20, 18);

            headerPanel.Controls.Add(labelTitle);

            // ===== DATAGRID =====
            dataGrid.Location = new System.Drawing.Point(20, 130);
            dataGrid.Width = 700;
            dataGrid.Height = 350;
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGrid.BorderStyle = BorderStyle.FixedSingle;

            // ===== FILTER =====
            labelFilter.Text = "kategori:";
            labelFilter.Location = new System.Drawing.Point(20, 80);
            labelFilter.AutoSize = true;

            comboFilter.Location = new System.Drawing.Point(90, 75);
            comboFilter.SelectedIndexChanged += comboFilter_SelectedIndexChanged;

            // ===== COUNT LABEL =====
            labelCount.Text = "jumlah istilah: 0";
            labelCount.Location = new System.Drawing.Point(20, 500);
            labelCount.AutoSize = true;
            labelCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);

            // ===== BUTTONS (MODERN STYLE) =====
            btnAdd.Text = "tambah";
            btnAdd.Location = new System.Drawing.Point(250, 75);
            btnAdd.Click += btnAdd_Click;
            ModernButton(btnAdd);

            btnEdit.Text = "edit";
            btnEdit.Location = new System.Drawing.Point(340, 75);
            btnEdit.Click += btnEdit_Click;
            ModernButton(btnEdit);

            btnDelete.Text = "hapus";
            btnDelete.Location = new System.Drawing.Point(430, 75);
            btnDelete.Click += btnDelete_Click;
            ModernButton(btnDelete);

            btnQuiz.Text = "mode quiz";
            btnQuiz.Location = new System.Drawing.Point(520, 75);
            btnQuiz.Click += btnQuiz_Click;
            ModernButton(btnQuiz);

            // ===== MAIN FORM =====
            ClientSize = new System.Drawing.Size(750, 550);
            Controls.Add(headerPanel);
            Controls.Add(dataGrid);
            Controls.Add(comboFilter);
            Controls.Add(labelFilter);
            Controls.Add(labelCount);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnQuiz);

            Text = "Glosarium App";
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
        }

        private void ModernButton(Button btn)
        {
            // styling tombol modern sederhana
            btn.Width = 80;
            btn.Height = 30;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            btn.ForeColor = System.Drawing.Color.White;
        }
    }
}
