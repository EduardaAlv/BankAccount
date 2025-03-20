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
            LblNomeCompleto = new Label();
            TxbNomeCompleto = new TextBox();
            textBox1 = new TextBox();
            LblCPF = new Label();
            LblDataNascimento = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // LblCreateAccount
            // 
            LblCreateAccount.AutoSize = true;
            LblCreateAccount.Location = new Point(27, 13);
            LblCreateAccount.Name = "LblCreateAccount";
            LblCreateAccount.Size = new Size(114, 15);
            LblCreateAccount.TabIndex = 0;
            LblCreateAccount.Text = "Create your account";
            // 
            // LblNomeCompleto
            // 
            LblNomeCompleto.AutoSize = true;
            LblNomeCompleto.Location = new Point(27, 41);
            LblNomeCompleto.Name = "LblNomeCompleto";
            LblNomeCompleto.Size = new Size(97, 15);
            LblNomeCompleto.TabIndex = 1;
            LblNomeCompleto.Text = "Nome completo:";
            // 
            // TxbNomeCompleto
            // 
            TxbNomeCompleto.Location = new Point(27, 59);
            TxbNomeCompleto.Name = "TxbNomeCompleto";
            TxbNomeCompleto.Size = new Size(309, 23);
            TxbNomeCompleto.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 4;
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Location = new Point(27, 99);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(31, 15);
            LblCPF.TabIndex = 3;
            LblCPF.Text = "CPF:";
            // 
            // LblDataNascimento
            // 
            LblDataNascimento.AutoSize = true;
            LblDataNascimento.Location = new Point(27, 162);
            LblDataNascimento.Name = "LblDataNascimento";
            LblDataNascimento.Size = new Size(115, 15);
            LblDataNascimento.TabIndex = 6;
            LblDataNascimento.Text = "Data de nascimento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(LblDataNascimento);
            Controls.Add(textBox1);
            Controls.Add(LblCPF);
            Controls.Add(TxbNomeCompleto);
            Controls.Add(LblNomeCompleto);
            Controls.Add(LblCreateAccount);
            Name = "CreateAccount";
            Size = new Size(533, 357);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCreateAccount;
        private Label LblNomeCompleto;
        private TextBox TxbNomeCompleto;
        private TextBox textBox1;
        private Label LblCPF;
        private Label LblDataNascimento;
        private DateTimePicker dateTimePicker1;
    }
}
