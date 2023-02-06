// Decompiled with JetBrains decompiler
// Type: RepasoExamen3.ImagenConverter
// Assembly: RepasoExamen3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF6C6E26-62C7-48F3-84F2-C7241D25B822
// Assembly location: C:\Users\MSI\Desktop\RepasoExamen\Aplicacion\RepasoExamen3.exe

using System;
using System.Globalization;
using System.Windows.Data;

namespace RepasoExamen3
{
  internal class ImagenConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (object) ("assets\\" + value.ToString());

    public object ConvertBack(
      object value,
      Type targetType,
      object parameter,
      CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
