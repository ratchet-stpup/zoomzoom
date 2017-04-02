﻿// Decompiled with JetBrains decompiler
// Type: ZoomZoom.Models.Data.IDatabaseObject
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using System.Collections.Generic;
using System.Data.SQLite;

namespace ZoomZoom.Models.Data
{
  internal interface IDatabaseObject
  {
    ObjectDataTable GetTableName();

    Dictionary<string, object> GetDataDictionary();

    bool SaveDatabaseObject();

    bool DeleteDatabaseObject();

    object LoadDatabaseObject(SQLiteDataReader cReader);
  }
}
