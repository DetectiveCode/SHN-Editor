using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHNDecrypt.Search
{
    public partial class searchFilter : Form
    {
        frmMain main;
        public searchFilter(frmMain main)
        {
            this.main = main;
            InitializeComponent();
        }

        public void Init()
        {
            if (main.file == null) return;
            cmbIn.Items.Clear();
            for (int i = 0; i < main.file.table.Columns.Count; i++)
            {
                DataColumn lol = main.file.table.Columns[i];
                cmbIn.Items.Add(i.ToString("00") + ": " + lol.ToString());
            }
            cmbIn.SelectedIndex = 0;

        }

        private void searchFindModern_Load(object sender, EventArgs e)
        {
            if (main != null)
                Location = new Point(main.Location.X + main.Width / 2 - Width / 2,
                    main.Location.Y + main.Height / 2 - Height / 2);
            Init();
            radioContains.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] comboText = cmbIn.Text.Split(':');

            if (String.IsNullOrEmpty(txtFor.Text))
            {
                main.file.table.DefaultView.RowFilter = null;
            }
            else
            {
                if (radioContains.Checked)
                {
                    main.file.table.DefaultView.RowFilter = String.Format("Convert({0}, 'System.String') LIKE '%{1}%'", comboText[1], txtFor.Text);
                }
                else if (radioEquals.Checked)
                {
                    main.file.table.DefaultView.RowFilter = String.Format("Convert({0}, 'System.String') = '{1}'", comboText[1], txtFor.Text);
                }
                else if (radioStartsWith.Checked)
                {
                    main.file.table.DefaultView.RowFilter = String.Format("Convert({0}, 'System.String') LIKE '{1}*'", comboText[1], txtFor.Text);
                }
                else if (radioEndsWith.Checked)
                {
                    main.file.table.DefaultView.RowFilter = String.Format("Convert({0}, 'System.String') LIKE '*{1}'", comboText[1], txtFor.Text);
                }
            }
        }

        private void searchFindModern_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void searchFindModern_Activated(object sender, EventArgs e)
        {
            Init();
            this.Text = "Filter: " + main.FileTab.SelectedTab.Text;
        }
    }
}
