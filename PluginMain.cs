using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using PluginCore.Localization;
using PluginCore.Utilities;
using PluginCore.Managers;
using PluginCore.Helpers;
using PluginCore;
using CreateGist.Helpers;
using WeifenLuo.WinFormsUI.Docking;

namespace CreateGist
{
    public class PluginMain : IPlugin
    {
        private const int API = 1;
        private const string NAME = "CreateGist";
        private const string GUID = "305F0B3A-B9CF-4040-A866-CC2F30BCE3A3";
        private const string HELP = "www.flashdevelop.org/community/";
        private const string DESCRIPTION = "Adds an option to create a GitHub gist from the open file.";
        private const string AUTHOR = "Joey Robichaud/David Ruttka";

        private string _settingFilename = "";
        private Settings _settings;

        #region Required Properties

        /// <summary>
        /// Api level of the plugin
        /// </summary>
        public Int32 Api
        {
            get { return 1; }
        }

        /// <summary>
        /// Name of the plugin
        /// </summary> 
        public String Name
        {
            get { return NAME; }
        }

        /// <summary>
        /// GUID of the plugin
        /// </summary>
        public String Guid
        {
            get { return GUID; }
        }

        /// <summary>
        /// Author of the plugin
        /// </summary> 
        public String Author
        {
            get { return AUTHOR; }
        }

        /// <summary>
        /// Description of the plugin
        /// </summary> 
        public String Description
        {
            get { return DESCRIPTION; }
        }

        /// <summary>
        /// Web address for help
        /// </summary> 
        public String Help
        {
            get { return HELP; }
        }

        /// <summary>
        /// Object that contains the settings
        /// </summary>
        [Browsable(false)]
        public Object Settings
        {
            get { return this._settings; }
        }

        #endregion

        #region Required Methods

        /// <summary>
        /// Initializes the plugin
        /// </summary>
        public void Initialize()
        {
            this.InitBasics();
            this.LoadSettings();
            this.CreateMenuItems();
            this.AddEventHandlers();
        }

        /// <summary>
        /// Disposes the plugin
        /// </summary>
        public void Dispose()
        {
            this.SaveSettings();
        }

        /// <summary>
        /// Handles the incoming events
        /// </summary>
        public void HandleEvent(Object sender, NotifyEvent e, HandlingPriority prority)
        {
        }

        #endregion

        #region Custom Methods

        /// <summary>
        /// Initializes important variables
        /// </summary>
        public void InitBasics()
        {
            String dataPath = Path.Combine(PathHelper.DataDir, NAME);
            if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);
            this._settingFilename = Path.Combine(dataPath, "Settings.fdb");
        }

        public void CreateMenuItems()
        {
            PluginBase.MainForm.EditorMenu.Items.Add(new ToolStripSeparator());

            var createGist = new ToolStripMenuItem(ResourceHelper.GetString("CreateGist.Label.CreateGist"), ResourceHelper.GetImage("Octocat"), new EventHandler(CreateGist));
            PluginBase.MainForm.RegisterShortcutItem("CreateGist.CreateGist", createGist);
            PluginBase.MainForm.EditorMenu.Items.Add(createGist);
        }

        private void CreateGist(object sender, EventArgs e)
        {
            var createGist = new Controls.CreateGistOptions(_settings);
            createGist.ShowDialog(PluginBase.MainForm);
        }

        /// <summary>
        /// Adds the required event handlers
        /// </summary> 
        public void AddEventHandlers()
        {
            // Set events you want to listen (combine as flags)
            EventManager.AddEventHandler(this, EventType.FileSwitch);
            _settings.OnSettingsChanged += _settings_OnSettingsChanged;
        }

        void _settings_OnSettingsChanged()
        {
        }

        /// <summary>
        /// Loads the plugin settings
        /// </summary>
        public void LoadSettings()
        {
            this._settings = new Settings();
            if (!File.Exists(this._settingFilename)) this.SaveSettings();
            else
            {
                Object obj = ObjectSerializer.Deserialize(this._settingFilename, this._settings);
                this._settings = (Settings)obj;
            }
        }

        /// <summary>
        /// Saves the plugin settings
        /// </summary>
        public void SaveSettings()
        {
            ObjectSerializer.Serialize(this._settingFilename, this._settings);
        }

        #endregion
    }
}