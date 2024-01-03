using System.ComponentModel;

namespace TestTask.Client
{
    partial class CRUDForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            label1 = new Label();
            CreateButton = new Button();
            LatTxtBox = new TextBox();
            FirstNameTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            IdTxtBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            GetAllButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            ReadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(33, 62);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(432, 376);
            dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(185, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 35);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // CreateButton
            // 
            CreateButton.BackColor = SystemColors.ControlDark;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Location = new Point(9, 185);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(113, 35);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // LatTxtBox
            // 
            LatTxtBox.Location = new Point(112, 129);
            LatTxtBox.Name = "LatTxtBox";
            LatTxtBox.Size = new Size(161, 23);
            LatTxtBox.TabIndex = 3;
            // 
            // FirstNameTxtBox
            // 
            FirstNameTxtBox.Location = new Point(112, 92);
            FirstNameTxtBox.Name = "FirstNameTxtBox";
            FirstNameTxtBox.Size = new Size(161, 23);
            FirstNameTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(9, 137);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(IdTxtBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(FirstNameTxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(GetAllButton);
            panel1.Controls.Add(LatTxtBox);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(ReadButton);
            panel1.Controls.Add(CreateButton);
            panel1.Location = new Point(482, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 376);
            panel1.TabIndex = 7;
            // 
            // IdTxtBox
            // 
            IdTxtBox.Location = new Point(112, 57);
            IdTxtBox.Name = "IdTxtBox";
            IdTxtBox.Size = new Size(161, 23);
            IdTxtBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 65);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Student's Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 20);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Input Data";
            // 
            // GetAllButton
            // 
            GetAllButton.BackColor = SystemColors.ControlDark;
            GetAllButton.FlatStyle = FlatStyle.Flat;
            GetAllButton.Location = new Point(9, 313);
            GetAllButton.Name = "GetAllButton";
            GetAllButton.Size = new Size(264, 35);
            GetAllButton.TabIndex = 6;
            GetAllButton.Text = "Get All Students";
            GetAllButton.UseVisualStyleBackColor = false;
            GetAllButton.Click += GetAllButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.ControlDark;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(160, 247);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(113, 35);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.ControlDark;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Location = new Point(9, 247);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(113, 35);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.BackColor = SystemColors.ControlDark;
            ReadButton.FlatStyle = FlatStyle.Flat;
            ReadButton.Location = new Point(160, 185);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(113, 35);
            ReadButton.TabIndex = 3;
            ReadButton.Text = "Read";
            ReadButton.UseVisualStyleBackColor = false;
            ReadButton.Click += ReadButton_Click;
            // 
            // CRUDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CRUDForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForms Client";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Button CreateButton;
        private TextBox LatTxtBox;
        private TextBox FirstNameTxtBox;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button ReadButton;
        private Button GetAllButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Label label4;
        private TextBox IdTxtBox;
        private Label label5;
    }
}
