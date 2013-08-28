using CreateGist.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CreateGist.Controls
{
    public partial class GitHubLogin : Form
    {
        const string GitHubSignUpUrl = "https://github.com/signup";

        public string Credentials { get; private set; }

        public GitHubLogin()
        {
            InitializeComponent();
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            this.Text = ResourceHelper.GetString("CreateGist.Title.GitHubLogin");
            this.hostLabel.Text = ResourceHelper.GetString("CreateGist.Label.Host");
            this.loginLabel.Text = ResourceHelper.GetString("CreateGist.Label.Login");
            this.passwordLabel.Text = ResourceHelper.GetString("CreateGist.Label.Password");
            this.doHaveAccount.Text = ResourceHelper.GetString("CreateGist.Label.DoHaveAccount");
            this.signUp.Text = ResourceHelper.GetString("CreateGist.Label.SignUp");
            this.signin.Text = ResourceHelper.GetString("CreateGist.Label.Signin");
            this.cancel.Text = ResourceHelper.GetString("CreateGist.Label.Cancel");
        }

        private void signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(GitHubSignUpUrl);
        }

        private void signin_Click(object sender, EventArgs e)
        {
            var bytes = Encoding.UTF8.GetBytes(this.login.Text + ":" + this.password.Text);
            var testCredentials = Convert.ToBase64String(bytes);
            var basic = "Basic " + testCredentials;

            try
            {
                var apiResponseData = HttpHelper.Get("https://api.github.com/user", basic);
                this.Credentials = testCredentials;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (WebException ex)
            {
                MessageBox.Show("We could not verify those credentials. Try again or create the gist anonymously.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
