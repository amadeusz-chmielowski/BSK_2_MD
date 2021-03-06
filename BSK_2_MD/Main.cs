﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace BSK_2_MD
{
    public partial class Main : MaterialForm
    {
        private SelectQueries selectQueries = new SelectQueries();
        private InsertQueries insertQueries = new InsertQueries();
        private int insertQueryIndex = 0;
        private int selectQueryIndex = 0;
        private SqlConnector sqlConnector = null;
        public Main(ref SqlConnector sqlConnector)
        {
            this.sqlConnector = sqlConnector;
            InitializeComponent();
            FillList();
        }
        public void FillList()
        {
            try
            {
                foreach (KeyValuePair<int, string> entry in selectQueries.ListQueries)
                {
                    selectListBox.Items.Add(entry.Value, false);
                }
                foreach (KeyValuePair<int, string> entry in insertQueries.ListQueries)
                {
                    insertListBox.Items.Add(entry.Value, false);
                }

                selectListBox.SetItemChecked(0, true);
                insertListBox.SetItemChecked(0, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void selectListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && selectListBox.CheckedItems.Count > 0)
            {
                selectListBox.ItemCheck -= selectListBox_ItemCheck;
                selectListBox.SetItemChecked(selectListBox.CheckedIndices[0], false);
                selectListBox.ItemCheck += selectListBox_ItemCheck;
                selectQueryIndex = selectListBox.SelectedIndex;
                var selected = selectListBox.SelectedItem.ToString();
            }
        }

        private void insertListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && insertListBox.CheckedItems.Count > 0)
            {
                insertListBox.ItemCheck -= insertListBox_ItemCheck;
                insertListBox.SetItemChecked(insertListBox.CheckedIndices[0], false);
                insertListBox.ItemCheck += insertListBox_ItemCheck;
                insertQueryIndex = insertListBox.SelectedIndex;
                var selected = insertListBox.SelectedItem.ToString();
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (selectQueryIndex != -1)
            {
                selectTextOutput.Text = "";
                var output = sqlConnector.ExecuteCommandSelect(selectQueryIndex);
                selectTextOutput.Text = output;
            }
            else
            {
                MessageBox.Show("No query selected");
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (insertQueryIndex != -1)
            {
                insertTexBoxOutput.Text = "";
                var output = sqlConnector.ExecuteCommandInsert(insertQueryIndex);
                insertTexBoxOutput.Text = output;
            }
            else
            {
                MessageBox.Show("No query selected");
            }
        }
    }
}
