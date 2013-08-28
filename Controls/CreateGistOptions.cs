using ASCompletion.Context;
using CreateGist.Helpers;
using Newtonsoft.Json;
using PluginCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CreateGist.Controls
{
    public partial class CreateGistOptions : Form
    {
        const string PostGistUri = "https://api.github.com/gists";

        public CreateGistOptions()
        {
            InitializeComponent();
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            this.Text = ResourceHelper.GetString("CreateGist.Title.CreateGist");
            this.descriptionLabel.Text = ResourceHelper.GetString("CreateGist.Label.Description");
            this.isPrivate.Text = ResourceHelper.GetString("CreateGist.Label.Private");
            this.isAnonymous.Text = ResourceHelper.GetString("CreateGist.Label.Anonymous");
            this.shouldOpen.Text = ResourceHelper.GetString("CreateGist.Label.OpenInBrowser");
            this.create.Text = ResourceHelper.GetString("CreateGist.Label.Create");
            this.cancel.Text = ResourceHelper.GetString("CreateGist.Label.Cancel");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_Click(object sender, EventArgs e)
        {
            var fileName = Path.GetFileName(ASContext.Context.CurrentFile);
            var content = ASContext.CurSciControl.SelTextSize <= 0
                ? ASContext.CurSciControl.Text
                : ASContext.CurSciControl.SelText;

            var gist = new Gist
            {
                Description = this.description.Text,
                Public = !this.isPrivate.Checked
            }.AddFile(fileName, content);

            try
            {
                var location = HttpHelper.Post<Gist>(PostGistUri, gist);

                if (this.shouldOpen.Checked)
                {
                    Process.Start(location);
                }

                var format = ResourceHelper.GetString("CreateGist.GistSuccessFormat");
                ASContext.SetStatusText((string.Format(format, location)));
            }
            catch (Exception ex)
            {
                ASContext.SetStatusText(ResourceHelper.GetString("CreateGist.GistErrorString"));
                Debug.WriteLine(ex);
            }

            this.Close();
        }
    }

    internal class Gist
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("files")]
        public Dictionary<string, Dictionary<string, string>> Files { get; set; }

        public Gist AddFile(string name, string content)
        {
            this.Files = this.Files ?? new Dictionary<string, Dictionary<string, string>>();
            this.Files.Add(name, new Dictionary<string, string> { { "content", content } });
            return this;
        }
    }
}
