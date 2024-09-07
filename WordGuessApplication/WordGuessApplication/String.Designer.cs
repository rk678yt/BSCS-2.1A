namespace WordGuessApplication
{
    partial class String
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
            MysteryWord = new Label();
            GuessButton = new Button();
            InputText = new TextBox();
            label1 = new Label();
            WrongGuessesList = new ListBox();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // MysteryWord
            // 
            MysteryWord.BackColor = Color.DarkSeaGreen;
            MysteryWord.FlatStyle = FlatStyle.Flat;
            MysteryWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MysteryWord.ForeColor = Color.White;
            MysteryWord.Location = new Point(12, 9);
            MysteryWord.Name = "MysteryWord";
            MysteryWord.Size = new Size(251, 55);
            MysteryWord.TabIndex = 0;
            MysteryWord.Text = "C??????r";
            MysteryWord.TextAlign = ContentAlignment.MiddleCenter;
            MysteryWord.Click += MysteryWord_Click;
            // 
            // GuessButton
            // 
            GuessButton.BackColor = Color.DarkSeaGreen;
            GuessButton.FlatStyle = FlatStyle.Flat;
            GuessButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GuessButton.ForeColor = Color.White;
            GuessButton.Location = new Point(78, 106);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(121, 29);
            GuessButton.TabIndex = 1;
            GuessButton.Text = "Guess";
            GuessButton.UseVisualStyleBackColor = false;
            GuessButton.Click += GuessButton_Click;
            // 
            // InputText
            // 
            InputText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputText.Location = new Point(50, 67);
            InputText.Name = "InputText";
            InputText.Size = new Size(174, 33);
            InputText.TabIndex = 2;
            InputText.TextAlign = HorizontalAlignment.Center;
            InputText.TextChanged += InputText_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 22);
            label1.TabIndex = 3;
            label1.Text = "Wrong Guess";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WrongGuessesList
            // 
            WrongGuessesList.FormattingEnabled = true;
            WrongGuessesList.ItemHeight = 15;
            WrongGuessesList.Location = new Point(269, 34);
            WrongGuessesList.Name = "WrongGuessesList";
            WrongGuessesList.Size = new Size(143, 169);
            WrongGuessesList.TabIndex = 4;
            WrongGuessesList.SelectedIndexChanged += WrongGuessesList_SelectedIndexChanged;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.DarkSeaGreen;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.ForeColor = SystemColors.ButtonFace;
            ClearButton.Location = new Point(94, 141);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(88, 39);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // String
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 234);
            Controls.Add(ClearButton);
            Controls.Add(WrongGuessesList);
            Controls.Add(label1);
            Controls.Add(InputText);
            Controls.Add(GuessButton);
            Controls.Add(MysteryWord);
            Name = "String";
            Text = "String";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MysteryWord;
        private Button GuessButton;
        private TextBox InputText;
        private Label label1;
        private ListBox WrongGuessesList;
        private Button ClearButton;
    }
}