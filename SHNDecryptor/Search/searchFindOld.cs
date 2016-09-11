using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SHNDecrypt.Search
{
    public partial class searchFindOld : Form
    {
        frmMain main;
        Dictionary<int, int> originIndex = new Dictionary<int, int>(); //this, other
        public searchFindOld(frmMain main)
        {
            this.main = main;
            InitializeComponent();
            dataGrid.DoubleBuffered(true);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            if (main != null)
                Location = new Point(main.Location.X + main.Width / 2 - Width / 2,
                    main.Location.Y + main.Height / 2 - Height / 2);
            Init();
            radioContains.Checked = true;
            button2_Click(null, null);
            this.ActiveControl = txtFor;
        }

        public bool Contains(string input, string Filter)
        {
            Regex tester = new Regex(Filter);
            return tester.IsMatch(input);
        }

        public void Init()
        {
            if (main.file == null) return;
            cmbIn.Items.Clear();
            originIndex.Clear();
            for (int i = 0; i < main.file.table.Columns.Count; i++)
            {
                DataColumn lol = main.file.table.Columns[i];
                cmbIn.Items.Add(i.ToString("00") + ": " + lol.ToString());
            }
            cmbIn.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGrid.Columns.Count > 1)
            {
                dataGrid.DataSource = null;
                //Init();
                originIndex.Clear();
            }
            try
            {
                if (main.file == null) return;
                int colId = Convert.ToInt32(cmbIn.Text.Substring(0, 2));
                DataTable search = new DataTable();
                search = main.file.table.Clone();
                for (int i = 0; i < main.file.table.Rows.Count; i++)
                {
                    DataRow row = main.file.table.Rows[i];
                    // if (row[colId].ToString().ToLower().Contains(txtFor.Text.ToLower()))
                    if (radioContains.Checked == true)
                    {
                        if (Contains(row[colId].ToString().ToLower(), txtFor.Text.ToLower()))
                        {
                            originIndex.Add(search.Rows.Count, i);
                            search.ImportRow(row);
                        }
                    }
                    else if (radioEquals.Checked == true)
                    {
                        if (Equals(row[colId].ToString().ToLower(), txtFor.Text.ToLower()))
                        {
                            originIndex.Add(search.Rows.Count, i);
                            search.ImportRow(row);
                        }
                    }
                    else if (radioEndsWith.Checked == true)
                    {
                        if (row[colId].ToString().ToLower().EndsWith(txtFor.Text.ToLower()))
                        {
                            originIndex.Add(search.Rows.Count, i);
                            search.ImportRow(row);
                        }
                    }
                    else if (radioStartsWith.Checked == true)
                    {
                        if (row[colId].ToString().ToLower().StartsWith(txtFor.Text.ToLower()))
                        {
                            originIndex.Add(search.Rows.Count, i);
                            search.ImportRow(row);
                        }
                    }
                }
                dataGrid.DataSource = search;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (String.IsNullOrEmpty(txtFor.Text) == true)
                ((DataTable)dataGrid.DataSource).DefaultView.Sort = string.Empty;
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!originIndex.ContainsKey(e.RowIndex))
            {
                main.dataGrid.ClearSelection();
                main.dataGrid.FirstDisplayedCell = main.dataGrid[0, dataGrid.CurrentCell.RowIndex];
                main.dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Selected = true;
            }
            else
            {
                main.dataGrid.ClearSelection();
                main.dataGrid.FirstDisplayedCell = main.dataGrid[0, originIndex[e.RowIndex]];
                main.dataGrid.Rows[originIndex[e.RowIndex]].Selected = true;
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (((DataTable)dataGrid.DataSource).DefaultView.Sort == string.Empty)
                {
                    if (!originIndex.ContainsKey(e.RowIndex))
                    {
                        main.dataGrid.CurrentCell = main.dataGrid.Rows[dataGrid.CurrentCell.RowIndex].Cells[dataGrid.CurrentCell.ColumnIndex];
                    }
                    else
                    {
                        main.dataGrid.CurrentCell = main.dataGrid.Rows[originIndex[e.RowIndex]].Cells[dataGrid.CurrentCell.ColumnIndex];
                    }
                }
            }
            catch { }
        }

        private void searchFindOld_Activated(object sender, EventArgs e)
        {
            string[] filename = this.Text.Trim().Split(':');
            if (filename[1].Trim() != main.FileTab.SelectedTab.Text.Trim())
            {
                Init();
                this.Text = "Find: " + main.FileTab.SelectedTab.Text;
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Hide();
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
