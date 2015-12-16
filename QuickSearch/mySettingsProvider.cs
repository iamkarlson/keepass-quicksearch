using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;


namespace QuickSearch
{
    class mySettingsProvider : SettingsProvider
    {
        public override string ApplicationName
        {
            get
            {
                return "QuickSearchExt";
            }
            set
            {

            }
        }

        private bool PreferUserConfiguration
        {
            get { return KeePass.Program.Config.Meta.PreferUserConfiguration; }

        }

        public override System.Configuration.SettingsPropertyValueCollection GetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection collection)
        {
            Dictionary<String, Object> dictionary;
            System.Collections.Generic.KeyValuePair<String, Object>[] pairs = new System.Collections.Generic.KeyValuePair<string, object>[collection.Count];

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GetPluginConfigFilePath(), FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            //pairs = (System.Collections.Generic.KeyValuePair<String, Object>[])formatter.Deserialize(stream);
            try
            {
                dictionary = (Dictionary<String, Object>)formatter.Deserialize(stream);
            }
            catch (SerializationException)
            {
                dictionary = new Dictionary<string, object>(0);

            }

            stream.Close();

            //foreach (KeyValuePair<String, Object> pair in pairs)
            //{
            //    collection.

            //}



            SettingsPropertyValueCollection propertyValueCollection = new SettingsPropertyValueCollection();
            foreach (SettingsProperty setting in collection)
            {
                SettingsPropertyValue propertyValue = new SettingsPropertyValue(setting);
                Object value;

                if (dictionary.TryGetValue(setting.Name, out value))
                {
                    propertyValue.PropertyValue = value;
                }
                //else propertyValue.PropertyValue = setting.DefaultValue;
                propertyValueCollection.Add(propertyValue);

            }
            //    value.IsDirty = true;
            //    value.Property.SerializeAs = SettingsSerializeAs.String;
            //object o =value.SerializedValue;

            //try
            //{
            //    //file settingsPropertyValue with data from the temporary settings storage read in LoadValueFromSqlCeDatabase()
            //    value.SerializedValue = sqldata[setting.Name];
            //    value.PropertyValue = sqldata[setting.Name];

            //}
            //catch (Exception ex)
            //{
            //    //Setting not yet available in database. 
            //    //Default value will be used and saved to db next time we call Setpropertyvalues
            //    Debug.WriteLine("Key not found. " + value.Name + "\n" + ex);
            //}
            //    coll.Add(value);
            //}
            return propertyValueCollection;
        }

        public override void SetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyValueCollection collection)
        {



            //collection.
            //DictionaryEntry[] arr = new DictionaryEntry[context.Count];
            //context.CopyTo(arr, 0);
            //String[] arr = new string[]{"uiae", "iaeoiaeo"};


            Dictionary<String, Object> dictionary = new Dictionary<string, object>(collection.Count);
            KeyValuePair<String, Object>[] pairs = new KeyValuePair<string, object>[collection.Count];
            //pairs[0] = new KeyValuePair<String, Object>("testkey", "testvalue");
            int index = 0;
            foreach (SettingsPropertyValue spv in collection)
            {
                dictionary.Add(spv.Name, spv.PropertyValue);
                KeyValuePair<String, Object> pair = new KeyValuePair<string, object>(spv.Name, spv.PropertyValue);
                pairs[index] = pair;
                index++;
                //System.Windows.Forms.MessageBox.Show(spv.SerializedValue.ToString());
                //object o = spv.SerializedValue;
            }

            //{
            //    KeyValuePair<String, Object> pair = new KeyValuePair<string,object>(collection.GetEnumeratorGetEnumerator().
            //}
            //foreach (SettingsPropertyValue spv in collection)
            //{
            //    context.
            //    spv.
            //    //System.Windows.Forms.MessageBox.Show(spv.SerializedValue.ToString());
            //    object o = spv.SerializedValue;

            //System.Xml.Serialization.XmlSerializer xmlser = new System.Xml.Serialization.XmlSerializer(pairs.GetType());
            //System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create("d:/temp/zu l/kptest/myset.conf");
            //xmlser.Serialize(writer, pairs);
            Stream stream = new FileStream(GetPluginConfigFilePath(), FileMode.Create, FileAccess.Write, FileShare.None);

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, dictionary);
            stream.Close();


        }
        // must be here otherwise GetPropertyValues won't be called
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
        {
            base.Initialize(this.ApplicationName, config);
        }

        //string GetConfigFilePath()
        //{
        //    return KeePass.App.Configuration.AppConfigSerializer.AppDataDirectory + "/QuickSearch.config";


        //}

        String GetPluginConfigFilePath()
        {
            string basePath;
            if (this.PreferUserConfiguration)
            {
                basePath = KeePass.App.Configuration.AppConfigSerializer.AppDataDirectory + Path.DirectorySeparatorChar;
            }
            else
            {
                string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

                basePath = assemblyPath.Substring(0, assemblyPath.LastIndexOf(Path.DirectorySeparatorChar) + 1);





            }
            return basePath + "QuickSearch.config";

        }
    }
}
