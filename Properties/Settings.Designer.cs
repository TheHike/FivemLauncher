using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VRRP_Launcher.Properties
{
	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000024CC File Offset: 0x000006CC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000024E4 File Offset: 0x000006E4
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002506 File Offset: 0x00000706
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Identificador Steam")]
		public string steam
		{
			get
			{
				return (string)this["steam"];
			}
			set
			{
				this["steam"] = value;
			}
		}

		// Token: 0x04000008 RID: 8
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
