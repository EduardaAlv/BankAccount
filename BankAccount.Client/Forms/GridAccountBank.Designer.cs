namespace BankAccount.Forms
{
    partial class GridAccountBank
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
            GridAccountBankGrid = new DataGridView();
            NumberAccount = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GridAccountBankGrid).BeginInit();
            SuspendLayout();
            // 
            // GridAccountBankGrid
            // 
            GridAccountBankGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridAccountBankGrid.Columns.AddRange(new DataGridViewColumn[] { NumberAccount, Name, BirthDate });
            GridAccountBankGrid.Location = new Point(88, 43);
            GridAccountBankGrid.Name = "GridAccountBankGrid";
            GridAccountBankGrid.Size = new Size(366, 150);
            GridAccountBankGrid.TabIndex = 0;
            // 
            // NumberAccount
            // 
            NumberAccount.HeaderText = "Number Account";
            NumberAccount.Name = "NumberAccount";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "Birth Date";
            BirthDate.Name = "BirthDate";
            // 
            // GridAccountBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GridAccountBankGrid);
            Size = new Size(496, 322);
            ((System.ComponentModel.ISupportInitialize)GridAccountBankGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridAccountBankGrid;
        private DataGridViewTextBoxColumn NumberAccount;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn BirthDate;
    }
}
