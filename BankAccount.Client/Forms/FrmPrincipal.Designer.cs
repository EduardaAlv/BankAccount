namespace BankAccount
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            criarContaBancáriaToolStripMenuItem = new ToolStripMenuItem();
            verContasBancariasToolStripMenuItem = new ToolStripMenuItem();
            creditsMenu = new ToolStripMenuItem();
            panelConteudo = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { criarContaBancáriaToolStripMenuItem, verContasBancariasToolStripMenuItem, creditsMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // criarContaBancáriaToolStripMenuItem
            // 
            criarContaBancáriaToolStripMenuItem.Name = "criarContaBancáriaToolStripMenuItem";
            criarContaBancáriaToolStripMenuItem.Size = new Size(139, 20);
            criarContaBancáriaToolStripMenuItem.Text = "Create a Account Bank";
            criarContaBancáriaToolStripMenuItem.Click += criarContaBancáriaToolStripMenuItem_Click;
            // 
            // verContasBancariasToolStripMenuItem
            // 
            verContasBancariasToolStripMenuItem.Name = "verContasBancariasToolStripMenuItem";
            verContasBancariasToolStripMenuItem.Size = new Size(124, 20);
            verContasBancariasToolStripMenuItem.Text = "View bank accounts";
            verContasBancariasToolStripMenuItem.Click += verContasBancáriasToolStripMenuItem_Click;
            // 
            // creditsMenu
            // 
            creditsMenu.Name = "creditsMenu";
            creditsMenu.Size = new Size(56, 20);
            creditsMenu.Text = "Credits";
            creditsMenu.Click += creditsMenuToolStripMenuItem_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelConteudo.Location = new Point(0, 28);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(798, 414);
            panelConteudo.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelConteudo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem criarContaBancáriaToolStripMenuItem;
        private ToolStripMenuItem verContasBancariasToolStripMenuItem;
        private ToolStripMenuItem creditsMenu;
        private Panel panelConteudo;
    }
}
