namespace TestTask.Client
{
    partial class LoginForm
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
            panel1 = new Panel();
            button = new Button();
            PasswordTxtBox = new TextBox();
            LoginTxtBox = new TextBox();
            label3 = new Label();
            LoginLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button);
            panel1.Controls.Add(PasswordTxtBox);
            panel1.Controls.Add(LoginTxtBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 208);
            panel1.TabIndex = 0;
            // 
            // button
            // 
            button.AutoSize = true;
            button.BackColor = SystemColors.ControlDark;
            button.FlatStyle = FlatStyle.Flat;
            button.Location = new Point(118, 151);
            button.Name = "button";
            button.Size = new Size(108, 32);
            button.TabIndex = 5;
            button.Text = "LoginButton";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(118, 99);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(188, 23);
            PasswordTxtBox.TabIndex = 4;
            // 
            // LoginTxtBox
            // 
            LoginTxtBox.Location = new Point(118, 58);
            LoginTxtBox.Name = "LoginTxtBox";
            LoginTxtBox.Size = new Size(188, 23);
            LoginTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 102);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "User's Password";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(13, 61);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(71, 15);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "User's Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(140, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 234);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button;
        private TextBox PasswordTxtBox;
        private TextBox LoginTxtBox;
        private Label label3;
        private Label LoginLabel;
    }
}