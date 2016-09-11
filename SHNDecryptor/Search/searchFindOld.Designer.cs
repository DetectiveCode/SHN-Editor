namespace SHNDecrypt.Search
{
    partial class searchFindOld
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchFindOld));
            this.button2 = new System.Windows.Forms.Button();
            this.cmbIn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioEndsWith = new System.Windows.Forms.RadioButton();
            this.radioStartsWith = new System.Windows.Forms.RadioButton();
            this.radioEquals = new System.Windows.Forms.RadioButton();
            this.radioContains = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // cmbIn
            // 
            this.cmbIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIn.FormattingEnabled = true;
            this.cmbIn.Location = new System.Drawing.Point(79, 38);
            this.cmbIn.Name = "cmbIn";
            this.cmbIn.Size = new System.Drawing.Size(194, 21);
            this.cmbIn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search in:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for:";
            // 
            // txtFor
            // 
            this.txtFor.Location = new System.Drawing.Point(79, 12);
            this.txtFor.Name = "txtFor";
            this.txtFor.Size = new System.Drawing.Size(194, 20);
            this.txtFor.TabIndex = 0;
            this.txtFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 98);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(743, 461);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioEndsWith);
            this.panel1.Controls.Add(this.radioStartsWith);
            this.panel1.Controls.Add(this.radioEquals);
            this.panel1.Controls.Add(this.radioContains);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFor);
            this.panel1.Controls.Add(this.cmbIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 98);
            this.panel1.TabIndex = 6;
            // 
            // radioEndsWith
            // 
            this.radioEndsWith.AutoSize = true;
            this.radioEndsWith.Location = new System.Drawing.Point(280, 64);
            this.radioEndsWith.Name = "radioEndsWith";
            this.radioEndsWith.Size = new System.Drawing.Size(74, 17);
            this.radioEndsWith.TabIndex = 10;
            this.radioEndsWith.TabStop = true;
            this.radioEndsWith.Text = "Ends With";
            this.radioEndsWith.UseVisualStyleBackColor = true;
            // 
            // radioStartsWith
            // 
            this.radioStartsWith.AutoSize = true;
            this.radioStartsWith.Location = new System.Drawing.Point(280, 47);
            this.radioStartsWith.Name = "radioStartsWith";
            this.radioStartsWith.Size = new System.Drawing.Size(77, 17);
            this.radioStartsWith.TabIndex = 9;
            this.radioStartsWith.TabStop = true;
            this.radioStartsWith.Text = "Starts With";
            this.radioStartsWith.UseVisualStyleBackColor = true;
            // 
            // radioEquals
            // 
            this.radioEquals.AutoSize = true;
            this.radioEquals.Location = new System.Drawing.Point(280, 30);
            this.radioEquals.Name = "radioEquals";
            this.radioEquals.Size = new System.Drawing.Size(57, 17);
            this.radioEquals.TabIndex = 8;
            this.radioEquals.TabStop = true;
            this.radioEquals.Text = "Equals";
            this.radioEquals.UseVisualStyleBackColor = true;
            // 
            // radioContains
            // 
            this.radioContains.AutoSize = true;
            this.radioContains.Location = new System.Drawing.Point(280, 13);
            this.radioContains.Name = "radioContains";
            this.radioContains.Size = new System.Drawing.Size(66, 17);
            this.radioContains.TabIndex = 7;
            this.radioContains.TabStop = true;
            this.radioContains.Text = "Contains";
            this.radioContains.UseVisualStyleBackColor = true;
            // 
            // searchFindOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 559);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchFindOld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.Activated += new System.EventHandler(this.searchFindOld_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioEndsWith;
        private System.Windows.Forms.RadioButton radioStartsWith;
        private System.Windows.Forms.RadioButton radioEquals;
        private System.Windows.Forms.RadioButton radioContains;
    }
}