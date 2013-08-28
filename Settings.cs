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

        private void FireChanged()
        {
            if (OnSettingsChanged != null) OnSettingsChanged();
        }
    }
}
