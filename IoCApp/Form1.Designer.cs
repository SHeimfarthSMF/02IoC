namespace IoCApp
{
    partial class Registration
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
            firstNameTextBox = new TextBox();
            secondNameTextBox = new TextBox();
            registerButton = new Button();
            eMailTextBox = new TextBox();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 12);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "Name";
            firstNameTextBox.Size = new Size(204, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.Location = new Point(12, 41);
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.PlaceholderText = "Second Name";
            secondNameTextBox.Size = new Size(204, 23);
            secondNameTextBox.TabIndex = 1;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(12, 126);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(204, 23);
            registerButton.TabIndex = 2;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // eMailTextBox
            // 
            eMailTextBox.Location = new Point(12, 70);
            eMailTextBox.Name = "eMailTextBox";
            eMailTextBox.PlaceholderText = "Mail";
            eMailTextBox.Size = new Size(204, 23);
            eMailTextBox.TabIndex = 3;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 171);
            Controls.Add(eMailTextBox);
            Controls.Add(registerButton);
            Controls.Add(secondNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox secondNameTextBox;
        private Button registerButton;
        private TextBox eMailTextBox;
    }
}