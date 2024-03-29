﻿namespace BookManagerWinForm
{
    partial class ListDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonBackList = new Button();
            dataGridView1 = new DataGridView();
            comboBoxList = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 16F);
            labelTitle.Location = new Point(21, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(302, 59);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Book Manager";
            // 
            // buttonBackList
            // 
            buttonBackList.Location = new Point(342, 19);
            buttonBackList.Name = "buttonBackList";
            buttonBackList.Size = new Size(212, 60);
            buttonBackList.TabIndex = 3;
            buttonBackList.Text = "back";
            buttonBackList.UseVisualStyleBackColor = true;
            buttonBackList.Click += ButtonBackListDisplay_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(33, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(806, 357);
            dataGridView1.TabIndex = 4;
            // 
            // comboBoxList
            // 
            comboBoxList.FormattingEnabled = true;
            comboBoxList.Items.AddRange(new object[] { "all", "books", "employees", "statuses" });
            comboBoxList.Location = new Point(33, 93);
            comboBoxList.Name = "comboBoxList";
            comboBoxList.Size = new Size(521, 40);
            comboBoxList.TabIndex = 5;
            comboBoxList.Text = "all";
            comboBoxList.SelectedIndexChanged += comboBoxList_SelectedIndexChanged;
            // 
            // ListDisplay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 566);
            Controls.Add(comboBoxList);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBackList);
            Controls.Add(labelTitle);
            Name = "ListDisplay";
            Text = "ListDisplay";
            VisibleChanged += ListDisplay_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonBackList;
        private DataGridView dataGridView1;
        private ComboBox comboBoxList;
    }
}