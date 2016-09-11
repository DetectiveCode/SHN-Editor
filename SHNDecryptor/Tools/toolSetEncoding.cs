﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHNDecrypt.Tools
{
    public partial class toolSetEncoding : Form
    {
        frmMain enc;
        public toolSetEncoding(frmMain main)
        {
            this.enc = main;
            InitializeComponent();
            PopulateEncodingList();
        }

        protected virtual void PopulateEncodingList(string filter = "")
        {
            lstEncoding.Items.Clear();
            foreach (EncodingInfo e in Encoding.GetEncodings().Where(e => e.Name.ToUpper().Contains(filter.ToUpper())))
            {
                lstEncoding.Items.Add(e.Name);
            }
            SelectCurrentEncoding();
        }

        protected void SelectCurrentEncoding()
        {
            string encoding = Program.eT;
            if (lstEncoding.Items.Contains(encoding))
                lstEncoding.SelectedItems.Add(encoding);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEncoding.SelectedItem == null)
                {
                    MessageBox.Show("Please select an encoding type before continuing.");
                }
                else
                {
                    string selectedEncoding = lstEncoding.SelectedItem as string;
                    if (string.IsNullOrEmpty(selectedEncoding))
                    {
                        MessageBox.Show("Please select an encoding type before continuing.");
                    }
                    Program.rK.SetValue("0", selectedEncoding);
                    Program.eT = selectedEncoding;
                    lstEncoding.SelectedItem = selectedEncoding;
                    MessageBox.Show(String.Format("Encoding has been set to {0}. SHN Editor will now read and write in {0}.", selectedEncoding));
                    //Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured trying to change the encoding. " + ex.Message); ;
            }
        }

        private void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            PopulateEncodingList(tbSearchText.Text);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            Program.rK.SetValue("0", "iso-8859-1");
            Program.eT = "iso-8859-1";
            lstEncoding.SelectedItem = "iso-8859-1";
            lstEncoding.SelectedIndex = lstEncoding.SelectedIndex;
            MessageBox.Show("Encoding has been set to iso-8859-1. SHN Editor will now read and write in iso-8859-1.");
        }
    }
}
