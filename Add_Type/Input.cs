﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Add_Type
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
            this.KeyPreview = true;
            phonet.Select(); // Установка курсора
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
            if (e.KeyCode == Keys.Enter)
            {
                functionInput();
            }
        }

        private void binput_Click(object sender, EventArgs e)
        {
            functionInput();
        }

        private void functionInput()
        {
            string phone = phonet.Text;
            string password = passwordt.Text;
            Worker inputPerson = Singleton.inputPerson(phone, password);
            if (inputPerson == null)
            {
                var result = MessageBox.Show("Данные для входа введены неверно. Проверьте данные и попробуйте еще раз.", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                this.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
