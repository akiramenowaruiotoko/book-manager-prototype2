﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class RentalManagement : Form
    {
        private readonly int empNum;
        private readonly bool isEditor;
        private readonly string book_id;
        private readonly ListDisplay listDisplayFrom;
        private readonly DatabaseManager dbManager;
        private readonly string viewName = "view_all";

        public RentalManagement(int empNum, bool isEditor, string book_id, ListDisplay listDisplay)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.book_id = book_id;
            this.listDisplayFrom = listDisplay;
            dbManager = new DatabaseManager();
            // 指定した book_id の行データを取得する
            DataTable data = dbManager.GetDataFromRowView(viewName, book_id);
            // 行ヘッダーを非表示にして左の編集列を非表示にする
            dataGridView1.RowHeadersVisible = false;
            // DataGridViewにデータをロード
            dataGridView1.DataSource = data;
        }

        private void ButtonRentalApproval_Click(object sender, EventArgs e)
        {
            // ステータス番号を貸出承認済(5)に設定
            int statusNum = 5;
            // 貸出承認処理を行い、結果を表示
            if (dbManager.RentalManagement(book_id, empNum, statusNum))
            {
                MessageBox.Show("貸出承認処理が完了しました。");
            }
            else
            {
                MessageBox.Show("貸出依頼なし。申請を中止します。");
            }
        }
        private void buttonUnavailableRental_Click(object sender, EventArgs e)
        {
            // ステータス番号を貸出不可(6)に設定
            int statusNum = 6;
            // 貸出不可処理を行い、結果を表示
            if (dbManager.RentalManagement(book_id, empNum, statusNum))
            {
                MessageBox.Show("貸出不可処理が完了しました。");
            }
            else
            {
                MessageBox.Show("貸出依頼なし。申請を中止します。");
            }
        }

        private void buttonCurrentlyRental_Click(object sender, EventArgs e)
        {
            // ステータス番号を貸出中(7)に設定
            int statusNum = 7;
            // 貸出承認処理を行い、結果を表示
            if (dbManager.RentalManagement(book_id, empNum, statusNum))
            {
                MessageBox.Show("貸出処理が完了しました。");
            }
            else
            {
                MessageBox.Show("貸出依頼なし。申請を中止します。");
            }
        }


        private void buttonReturned_Click(object sender, EventArgs e)
        {
            // ステータス番号を貸出可能(3)に設定
            int statusNum = 3;
            // 貸出完了処理を行い、結果を表示
            if (dbManager.RentalManagement(book_id, empNum, statusNum))
            {
                MessageBox.Show("貸出完了認処理が完了しました。");
            }
            else
            {
                MessageBox.Show("貸出依頼なし、または貸出済み。申請を中止します。");
            }
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            listDisplayFrom.Show();
            this.Close();
        }

    }
}
