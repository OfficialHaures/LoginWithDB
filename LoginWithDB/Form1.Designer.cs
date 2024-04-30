namespace LoginWithDB
{
    partial class Form1
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
            Login_Button = new Button();
            user_label = new Label();
            password_label = new Label();
            user_txt = new TextBox();
            password_txt = new TextBox();
            SuspendLayout();
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(296, 302);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(94, 29);
            Login_Button.TabIndex = 0;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Location = new Point(287, 76);
            user_label.Name = "user_label";
            user_label.Size = new Size(73, 20);
            user_label.TabIndex = 1;
            user_label.Text = "username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(287, 159);
            password_label.Name = "password_label";
            password_label.Size = new Size(72, 20);
            password_label.TabIndex = 2;
            password_label.Text = "password";
            // 
            // user_txt
            // 
            user_txt.Location = new Point(265, 110);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(125, 27);
            user_txt.TabIndex = 3;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(265, 212);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(125, 27);
            password_txt.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(password_txt);
            Controls.Add(user_txt);
            Controls.Add(password_label);
            Controls.Add(user_label);
            Controls.Add(Login_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_Button;
        private Label user_label;
        private Label password_label;
        private TextBox user_txt;
        private TextBox password_txt;
    }
}
