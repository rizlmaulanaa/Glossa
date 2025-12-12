namespace GlossaryApp
{
    partial class QuizForm
    {
        private Label labelQuestion;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb4;
        private Button btnCheck;
        private Button btnShowDef;
        private Button btnNext;
        private Label lblResult;

        private void InitializeComponent()
        {
            labelQuestion = new Label();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            btnCheck = new Button();
            btnShowDef = new Button();
            btnNext = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelQuestion.Location = new Point(20, 20);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(400, 40);
            labelQuestion.TabIndex = 0;
            // 
            // rb1
            // 
            rb1.Location = new Point(30, 70);
            rb1.Name = "rb1";
            rb1.Size = new Size(400, 24);
            rb1.TabIndex = 1;
            // 
            // rb2
            // 
            rb2.Location = new Point(30, 100);
            rb2.Name = "rb2";
            rb2.Size = new Size(400, 24);
            rb2.TabIndex = 2;
            // 
            // rb3
            // 
            rb3.Location = new Point(30, 130);
            rb3.Name = "rb3";
            rb3.Size = new Size(400, 24);
            rb3.TabIndex = 3;
            // 
            // rb4
            // 
            rb4.Location = new Point(30, 160);
            rb4.Name = "rb4";
            rb4.Size = new Size(400, 24);
            rb4.TabIndex = 4;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(30, 210);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(114, 36);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "cek jawaban";
            btnCheck.Click += btnCheck_Click;
            // 
            // btnShowDef
            // 
            btnShowDef.Location = new Point(150, 210);
            btnShowDef.Name = "btnShowDef";
            btnShowDef.Size = new Size(113, 36);
            btnShowDef.TabIndex = 6;
            btnShowDef.Text = "Petunjuk";
            btnShowDef.Click += btnShowDef_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(300, 210);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(130, 36);
            btnNext.TabIndex = 7;
            btnNext.Text = "Selanjutnya";
            btnNext.Click += btnNext_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResult.Location = new Point(30, 260);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(300, 40);
            lblResult.TabIndex = 8;
            // 
            // QuizForm
            // 
            ClientSize = new Size(701, 519);
            Controls.Add(labelQuestion);
            Controls.Add(rb1);
            Controls.Add(rb2);
            Controls.Add(rb3);
            Controls.Add(rb4);
            Controls.Add(btnCheck);
            Controls.Add(btnShowDef);
            Controls.Add(btnNext);
            Controls.Add(lblResult);
            Name = "QuizForm";
            Text = "Quiz Glosarium";
            ResumeLayout(false);
        }
    }
}
