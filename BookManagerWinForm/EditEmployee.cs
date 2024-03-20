﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class EditEmployee : Form
    {
        private int empNum;
        private bool isEditor;
        private Edit editForm;
        private DatabaseManager dbManager;
        private int targetEmployeeNumber = 0;
        private readonly string viewName = "view_employees";


        public EditEmployee(int empNum, bool isEditor, Edit editForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.editForm = editForm;
            dbManager = new DatabaseManager();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            editForm.Show();
            this.Close();
        }

        private void buttonEdditEmployee_Click(object sender, EventArgs e)
        {
            int employeeNumber = int.Parse(textBoxEmployeeNumber.Text);
            string employeePassword = textBoxEmployeePassword.Text;
            string firstName = textBoxFirstName.Text;
            bool editor = checkBoxEditor.Checked;
            // 書籍申請を行い、結果を直接条件式で使用
            if (dbManager.EditEmployee(targetEmployeeNumber, employeeNumber, employeePassword, firstName, editor))
            {
                MessageBox.Show("処理が完了しました。");
            }
            else
            {
                MessageBox.Show("未登録の従業員番号です。申請を中止します。");
            }

        }

        #region　編集　従業員情報　表示
        private void buttonTargetDisplay_Click(object sender, EventArgs e)
        {
            int targetEmployeeNumber = int.Parse(textBoxTargetEmployeeNumber.Text);
            // 指定の従業員データを取得する処理
            DataTable data = dbManager.GetRecordDataFromView(viewName, targetEmployeeNumber);
            //int statusNum = (int)Convert.ToInt32(data.Rows[0]["status_num"]);
            textBoxEmployeeNumber.Text = data.Rows[0]["employee_number"].ToString();
            textBoxEmployeePassword.Text = data.Rows[0]["employee_password"].ToString();
            textBoxFirstName.Text = data.Rows[0]["first_name"].ToString();
            checkBoxEditor.Checked = Convert.ToBoolean(data.Rows[0]["editor"]);
        }
        #endregion
    }
}