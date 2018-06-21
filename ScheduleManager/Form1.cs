﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.friday' table. You can move, or remove it, as needed.
            this.fridayTableAdapter.Fill(this.dbDataSet.friday);
            // TODO: This line of code loads data into the 'dbDataSet.thursday' table. You can move, or remove it, as needed.
            this.thursdayTableAdapter.Fill(this.dbDataSet.thursday);
            // TODO: This line of code loads data into the 'dbDataSet.wednesday' table. You can move, or remove it, as needed.
            this.wednesdayTableAdapter.Fill(this.dbDataSet.wednesday);
            // TODO: This line of code loads data into the 'dbDataSet.tuesday' table. You can move, or remove it, as needed.
            this.tuesdayTableAdapter.Fill(this.dbDataSet.tuesday);
            // TODO: This line of code loads data into the 'dbDataSet.monday' table. You can move, or remove it, as needed.
            this.mondayTableAdapter.Fill(this.dbDataSet.monday);
            this.customersTableAdapter.Fill(this.dbDataSet.customers);
            this.Text = Application.ProductName;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        
        private void AddCustomerButton_Click(object sender,EventArgs e)
        {
            
        }

        private void ViewCustomerDataButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = viewCustomerDataTab;
        }

        private void ModifyScheduleButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = modifyScheduleTab;
        }

        private void PresenceButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = presenceTab;
        }

        private void SearchCustomerField_click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = String.Empty;
            toolStripTextBox1.ForeColor = Color.FromName("Black");
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void mondayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(mondayDataGridView.SelectedCells);
        }
    }
}
