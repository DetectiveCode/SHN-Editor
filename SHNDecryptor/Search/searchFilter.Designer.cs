namespace SHNDecrypt.Search
{
    partial class searchFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchFilter));
            this.radioEndsWith = new System.Windows.Forms.RadioButton();
            this.radioStartsWith = new System.Windows.Forms.RadioButton();
            this.radioEquals = new System.Windows.Forms.RadioButton();
            this.radioContains = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbIn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioEndsWith
            // 
            this.radioEndsWith.AutoSize = true;
            this.radioEndsWith.Location = new System.Drawing.Point(281, 63);
            this.radioEndsWith.Name = "radioEndsWith";
            this.radioEndsWith.Size = new System.Drawing.Size(74, 17);
            this.radioEndsWith.TabIndex = 15;
            this.radioEndsWith.TabStop = true;
            this.radioEndsWith.Text = "Ends With";
            this.radioEndsWith.UseVisualStyleBackColor = true;
            // 
            // radioStartsWith
            // 
            this.radioStartsWith.AutoSize = true;
            this.radioStartsWith.Location = new System.Drawing.Point(281, 46);
            this.radioStartsWith.Name = "radioStartsWith";
            this.radioStartsWith.Size = new System.Drawing.Size(77, 17);
            this.radioStartsWith.TabIndex = 14;
            this.radioStartsWith.TabStop = true;
            this.radioStartsWith.Text = "Starts With";
            this.radioStartsWith.UseVisualStyleBackColor = true;
            // 
            // radioEquals
            // 
            this.radioEquals.AutoSize = true;
            this.radioEquals.Location = new System.Drawing.Point(281, 29);
            this.radioEquals.Name = "radioEquals";
            this.radioEquals.Size = new System.Drawing.Size(57, 17);
            this.radioEquals.TabIndex = 13;
            this.radioEquals.TabStop = true;
            this.radioEquals.Text = "Equals";
            this.radioEquals.UseVisualStyleBackColor = true;
            // 
            // radioContains
            // 
            this.radioContains.AutoSize = true;
            this.radioContains.Location = new System.Drawing.Point(281, 12);
            this.radioContains.Name = "radioContains";
            this.radioContains.Size = new System.Drawing.Size(66, 17);
            this.radioContains.TabIndex = 12;
            this.radioContains.TabStop = true;
            this.radioContains.Text = "Contains";
            this.radioContains.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(80, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(194, 24);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbIn
            // 
            this.cmbIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIn.FormattingEnabled = true;
            this.cmbIn.Location = new System.Drawing.Point(80, 35);
            this.cmbIn.Name = "cmbIn";
            this.cmbIn.Size = new System.Drawing.Size(194, 21);
            this.cmbIn.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search in:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search for:";
            // 
            // txtFor
            // 
            this.txtFor.Location = new System.Drawing.Point(80, 9);
            this.txtFor.Name = "txtFor";
            this.txtFor.Size = new System.Drawing.Size(194, 20);
            this.txtFor.TabIndex = 7;
            // 
            // searchFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 97);
            this.Controls.Add(this.radioEndsWith);
            this.Controls.Add(this.radioStartsWith);
            this.Controls.Add(this.radioEquals);
            this.Controls.Add(this.radioContains);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "searchFilter";
            this.Text = "Filter";
            this.Activated += new System.EventHandler(this.searchFindModern_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.searchFindModern_FormClosing);
            this.Load += new System.EventHandler(this.searchFindModern_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioEndsWith;
        private System.Windows.Forms.RadioButton radioStartsWith;
        private System.Windows.Forms.RadioButton radioEquals;
        private System.Windows.Forms.RadioButton radioContains;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFor;

    }
}