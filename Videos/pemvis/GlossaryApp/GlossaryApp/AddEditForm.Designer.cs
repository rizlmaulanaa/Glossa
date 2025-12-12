namespace GlossaryApp
{
    partial class AddEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTerm;
        private TextBox txtDefinition;
        private ComboBox comboCategory;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTerm = new TextBox();
            txtDefinition = new TextBox();
            comboCategory = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();

            // txtTerm
            txtTerm.Location = new System.Drawing.Point(30, 45);
            txtTerm.Width = 250;

            // txtDefinition
            txtDefinition.Location = new System.Drawing.Point(30, 110);
            txtDefinition.Width = 250;
            txtDefinition.Height = 80;
            txtDefinition.Multiline = true;

            // comboCategory
            comboCategory.Location = new System.Drawing.Point(30, 230);
            comboCategory.Width = 250;

            // btnSave
            btnSave.Text = "simpan";
            btnSave.Location = new System.Drawing.Point(30, 280);
            btnSave.Click += btnSave_Click;

            // labels
            label1.Text = "istilah:";
            label1.Location = new System.Drawing.Point(30, 25);

            label2.Text = "definisi:";
            label2.Location = new System.Drawing.Point(30, 90);

            label3.Text = "kategori:";
            label3.Location = new System.Drawing.Point(30, 210);

            // form
            ClientSize = new System.Drawing.Size(320, 350);
            Controls.Add(txtTerm);
            Controls.Add(txtDefinition);
            Controls.Add(comboCategory);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Text = "Tambah / Edit Glosarium";
            ResumeLayout(false);
        }
    }
}
