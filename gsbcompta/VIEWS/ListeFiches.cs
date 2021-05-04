﻿using gsbcompta.CONTROLLERS;
using gsbcompta.MODELS;
using gsbcompta.VIEWS;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddUser = gsbcompta.VIEWS.AddUser;

namespace gsbcompta
{
    public partial class ListeFiches : Form
    {
        List<Bill> bList;
        BillController bController;
        List<FixedFees> ffList;
        List<OffPrice> opList;
        OffPriceController opController;
        FixedFeesController ffController;
        String userID, month;
        AddUser form;
        Form1 form1;


        public ListeFiches()
        {
            InitializeComponent();
            bController = new BillController();
            opController = new OffPriceController();
            bList = bController.getBills();
            this.dataGridViewBills.DataSource = bList;
            this.dataGridViewBills.Rows[0].Selected = false;           
        }
        /*
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                MessageBox.Show(dgv.CurrentRow.Cells[0].Value.ToString());               
            }
        }*/

        private void dataGridViewBills_SelectionChanged(object sender, EventArgs e)
        {
            majFF();
        }
        private void majFF()
        {

            foreach (DataGridViewRow row in dataGridViewBills.SelectedRows)
            {
                userID = row.Cells[0].Value.ToString();
                month = row.Cells[1].Value.ToString();

                ffController = new FixedFeesController();
                ffList = ffController.getFixedFees(row.Cells[0].Value.ToString(), 
                    row.Cells[1].Value.ToString());
                this.textBoxFixedFeesKM.Text = ffList[0].Quantity.ToString();
                this.textBoxFixedFeesNUI.Text = ffList[1].Quantity.ToString();
                this.textBoxFixedFeesREP.Text = ffList[2].Quantity.ToString();
                opList = opController.getOffPrices(userID, month);
                this.dataGridViewOffPrice.DataSource = opList;

                txtBoxEtat.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dataGridViewOffPrice_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOffPrice.SelectedRows)
            {
                DetailsOffPrice OPForm = new DetailsOffPrice(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString()); ;
                OPForm.Show();
                this.Close();
                
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            form = new AddUser();
            form.Show();
            this.Hide();
        }

        private void btnUpdateEtat_Click(object sender, EventArgs e)
        {
            bController = new BillController();
            String state = this.cbxEtat.Text;
            bController.updateStateBill(userID, month, state);
            bList = bController.getBills();
            this.dataGridViewBills.DataSource = bList;                
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void buttonFixedFeesUpdate_Click(object sender, EventArgs e)
        {
            String KM = this.textBoxFixedFeesKM.Text;
            String NUI = this.textBoxFixedFeesNUI.Text;
            String REP = this.textBoxFixedFeesREP.Text;
            ffController.updateFixedFees(userID, month, KM, "KM");
            ffController.updateFixedFees(userID, month, NUI, "NUI");
            ffController.updateFixedFees(userID, month, REP, "REP");   
        }
    }
}
