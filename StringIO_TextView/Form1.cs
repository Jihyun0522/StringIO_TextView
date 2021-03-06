﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form
    {
        private String OrgStr ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(TextCheck())
            {
                this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
            }

        }

        private bool TextCheck()
        {
            if(this.txtEdit.Text != "")
            {
                return true;
            } else
            {
                MessageBox.Show("텍스트를 입력하세요!!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus();

                return false;
            }
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (TextCheck())
                {
                    this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
                    e.Handled = true;
                }
            }
        }
    }
}
