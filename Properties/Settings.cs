// Decompiled with JetBrains decompiler
// Type: RepasoExamen3.Properties.Settings
// Assembly: RepasoExamen3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF6C6E26-62C7-48F3-84F2-C7241D25B822
// Assembly location: C:\Users\MSI\Desktop\RepasoExamen\Aplicacion\RepasoExamen3.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RepasoExamen3.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Componentes")]
    public string titulo
    {
      get => (string) this[nameof (titulo)];
      set => this[nameof (titulo)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("1.0.0")]
    public string version
    {
      get => (string) this[nameof (version)];
      set => this[nameof (version)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Javier Catalá")]
    public string desarrollador
    {
      get => (string) this[nameof (desarrollador)];
      set => this[nameof (desarrollador)] = (object) value;
    }
  }
}
