namespace CreateGist.Controls
{
    partial class GitHubLogin
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
            this.hostLabel = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.doHaveAccount = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.LinkLabel();
            this.signin = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(13, 13);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(32, 13);
            this.hostLabel.TabIndex = 0;
            this.hostLabel.Text = "Host:";
            // 
            // host
            // 
            this.host.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.host.Enabled = false;
            this.host.Location = new System.Drawing.Point(75, 12);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(162, 20);
            this.host.TabIndex = 1;
            this.host.Text = "github.com";
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Location = new System.Drawing.Point(75, 36);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(162, 20);
            this.login.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(13, 39);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(36, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Location = new System.Drawing.Point(75, 62);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(162, 20);
            this.password.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(13, 65);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // doHaveAccount
            // 
            this.doHaveAccount.AutoSize = true;
            this.doHaveAccount.Location = new System.Drawing.Point(12, 90);
            this.doHaveAccount.Name = "doHaveAccount";
            this.doHaveAccount.Size = new System.Drawing.Size(182, 13);
            this.doHaveAccount.TabIndex = 6;
            this.doHaveAccount.Text = "Do you have an account on GitHub?";
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Location = new System.Drawing.Point(191, 90);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(46, 13);
            this.signUp.TabIndex = 7;
            this.signUp.TabStop = true;
            this.signUp.Text = "Sign up.";
            this.signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUp_LinkClicked);
            // 
            // signin
            // 
            this.signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.signin.Location = new System.Drawing.Point(81, 110);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 23);
            this.signin.TabIndex = 8;
            this.signin.Text = "Sign in";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(162, 110);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // GitHubLogin
            // 
            this.AcceptButton = this.signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(252, 146);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.doHaveAccount);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.host);
            this.Controls.Add(this.hostLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GitHubLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in to GitHub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label doHaveAccount;
        private System.Windows.Forms.LinkLabel signUp;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button cancel;
    }
}