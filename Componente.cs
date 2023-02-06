// Decompiled with JetBrains decompiler
// Type: RepasoExamen3.Componente
// Assembly: RepasoExamen3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF6C6E26-62C7-48F3-84F2-C7241D25B822
// Assembly location: C:\Users\MSI\Desktop\RepasoExamen\Aplicacion\RepasoExamen3.exe

using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace RepasoExamen3
{
  internal class Componente : ObservableObject
  {
    private string nombre;
    private string tipo;
    private string foto;
    private int precio;

    public string Nombre
    {
      get => this.nombre;
      set => this.SetProperty<string>(ref this.nombre, value, nameof (Nombre));
    }

    public string Tipo
    {
      get => this.tipo;
      set => this.SetProperty<string>(ref this.tipo, value, nameof (Tipo));
    }

    internal static ObservableCollection<Componente> GetSamples()
    {
      ObservableCollection<Componente> samples = new ObservableCollection<Componente>();
      samples.Add(new Componente("AMD Ryzen 7 5800X", "Procesador", "AMD_Ryzen_7_5800X.jpg", 452));
      samples.Add(new Componente("Intel Core i7-11700K", "Procesador", "Intel_Core_i7_11700K.jpg", 365));
      samples.Add(new Componente("Gainward 471056224", "Tarjeta", "Gainward_471056224.jpg", 1719));
      samples.Add(new Componente("ASUS ROG Maximus XIII Extreme", "Placa base", "ASUS_ROG_Maximus_XIII_Extreme.jpg", 976));
      samples.Add(new Componente("ASRock X570 Creator", "Placa base", "ASRock_X570_Creator.jpg", 512));
      return samples;
    }

    public string Foto
    {
      get => this.foto;
      set => this.SetProperty<string>(ref this.foto, value, nameof (Foto));
    }

    public Componente(string nombre, string tipo, string foto, int precio)
    {
      this.nombre = nombre;
      this.tipo = tipo;
      this.foto = foto;
      this.precio = precio;
    }

    public int Precio
    {
      get => this.precio;
      set => this.SetProperty<int>(ref this.precio, value, nameof (Precio));
    }
  }
}
