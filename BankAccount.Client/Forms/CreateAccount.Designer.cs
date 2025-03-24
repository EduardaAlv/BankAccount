namespace BankAccount.Forms
{
    partial class CreateAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblCreateAccount = new Label();
            LblName = new Label();
            TxbNomeCompleto = new TextBox();
            textBox1 = new TextBox();
            LblCPF = new Label();
            LblBirthDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // LblCreateAccount
            // 
            LblCreateAccount.AutoSize = true;
            LblCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCreateAccount.Location = new Point(27, 24);
            LblCreateAccount.Name = "LblCreateAccount";
            LblCreateAccount.Size = new Size(149, 21);
            LblCreateAccount.TabIndex = 0;
            LblCreateAccount.Text = "Create your account";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(27, 68);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 1;
            LblName.Text = "Name:";
            // 
            // TxbNomeCompleto
            // 
            TxbNomeCompleto.Location = new Point(27, 86);
            TxbNomeCompleto.Name = "TxbNomeCompleto";
            TxbNomeCompleto.Size = new Size(309, 23);
            TxbNomeCompleto.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 4;
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Location = new Point(27, 126);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(31, 15);
            LblCPF.TabIndex = 3;
            LblCPF.Text = "CPF:";
            // 
            // LblBirthDate
            // 
            LblBirthDate.AutoSize = true;
            LblBirthDate.Location = new Point(27, 189);
            LblBirthDate.Name = "LblBirthDate";
            LblBirthDate.Size = new Size(62, 15);
            LblBirthDate.TabIndex = 6;
            LblBirthDate.Text = "Birth Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(397, 288);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += button1_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(LblBirthDate);
            Controls.Add(textBox1);
            Controls.Add(LblCPF);
            Controls.Add(TxbNomeCompleto);
            Controls.Add(LblName);
            Controls.Add(LblCreateAccount);
            Name = "CreateAccount";
            Size = new Size(533, 357);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCreateAccount;
        private Label LblName;
        private TextBox TxbNomeCompleto;
        private TextBox textBox1;
        private Label LblCPF;
        private Label LblBirthDate;
        private DateTimePicker dateTimePicker1;
        private Button BtnSave;
    }
}
