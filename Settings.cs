using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using CreateGist.Localization;

namespace CreateGist
{
    public delegate void SettingsChangesEvent();

    [Serializable]
    public class Settings
    {
        [field: NonSerialized]
        public event SettingsChangesEvent OnSettingsChanged;

        public Settings()
        {
            ShouldOpen = true;
        }

        [Browsable(false)]
        public bool IsPrivate { get; set; }

        [Browsable(false)]
        public bool IsAnonymous { get; set; }

        [Browsable(false)]
        public bool ShouldOpen { get; set; }

        [Browsable(false)]
        public string Login { get; set; }

        private void FireChanged()
        {
            if (OnSettingsChanged != null) OnSettingsChanged();
        }
    }
}
