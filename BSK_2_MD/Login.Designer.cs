namespace BSK_2_MD
{
    partial class Login
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.logInButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createUserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Noto Mono", 30F);
            this.loginBox.Location = new System.Drawing.Point(319, 101);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(402, 66);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Noto Mono", 30F);
            this.passwordBox.Location = new System.Drawing.Point(319, 187);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(402, 66);
            this.passwordBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Depth = 0;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginLabel.Location = new System.Drawing.Point(12, 109);
            this.loginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(57, 24);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(12, 195);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(94, 24);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.AutoSize = true;
            this.logInButton.Depth = 0;
            this.logInButton.Font = new System.Drawing.Font("Noto Mono", 30F);
            this.logInButton.Location = new System.Drawing.Point(22, 335);
            this.logInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInButton.Name = "logInButton";
            this.logInButton.Primary = true;
            this.logInButton.Size = new System.Drawing.Size(265, 68);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "LOG IN";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // createUserButton
            // 
            this.createUserButton.AutoSize = true;
            this.createUserButton.Depth = 0;
            this.createUserButton.Font = new System.Drawing.Font("Noto Mono", 30F);
            this.createUserButton.Location = new System.Drawing.Point(319, 335);
            this.createUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Primary = true;
            this.createUserButton.Size = new System.Drawing.Size(365, 68);
            this.createUserButton.TabIndex = 7;
            this.createUserButton.Text = "CREATE USER";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private MaterialSkin.Controls.MaterialLabel loginLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialRaisedButton logInButton;
        private MaterialSkin.Controls.MaterialRaisedButton createUserButton;
    }
}