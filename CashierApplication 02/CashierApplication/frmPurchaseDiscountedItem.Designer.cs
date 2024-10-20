namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            ItemTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TotalAmountLabel = new Label();
            ComputeButton = new Button();
            DiscountTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            PriceTextBox = new TextBox();
            label5 = new Label();
            ChangeLabel = new Label();
            PaymentReceivedTextBox = new TextBox();
            SubmitButton = new Button();
            menuStrip1 = new MenuStrip();
            FileMenuStrip = new ToolStripMenuItem();
            LogoutStripMenuItem = new ToolStripMenuItem();
            ExitApplicationStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemTextBox
            // 
            ItemTextBox.Location = new Point(12, 50);
            ItemTextBox.Name = "ItemTextBox";
            ItemTextBox.Size = new Size(211, 23);
            ItemTextBox.TabIndex = 0;
            ItemTextBox.TextChanged += ItemTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 32);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Discount (%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 87);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(54, 153);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(85, 15);
            TotalAmountLabel.TabIndex = 5;
            TotalAmountLabel.Text = "Total Amount: ";
            TotalAmountLabel.Click += TotalAmountLabel_Click;
            // 
            // ComputeButton
            // 
            ComputeButton.Location = new Point(169, 119);
            ComputeButton.Name = "ComputeButton";
            ComputeButton.Size = new Size(83, 28);
            ComputeButton.TabIndex = 6;
            ComputeButton.Text = "Compute";
            ComputeButton.UseVisualStyleBackColor = true;
            ComputeButton.Click += ComputeButton_Click;
            // 
            // DiscountTextBox
            // 
            DiscountTextBox.Location = new Point(240, 50);
            DiscountTextBox.Name = "DiscountTextBox";
            DiscountTextBox.Size = new Size(140, 23);
            DiscountTextBox.TabIndex = 7;
            DiscountTextBox.TextChanged += DiscountTextBox_TextChanged;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(302, 90);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(78, 23);
            QuantityTextBox.TabIndex = 8;
            QuantityTextBox.TextChanged += QuantityTextBox_TextChanged;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(54, 90);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(169, 23);
            PriceTextBox.TabIndex = 9;
            PriceTextBox.TextChanged += PriceTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 10;
            label5.Text = "Payment received:";
            // 
            // ChangeLabel
            // 
            ChangeLabel.AutoSize = true;
            ChangeLabel.Location = new Point(65, 234);
            ChangeLabel.Name = "ChangeLabel";
            ChangeLabel.Size = new Size(51, 15);
            ChangeLabel.TabIndex = 11;
            ChangeLabel.Text = "Change:";
            ChangeLabel.Click += ChangeLabel_Click;
            // 
            // PaymentReceivedTextBox
            // 
            PaymentReceivedTextBox.Location = new Point(122, 198);
            PaymentReceivedTextBox.Name = "PaymentReceivedTextBox";
            PaymentReceivedTextBox.Size = new Size(130, 23);
            PaymentReceivedTextBox.TabIndex = 12;
            PaymentReceivedTextBox.TextChanged += PaymentReceivedTextBox_TextChanged;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(271, 198);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(109, 23);
            SubmitButton.TabIndex = 13;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileMenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuStrip
            // 
            FileMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { LogoutStripMenuItem, ExitApplicationStripMenuItem });
            FileMenuStrip.Name = "FileMenuStrip";
            FileMenuStrip.Size = new Size(37, 20);
            FileMenuStrip.Text = "File";
            FileMenuStrip.Click += FileMenuStrip_Click;
            // 
            // LogoutStripMenuItem
            // 
            LogoutStripMenuItem.Name = "LogoutStripMenuItem";
            LogoutStripMenuItem.Size = new Size(180, 22);
            LogoutStripMenuItem.Text = "Logout";
            LogoutStripMenuItem.Click += LogoutStripMenuItem_Click;
            // 
            // ExitApplicationStripMenuItem
            // 
            ExitApplicationStripMenuItem.Name = "ExitApplicationStripMenuItem";
            ExitApplicationStripMenuItem.Size = new Size(180, 22);
            ExitApplicationStripMenuItem.Text = "Exit application";
            ExitApplicationStripMenuItem.Click += ExitApplicationStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitButton);
            Controls.Add(PaymentReceivedTextBox);
            Controls.Add(ChangeLabel);
            Controls.Add(label5);
            Controls.Add(PriceTextBox);
            Controls.Add(QuantityTextBox);
            Controls.Add(DiscountTextBox);
            Controls.Add(ComputeButton);
            Controls.Add(TotalAmountLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ItemTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label TotalAmountLabel;
        private Button ComputeButton;
        private TextBox DiscountTextBox;
        private TextBox QuantityTextBox;
        private TextBox PriceTextBox;
        private Label label5;
        private Label ChangeLabel;
        private TextBox PaymentReceivedTextBox;
        private Button SubmitButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenuStrip;
        private ToolStripMenuItem LogoutStripMenuItem;
        private ToolStripMenuItem ExitApplicationStripMenuItem;
    }
}
