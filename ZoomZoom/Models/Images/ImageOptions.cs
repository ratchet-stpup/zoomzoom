﻿// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Images.ImageOptions
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using ZoomZoom.Models.Core;

namespace ZoomZoom.Models.Images
{
  internal class ImageOptions : CoreOptions
  {
    public bool DisplayAfterCapture { get; set; }

    public bool SaveToDisk { get; set; }

    public bool DisplayHighlightWindow { get; set; }
  }
}
