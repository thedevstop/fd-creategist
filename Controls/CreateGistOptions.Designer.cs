namespace CreateGist.Controls
{
    partial class CreateGistOptions
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.isPrivate = new System.Windows.Forms.CheckBox();
            this.isAnonymous = new System.Windows.Forms.CheckBox();
            this.shouldOpen = new System.Windows.Forms.CheckBox();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.Location = new System.Drawing.Point(13, 30);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(261, 101);
            this.description.TabIndex = 1;
            // 
            // isPrivate
            // 
            this.isPrivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.isPrivate.AutoSize = true;
            this.isPrivate.Location = new System.Drawing.Point(16, 138);
            this.isPrivate.Name = "isPrivate";
            this.isPrivate.Size = new System.Drawing.Size(59, 17);
            this.isPrivate.TabIndex = 2;
            this.isPrivate.Text = "Private";
            this.isPrivate.UseVisualStyleBackColor = true;
            // 
            // isAnonymous
            // 
            this.isAnonymous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.isAnonymous.AutoSize = true;
            this.isAnonymous.Checked = true;
            this.isAnonymous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isAnonymous.Enabled = false;
            this.isAnonymous.Location = new System.Drawing.Point(82, 138);
            this.isAnonymous.Name = "isAnonymous";
            this.isAnonymous.Size = new System.Drawing.Size(81, 17);
            this.isAnonymous.TabIndex = 3;
            this.isAnonymous.Text = "Anonymous";
            this.isAnonymous.UseVisualStyleBackColor = true;
            // 
            // shouldOpen
            // 
            this.shouldOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shouldOpen.AutoSize = true;
            this.shouldOpen.Checked = true;
            this.shouldOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shouldOpen.Location = new System.Drawing.Point(170, 138);
            this.shouldOpen.Name = "shouldOpen";
            this.shouldOpen.Size = new System.Drawing.Size(104, 17);
            this.shouldOpen.TabIndex = 4;
            this.shouldOpen.Text = "Open in Browser";
            this.shouldOpen.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create.Location = new System.Drawing.Point(118, 161);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 5;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(199, 161);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CreateGistOptions
            // 
            this.AcceptButton = this.create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.shouldOpen);
            this.Controls.Add(this.isAnonymous);
            this.Controls.Add(this.isPrivate);
            this.Controls.Add(this.description);
            this.Controls.Add(this.descriptionLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 230);
            this.Name = "CreateGistOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Gist";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.CheckBox isPrivate;
        private System.Windows.Forms.CheckBox isAnonymous;
        private System.Windows.Forms.CheckBox shouldOpen;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
    }
}