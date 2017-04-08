﻿namespace DigitalLeader.Web.Configuration
{
	using System.Configuration;

	public class CultureElement : ConfigurationElement
	{
		[ConfigurationProperty("Name", IsRequired = true, IsKey = true)]
		public string Name
		{
			get
			{
				return (string)this["Name"];
			}
			set
			{
				this["Name"] = value;
			}
		}

		[ConfigurationProperty("Id", IsRequired = true)]
		public int Id
		{
			get { return (int)this["Id"]; }
			set { this["Id"] = value; }
		}

		[ConfigurationProperty("Default", DefaultValue = false)]
		public bool IsDefault
		{
			get
			{
				return (bool)this["Default"];
			}
			set
			{
				this["Default"] = true;
			}
		}

		[ConfigurationProperty("Translations")]
		public CultureTranslationElementCollection Translations
		{
			get
			{
				return base["Translations"] as CultureTranslationElementCollection;
			}
		}
	}
}