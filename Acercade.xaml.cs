// Decompiled with JetBrains decompiler
// Type: RepasoExamen3.Acercade
// Assembly: RepasoExamen3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF6C6E26-62C7-48F3-84F2-C7241D25B822
// Assembly location: C:\Users\MSI\Desktop\RepasoExamen\Aplicacion\RepasoExamen3.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace RepasoExamen3
{
  public partial class Acercade : Window, IComponentConnector
  {
    private bool _contentLoaded;

    public Acercade() => this.InitializeComponent();

    private void Button_Click(object sender, RoutedEventArgs e) => this.DialogResult = new bool?(true);

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/RepasoExamen3;component/acercade.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      if (connectionId == 1)
        ((ButtonBase) target).Click += new RoutedEventHandler(this.Button_Click);
      else
        this._contentLoaded = true;
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
