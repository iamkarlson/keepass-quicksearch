using System;
using System.Configuration;
using System.Diagnostics;
using KeePass.Plugins;

namespace QuickSearch.Properties {
    
    
    internal sealed partial class Settings
    {
	    private const string OptionsConfigRoot = "QuickSearchExt.";

	    public void Save(IPluginHost host)
	    {
		    foreach (SettingsPropertyValue property in PropertyValues)
		    {
			    if (property.IsDirty)
			    {
				    var value = property.SerializedValue as String;
				    if (value != null)
				    {
					    host.CustomConfig.SetString(OptionsConfigRoot + property.Name, value);
				    }
				    else
				    {
					    Debug.Fail("Non-string serialized settings property");
				    }
			    }
		    }
	    }

	    public void Load(IPluginHost host)
	    {
		    var ignored = ShowQuickFind; //Access any property just to make it load settings.

			foreach (SettingsPropertyValue property in PropertyValues)
			{
				var value = host.CustomConfig.GetString(OptionsConfigRoot + property.Name);
				if (value != null)
				{
					property.SerializedValue = value;
					property.Deserialized = false;
					property.IsDirty = false;
				}
			}
	    }

	    public override void Save()
	    {
		    System.Diagnostics.Debug.Fail("Use Save(IPluginHost) method instead, to persist to KeePass settings");
	    }
	}
}
