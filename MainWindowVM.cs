// Decompiled with JetBrains decompiler
// Type: RepasoExamen3.MainWindowVM
// Assembly: RepasoExamen3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF6C6E26-62C7-48F3-84F2-C7241D25B822
// Assembly location: C:\Users\MSI\Desktop\RepasoExamen\Aplicacion\RepasoExamen3.exe

using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace RepasoExamen3
{
  internal class MainWindowVM : ObservableObject
  {
    private ObservableCollection<Componente> lista;
    private Componente seleccionado;
    private Componente visualizado;

    public ObservableCollection<Componente> Lista
    {
      get => this.lista;
      set => this.SetProperty<ObservableCollection<Componente>>(ref this.lista, value, nameof (Lista));
    }

    public Componente Seleccionado
    {
      get => this.seleccionado;
      set => this.SetProperty<Componente>(ref this.seleccionado, value, nameof (Seleccionado));
    }

    public Componente Visualizado
    {
      get => this.visualizado;
      set => this.SetProperty<Componente>(ref this.visualizado, value, nameof (Visualizado));
    }

    public MainWindowVM() => this.Lista = Componente.GetSamples();

    public void Visualizar() => this.Visualizado = this.Seleccionado;
  }
}
