using Mud.Helpers;
using System.Configuration;
namespace Mud.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    public sealed partial class Settings {
        
        public Settings() {
             // To add event handlers for saving and changing settings, uncomment the lines below:
            
             this.SettingChanging += this.SettingChangingEventHandler;
            
             this.SettingsSaving += this.SettingsSavingEventHandler;
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            Logging.Write(LogLevel.DANGER, "Setting Changed [{0}] -> {1}", e.SettingName, e.NewValue);
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Logging.Write(LogLevel.DANGER, "Settings Saved!");
            foreach (SettingsProperty p in Settings.Default.Properties)
            {
                Logging.Write(LogLevel.DANGER, "[{0}] -> {1}", p.Name, p.DefaultValue.ToString());
            }
        }
    }
}
