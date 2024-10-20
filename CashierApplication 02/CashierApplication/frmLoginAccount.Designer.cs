namespace CashierApplication
{
    partial class frmLoginAccount
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
            label1 = new Label();
            label2 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(28, 39);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(201, 23);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(28, 103);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(201, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ActiveCaption;
            LoginButton.Location = new Point(36, 153);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(186, 50);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 243);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "frmLoginAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}