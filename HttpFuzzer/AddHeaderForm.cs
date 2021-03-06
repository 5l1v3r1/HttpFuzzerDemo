﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoveCoody
{
    public partial class AddHeaderForm : Form
    {
        AddExpForm parentForm = null;
        MainForm coodyMain = null;
        int modifyIndex;

        public AddHeaderForm(AddExpForm parentForm, String fieldName, String fieldValue, Int32 modifyIndex)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.modifyIndex = modifyIndex;
            if (String.IsNullOrEmpty(fieldName) || String.IsNullOrEmpty(fieldValue))
            {
                return;
            }
            this.HeadNameTextBox.Text = fieldName;
            this.HeadValueTextBox.Text = fieldValue;

        }

        public AddHeaderForm(MainForm parentForm, String fieldName, String fieldValue, Int32 modifyIndex)
        {
            InitializeComponent();
            this.coodyMain = parentForm;
            this.modifyIndex = modifyIndex;
            if (String.IsNullOrEmpty(fieldName) || String.IsNullOrEmpty(fieldValue))
            {
                return;
            }
            this.HeadNameTextBox.Text = fieldName;
            this.HeadValueTextBox.Text = fieldValue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddHeaderForm_Load(object sender, EventArgs e)
        {
            this.Icon = MainForm.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(HeadNameTextBox.Text) || String.IsNullOrEmpty(HeadValueTextBox.Text))
            {
                MessageBox.Show("输入内容有误");
                return;
            }
            parentForm.addOrModifyHeader(HeadNameTextBox.Text, HeadValueTextBox.Text, modifyIndex);
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(HeadNameTextBox.Text) || String.IsNullOrEmpty(HeadValueTextBox.Text))
            {
                MessageBox.Show("输入内容有误");
                return;
            }
            if(parentForm!=null){
                parentForm.addOrModifyHeader(HeadNameTextBox.Text, HeadValueTextBox.Text, modifyIndex);
            }
           if(coodyMain!=null){
               coodyMain.addOrModifyHeader(HeadNameTextBox.Text, HeadValueTextBox.Text, modifyIndex);
           }
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
