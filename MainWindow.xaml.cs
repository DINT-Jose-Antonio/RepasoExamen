// Decompiled with JetBrains decompiler
// Type: RepasoExamen3.MainWindow
// Assembly: RepasoExamen3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF6C6E26-62C7-48F3-84F2-C7241D25B822
// Assembly location: C:\Users\MSI\Desktop\RepasoExamen\Aplicacion\RepasoExamen3.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;

namespace RepasoExamen3
{
  public partial class MainWindow : Window, IComponentConnector
  {
    private MainWindowVM vm;
    internal Button ConsultarButton;
    internal TextBlock EuroTextBlock;
    private bool _contentLoaded;

    public MainWindow()
    {
      this.InitializeComponent();
      this.vm = new MainWindowVM();
      this.DataContext = (object) this.vm;
    }

    private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => new Acercade().ShowDialog();

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      this.EuroTextBlock.Visibility = Visibility.Visible;
      this.vm.Visualizar();
    }

    private void Window_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.Key != Key.C || Keyboard.Modifiers != ModifierKeys.Control)
        return;
      this.vm.Visualizar();
    }

    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (((Selector) sender).SelectedItem == null)
        this.ConsultarButton.IsEnabled = false;
      else
        this.ConsultarButton.IsEnabled = true;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/RepasoExamen3;component/mainwindow.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          ((UIElement) target).KeyUp += new KeyEventHandler(this.Window_KeyUp);
          break;
        case 2:
          this.ConsultarButton = (Button) target;
          this.ConsultarButton.Click += new RoutedEventHandler(this.Button_Click);
          break;
        case 3:
          ((Selector) target).SelectionChanged += new SelectionChangedEventHandler(this.ListBox_SelectionChanged);
          break;
        case 4:
          ((UIElement) target).MouseLeftButtonUp += new MouseButtonEventHandler(this.Image_MouseLeftButtonUp);
          break;
        case 5:
          this.EuroTextBlock = (TextBlock) target;
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
