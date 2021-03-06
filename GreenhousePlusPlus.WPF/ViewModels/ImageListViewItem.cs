﻿using System.Windows.Media.Imaging;

namespace GreenhousePlusPlusCore.ViewModels
{
  public class ImageListViewItem
  {
    private string _File;
    private string _Title;
    public string Title
    {
      get { return this._Title; }
      set { this._Title = value; }
    }

    public string File
    {
      get { return this._File; }
      set { this._File = value; }
    }

    private BitmapImage _ImageData;
    public BitmapImage ImageData
    {
      get { return this._ImageData; }
      set { this._ImageData = value; }
    }

  }
}
