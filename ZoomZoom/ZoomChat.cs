﻿// Decompiled with JetBrains decompiler
// Type: ZoomZoom.ZoomChat
// Assembly: ZoomZoom, Version=3.1.2.133, Culture=neutral, PublicKeyToken=null
// MVID: ABEAA923-4AD5-42AE-8951-938AC0FA3F1E
// Assembly location: \\storage-n01.thelaughingman.local\stuff\jaime_temp_DONT_dELETE\jnc8651\ZoomZoom.exe

using log4net;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using System.Xml.Serialization;
using ZoomZoom.Models.Data;

namespace ZoomZoom
{
  [DesignerCategory("code")]
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [XmlType(AnonymousType = true)]
  [Serializable]
  public class ZoomChat : DataObject
  {
    private int chatType = 0;
    private long meetingUri = 0;
    private long sendingUserUri = 0;
    private long receivingUserUri = 0;
    private string sendingZoomId = string.Empty;
    private string receivingZoomId = string.Empty;
    private string chatContent = string.Empty;
    private DateTime dateCreated = DateTime.MinValue;
    private DateTime dateModified = DateTime.MinValue;
    private bool wasBlocked = false;
    private bool wasPublic = false;
    private string userAliases = string.Empty;
    private string currentName = string.Empty;
    private bool autoGenerated = false;

    [XmlAttribute]
    public int ChatType
    {
      get
      {
label_1:
        int num1 = 278471071;
        int chatType;
        while (true)
        {
          int num2 = 921464916;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 2:
              num1 = (int) num3 * 797964813 ^ -774785877;
              continue;
            case 3:
              chatType = this.chatType;
              num1 = (int) num3 * 435742886 ^ 1316912060;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return chatType;
      }
      set
      {
        this.chatType = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3192548223U));
      }
    }

    [XmlElement]
    public long MeetingUri
    {
      get
      {
label_1:
        int num1 = 234290988;
        long meetingUri;
        while (true)
        {
          int num2 = 103608641;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              meetingUri = this.meetingUri;
              num1 = (int) num3 * -2058321899 ^ 1341800131;
              continue;
            case 2:
              goto label_1;
            case 3:
              num1 = (int) num3 * 2136114253 ^ 1050157902;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return meetingUri;
      }
      set
      {
        this.meetingUri = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2186517594U));
      }
    }

    [XmlElement]
    public long SendingUserUri
    {
      get
      {
label_1:
        int num1 = 1601443386;
        long sendingUserUri;
        while (true)
        {
          int num2 = 809183883;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              sendingUserUri = this.sendingUserUri;
              num1 = (int) num3 * 1896711872 ^ 244136154;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return sendingUserUri;
      }
      set
      {
        this.sendingUserUri = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3772887663U));
      }
    }

    [XmlElement]
    public long ReceivingUserUri
    {
      get
      {
label_1:
        int num1 = -152952990;
        long receivingUserUri;
        while (true)
        {
          int num2 = -2121624041;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              receivingUserUri = this.receivingUserUri;
              num1 = (int) num3 * 615527702 ^ 46503627;
              continue;
            case 2:
              num1 = (int) num3 * 653266987 ^ -2062056218;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return receivingUserUri;
      }
      set
      {
label_1:
        int num1 = -397667;
        while (true)
        {
          int num2 = -1300661983;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              this.receivingUserUri = value;
              num1 = (int) num3 * -1574786558 ^ -660581594;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(870485338U));
      }
    }

    [XmlElement]
    public string SendingZoomId
    {
      get
      {
label_1:
        int num1 = 799401010;
        string sendingZoomId;
        while (true)
        {
          int num2 = 1606571407;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              sendingZoomId = this.sendingZoomId;
              num1 = (int) num3 * 748469371 ^ -1096903381;
              continue;
            case 3:
              num1 = (int) num3 * 745909855 ^ -818445112;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return sendingZoomId;
      }
      set
      {
label_1:
        int num1 = -467581671;
        while (true)
        {
          int num2 = -505056746;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3847333149U));
              num1 = (int) num3 * -145084108 ^ -1541135789;
              continue;
            case 1:
              goto label_3;
            case 2:
              goto label_1;
            case 3:
              this.sendingZoomId = value;
              num1 = (int) num3 * -1083301950 ^ 996863792;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    [XmlElement]
    public string ReceivingZoomId
    {
      get
      {
label_1:
        int num1 = -832758134;
        string receivingZoomId;
        while (true)
        {
          int num2 = -1903456447;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              receivingZoomId = this.receivingZoomId;
              num1 = (int) num3 * -509283069 ^ 1397897255;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return receivingZoomId;
      }
      set
      {
label_1:
        int num1 = 1886211532;
        while (true)
        {
          int num2 = 167782741;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(706273256U));
              num1 = (int) num3 * 1907886023 ^ -2067317897;
              continue;
            case 3:
              num1 = (int) num3 * -1151014727 ^ -1475084724;
              continue;
            case 4:
              this.receivingZoomId = value;
              num1 = (int) num3 * -26143345 ^ -260415388;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    [XmlElement]
    public string ChatContent
    {
      get
      {
        return this.chatContent;
      }
      set
      {
label_1:
        int num1 = 372333852;
        while (true)
        {
          int num2 = 493922109;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.chatContent = value;
              num1 = (int) num3 * -326279916 ^ 975422431;
              continue;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1619364921U));
              num1 = (int) num3 * -846711752 ^ 1344103925;
              continue;
            case 3:
              goto label_1;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    [XmlElement]
    public DateTime DateCreated
    {
      get
      {
label_1:
        int num1 = 1828786490;
        DateTime dateCreated;
        while (true)
        {
          int num2 = 295543404;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 6531465 ^ 1945269822;
              continue;
            case 2:
              dateCreated = this.dateCreated;
              num1 = (int) num3 * 2024324712 ^ -1051750315;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return dateCreated;
      }
      set
      {
        this.dateCreated = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(327274448U));
      }
    }

    [XmlAttribute]
    public DateTime DateModified
    {
      get
      {
        DateTime dateModified = this.dateModified;
label_1:
        int num1 = 446235994;
        while (true)
        {
          int num2 = 1015213887;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * -1267012025 ^ 1541504831;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return dateModified;
      }
      set
      {
label_1:
        int num1 = 13369832;
        while (true)
        {
          int num2 = 342099667;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 5U)
          {
            case 0:
              goto label_1;
            case 1:
              goto label_3;
            case 2:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3096187508U));
              num1 = (int) num3 * 1728257581 ^ -261880925;
              continue;
            case 3:
              num1 = (int) num3 * 563075971 ^ -705130300;
              continue;
            case 4:
              this.dateModified = value;
              num1 = (int) num3 * 948321168 ^ 325632984;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        return;
label_3:;
      }
    }

    [XmlElement]
    public bool WasBlocked
    {
      get
      {
label_1:
        int num1 = 357965187;
        bool wasBlocked;
        while (true)
        {
          int num2 = 955192660;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              num1 = (int) num3 * -1531427400 ^ -1576012587;
              continue;
            case 2:
              goto label_1;
            case 3:
              wasBlocked = this.wasBlocked;
              num1 = (int) num3 * 1895092928 ^ -382325716;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return wasBlocked;
      }
      set
      {
        this.wasBlocked = value;
        this.RaisePropertyChanged(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3995853831U));
      }
    }

    [XmlElement]
    public bool WasPublic
    {
      get
      {
label_1:
        int num1 = 874519243;
        bool wasPublic;
        while (true)
        {
          int num2 = 1578776528;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              wasPublic = this.wasPublic;
              num1 = (int) num3 * 1974919330 ^ -376834849;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return wasPublic;
      }
      set
      {
        this.wasPublic = value;
label_1:
        int num1 = 362891165;
        while (true)
        {
          int num2 = 169170823;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_3;
            case 1:
              this.RaisePropertyChanged(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3853809435U));
              num1 = (int) num3 * 985097660 ^ -293995665;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_5;
          }
        }
label_5:
        return;
label_3:;
      }
    }

    [XmlElement("aliases", Form = XmlSchemaForm.Unqualified)]
    [Browsable(false)]
    public List<string> Aliases
    {
      get
      {
label_1:
        int num1 = 205149722;
        List<string> list;
        while (true)
        {
          int num2 = 1245384496;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 1:
              list = ((IEnumerable<string>) ZoomChat.\u202B‭⁫⁮‏‍‍‭‫‪⁪‌‫‪‮⁬‍‏‪⁬‎⁬⁬‎‭‏‏‮‪⁫‭‮⁯‌‬‭‮‏‬‫‮(this.userAliases, new char[1]
              {
                ';'
              })).ToList<string>();
              num1 = (int) num3 * -591965584 ^ -636303538;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return list;
      }
      set
      {
label_1:
        int num1 = -94256149;
        while (true)
        {
          int num2 = -1775816110;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_3;
            case 1:
              this.userAliases = ZoomChat.\u202A​⁪‮⁫‏‫⁮‭‪‬⁪⁮‪⁯⁪‏⁯‍⁫‎⁭‪⁪‎‬‏‏​‌‍⁬‍‍‭⁪⁫⁮⁬‍‮(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1257467541U), (IEnumerable<string>) value);
              num1 = (int) num3 * 974829652 ^ 604179577;
              continue;
            case 2:
              goto label_1;
            case 3:
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1366036755U));
              num1 = (int) num3 * 44899622 ^ 844666956;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public string CurrentName
    {
      get
      {
label_1:
        int num1 = -1317960124;
        string currentName;
        while (true)
        {
          int num2 = -1293255365;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              num1 = (int) num3 * 130844526 ^ 913116047;
              continue;
            case 3:
              currentName = this.currentName;
              num1 = (int) num3 * -199177776 ^ 969434922;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return currentName;
      }
      set
      {
label_1:
        int num1 = -296789436;
        while (true)
        {
          int num2 = -1781710395;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              this.RaisePropertyChanged(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(873414413U));
              num1 = (int) num3 * 13842778 ^ 1711990666;
              continue;
            case 1:
              this.currentName = value;
              num1 = (int) num3 * 1403676460 ^ 1152467877;
              continue;
            case 2:
              goto label_1;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public bool MessageSent
    {
      get
      {
label_1:
        int num1 = 621678243;
        bool flag;
        while (true)
        {
          int num2 = 573726800;
          uint num3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 8U)
          {
            case 0:
              flag = false;
              num1 = 823143321;
              continue;
            case 1:
              num1 = (int) num3 * 364260017 ^ 1113839067;
              continue;
            case 3:
              if (!ZoomChat.\u202E⁯⁫‎‮‪⁫‫⁬‎‎⁪‏‪⁭‭‬‌‫‫‬‌‮‏‌‫‬⁬⁬‭‭‌‮⁬⁬‎⁮⁪‏‪‮(this.CurrentName, string.Empty))
              {
                num1 = (int) num3 * -930111305 ^ -1611441767;
                continue;
              }
              num4 = 0;
              break;
            case 4:
              num4 = ZoomChat.\u202E⁯⁫‎‮‪⁫‫⁬‎‎⁪‏‪⁭‭‬‌‫‫‬‌‮‏‌‫‬⁬⁬‭‭‌‮⁬⁬‎⁮⁪‏‪‮(this.CurrentName, this.SendingZoomId) ? 1 : 0;
              break;
            case 5:
              goto label_1;
            case 6:
              num1 = (int) num3 * -906908095 ^ -781308863;
              continue;
            case 7:
              flag = true;
              num1 = (int) num3 * -1281242693 ^ 2125697199;
              continue;
            default:
              goto label_12;
          }
          int num5;
          num1 = num5 = num4 == 0 ? 1270963256 : (num5 = 1396703894);
        }
label_12:
        return flag;
      }
    }

    public bool MessageReceived
    {
      get
      {
label_1:
        int num1 = -230051236;
        bool flag1;
        while (true)
        {
          int num2 = -992855477;
          uint num3;
          bool flag2;
          switch ((num3 = (uint) (num1 ^ num2)) % 9U)
          {
            case 0:
              num1 = -1513156335;
              continue;
            case 2:
              num1 = (int) num3 * 1436947507 ^ 29275764;
              continue;
            case 3:
              int num4 = !flag2 ? 1447027266 : (num4 = 1636770811);
              int num5 = (int) num3 * -1563899489;
              num1 = num4 ^ num5;
              continue;
            case 4:
              flag1 = false;
              num1 = (int) num3 * -1998517329 ^ 1087079745;
              continue;
            case 5:
              flag2 = !ZoomChat.\u202E⁯⁫‎‮‪⁫‫⁬‎‎⁪‏‪⁭‭‬‌‫‫‬‌‮‏‌‫‬⁬⁬‭‭‌‮⁬⁬‎⁮⁪‏‪‮(this.CurrentName, this.SendingZoomId);
              num1 = (int) num3 * -37320499 ^ -1830724557;
              continue;
            case 6:
              flag1 = true;
              num1 = (int) num3 * 2990877 ^ -1694034459;
              continue;
            case 7:
              goto label_1;
            case 8:
              num1 = (int) num3 * 60437762 ^ -1141008789;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        return flag1;
      }
    }

    public string SendingUserId { get; internal set; }

    public string ReceivingUserId { get; internal set; }

    public bool WasRecipient
    {
      get
      {
label_1:
        int num1 = 1283416075;
        bool flag;
        while (true)
        {
          int num2 = 713776696;
          uint num3;
          int num4;
          switch ((num3 = (uint) (num1 ^ num2)) % 6U)
          {
            case 0:
              goto label_1;
            case 2:
              if (!ZoomChat.\u206D‬‮⁫‪⁯‫‪⁯⁭‎⁭‪‍‪‪‮‍‭⁭‌⁬‭‬⁪‏‫⁮‍‍‬‏‏⁯‮⁪‏‏⁯⁮‮(this.CurrentName))
              {
                num1 = (int) num3 * -480043100 ^ -1300192565;
                continue;
              }
              break;
            case 3:
              if (!ZoomChat.\u206D‬‮⁫‪⁯‫‪⁯⁭‎⁭‪‍‪‪‮‍‭⁭‌⁬‭‬⁪‏‫⁮‍‍‬‏‏⁯‮⁪‏‏⁯⁮‮(this.ReceivingZoomId))
              {
                num1 = (int) num3 * -1869885354 ^ 1282123130;
                continue;
              }
              break;
            case 4:
              num1 = (int) num3 * -1508225161 ^ 780264833;
              continue;
            case 5:
              num4 = ZoomChat.\u202E⁯⁫‎‮‪⁫‫⁬‎‎⁪‏‪⁭‭‬‌‫‫‬‌‮‏‌‫‬⁬⁬‭‭‌‮⁬⁬‎⁮⁪‏‪‮(this.ReceivingZoomId, this.CurrentName) ? 1 : 0;
              goto label_5;
            default:
              goto label_11;
          }
          num4 = 0;
label_5:
          flag = num4 != 0;
          num1 = 1025344490;
        }
label_11:
        return flag;
      }
    }

    public override ObjectDataTable ZoomZoomTable
    {
      get
      {
label_1:
        int num1 = 1367684426;
        ObjectDataTable objectDataTable;
        while (true)
        {
          int num2 = 381809406;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 0:
              goto label_1;
            case 2:
              objectDataTable = ObjectDataTable.Chats;
              num1 = (int) num3 * -205846793 ^ 2105903129;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return objectDataTable;
      }
    }

    public override TraceType TraceType
    {
      get
      {
        TraceType traceType = TraceType.Chat;
label_1:
        int num1 = 2077187831;
        while (true)
        {
          int num2 = 297284213;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              num1 = (int) num3 * 1629308714 ^ 229065085;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return traceType;
      }
    }

    public bool AutoGenerated1
    {
      get
      {
label_1:
        int num1 = -1500741804;
        bool autoGenerated;
        while (true)
        {
          int num2 = -320203502;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 3U)
          {
            case 1:
              autoGenerated = this.autoGenerated;
              num1 = (int) num3 * 1764776460 ^ -1881188361;
              continue;
            case 2:
              goto label_1;
            default:
              goto label_4;
          }
        }
label_4:
        return autoGenerated;
      }
      set
      {
label_1:
        int num1 = -1271036586;
        while (true)
        {
          int num2 = -1138904405;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 0:
              goto label_1;
            case 1:
              this.autoGenerated = value;
              this.RaisePropertyChanged(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(1474605969U));
              num1 = (int) num3 * 1163753023 ^ -699092793;
              continue;
            case 2:
              goto label_3;
            case 3:
              num1 = (int) num3 * -2036253920 ^ -211164267;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        return;
label_3:;
      }
    }

    public static ZoomChat Load(SQLiteDataReader cReader)
    {
      ZoomChat zoomChat1 = new ZoomChat();
      if (!zoomChat1.LoadDataObject(cReader))
        goto label_4;
label_1:
      int num1 = 242452094;
label_2:
      ZoomChat zoomChat2;
      while (true)
      {
        int num2 = 1222028487;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 5U)
        {
          case 1:
            goto label_4;
          case 2:
            zoomChat2 = zoomChat1;
            num1 = (int) num3 * -1603123610 ^ -207450514;
            continue;
          case 3:
            goto label_1;
          case 4:
            num1 = (int) num3 * 1419051093 ^ -2120438402;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return zoomChat2;
label_4:
      zoomChat2 = (ZoomChat) null;
      num1 = 1566984393;
      goto label_2;
    }

    public override string ToString()
    {
label_1:
      int num1 = -1012240257;
      string str;
      while (true)
      {
        int num2 = -1144682374;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 4U)
        {
          case 1:
            str = ZoomChat.\u202C⁭⁭‭‬‎‎​‬‬​‬‪⁫‬‌‬⁬⁮‍⁬‮​⁫‭⁯‏‎‌⁯⁮⁭‪‏‭‌​‎⁭⁭‮(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(613868858U), (object) this.SendingZoomId, (object) this.ReceivingZoomId, (object) ZoomChat.\u206D‍⁮‫⁫⁫‍‫‌⁯‍‍⁪‬‮⁪⁯⁯⁬⁮‍⁪⁯⁫‮‫⁮⁯‎‏⁮‌⁪‌⁯‎⁪‌⁫⁭‮(this.ChatContent, 0, 25));
            num1 = (int) num3 * -1545355188 ^ 483121472;
            continue;
          case 2:
            num1 = (int) num3 * -842083943 ^ -1361948096;
            continue;
          case 3:
            goto label_1;
          default:
            goto label_5;
        }
      }
label_5:
      return str;
    }

    public override Dictionary<string, object> GetDataDictionary()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      dictionary1.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U), (object) this.Uri);
label_1:
      int num1 = -1969624908;
      Dictionary<string, object> dictionary2;
      while (true)
      {
        int num2 = -993394857;
        uint num3;
        switch ((num3 = (uint) (num1 ^ num2)) % 19U)
        {
          case 1:
            num1 = (int) num3 * 1222780167 ^ -2088683588;
            continue;
          case 2:
            num1 = (int) num3 * -2136036241 ^ 1185558501;
            continue;
          case 3:
            dictionary1.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(1413012443U), (object) this.userAliases);
            num1 = (int) num3 * -1845291223 ^ 845980370;
            continue;
          case 4:
            dictionary1.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(184628259U), (object) this.WasPublic);
            num1 = (int) num3 * 138967486 ^ -1831052121;
            continue;
          case 5:
            goto label_1;
          case 6:
            num1 = (int) num3 * 2006808717 ^ -33647139;
            continue;
          case 7:
            num1 = (int) num3 * -261662043 ^ -290394675;
            continue;
          case 8:
            dictionary1.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3544817423U), (object) this.ChatContent);
            dictionary1.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1679528045U), (object) this.DateCreated);
            num1 = (int) num3 * -1949970739 ^ 1359468738;
            continue;
          case 9:
            dictionary1.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2993491348U), (object) this.SendingZoomId);
            num1 = (int) num3 * 575802379 ^ -1112912008;
            continue;
          case 10:
            num1 = (int) num3 * 1218501457 ^ -522138378;
            continue;
          case 11:
            dictionary1.Add(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(1458098664U), (object) this.WasBlocked);
            num1 = (int) num3 * 224849714 ^ 302783209;
            continue;
          case 12:
            dictionary1.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(69011950U), (object) this.ChatType);
            dictionary1.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(4184677475U), (object) this.MeetingUri);
            dictionary1.Add(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(3213433278U), (object) this.SendingUserUri);
            num1 = (int) num3 * 883815091 ^ 1372256486;
            continue;
          case 13:
            dictionary2 = dictionary1;
            num1 = (int) num3 * -1680694062 ^ -1218042968;
            continue;
          case 14:
            num1 = (int) num3 * 780475941 ^ 754337307;
            continue;
          case 15:
            dictionary1.Add(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(4038271604U), (object) this.ReceivingZoomId);
            num1 = (int) num3 * 1360546577 ^ 1635917739;
            continue;
          case 16:
            dictionary1.Add(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3335598589U), (object) this.DateModified);
            num1 = (int) num3 * 86431128 ^ -685543025;
            continue;
          case 17:
            num1 = (int) num3 * 1121292309 ^ -1282400698;
            continue;
          case 18:
            dictionary1.Add(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3205791949U), (object) this.ReceivingUserUri);
            num1 = (int) num3 * -100439245 ^ -473994743;
            continue;
          default:
            goto label_20;
        }
      }
label_20:
      return dictionary2;
    }

    public override bool LoadDataObject(SQLiteDataReader cReader)
    {
      bool flag = false;
      try
      {
        this.uri = cReader.GetFieldValueLong(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3466564611U));
label_2:
        int num1 = 200130722;
        while (true)
        {
          int num2 = 1264074890;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 11U)
          {
            case 0:
              this.chatContent = cReader.GetFieldValueString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3544817423U));
              num1 = (int) num3 * 2108894250 ^ -1365186622;
              continue;
            case 1:
              this.dateCreated = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2131605649U));
              num1 = (int) num3 * -204568305 ^ -1560673874;
              continue;
            case 2:
              num1 = (int) num3 * -1449453019 ^ 959581725;
              continue;
            case 3:
              this.wasPublic = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A​‬⁪‫‪‫‪⁯⁭⁮‮⁭‪‫⁪⁮⁫‎⁫⁭⁮‭‪⁫‏‮‎‭‍‌⁮‎‫‍​⁮⁮‎‎‮<string>(3440466548U)) == 1;
              this.userAliases = cReader.GetFieldValueString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(1290447143U));
              num1 = 463030391;
              continue;
            case 4:
              goto label_2;
            case 5:
              flag = true;
              num1 = (int) num3 * 2013890470 ^ 993626349;
              continue;
            case 6:
              this.sendingZoomId = cReader.GetFieldValueString(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(2993491348U));
              this.receivingZoomId = cReader.GetFieldValueString(\u003CModule\u003E.\u206A‪‫‬‫⁬‎‭‬⁪‌⁮⁯⁭‫‏‭‭‏⁪‍‫⁯⁮⁬⁭‌​⁭⁬‬‪⁬⁮‎⁫⁯‬‏‬‮<string>(3444990068U));
              num1 = (int) num3 * -877179800 ^ -613917957;
              continue;
            case 7:
              this.dateModified = cReader.GetFieldValueDateTime(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(2110344247U));
              this.wasBlocked = cReader.GetFieldValueInt(\u003CModule\u003E.\u202A⁭⁪⁮‎⁬‪‫⁯‪‪‏‮‬⁫‎‏‌⁪‌⁬‫‬⁮‌‍⁬⁫‫‌⁮‌‌‮⁬⁬⁮‫‪‮‮<string>(3887009631U)) == 1;
              num1 = 1097163448;
              continue;
            case 8:
              this.chatType = cReader.GetFieldValueInt(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(69011950U));
              this.meetingUri = cReader.GetFieldValueLong(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(3450719713U));
              num1 = (int) num3 * 1731339576 ^ -1017681222;
              continue;
            case 10:
              this.sendingUserUri = cReader.GetFieldValueLong(\u003CModule\u003E.\u200E‏⁯‍‬⁭⁪‌‌‌⁪⁫‫‎⁫‮⁬‎‌⁮⁪⁪⁭‍‌⁫‮‬‎⁬‎‌‎‌⁪‫‬‮⁮‮<string>(141391426U));
              this.receivingUserUri = cReader.GetFieldValueLong(\u003CModule\u003E.\u206B‎‏⁫‎‮‌⁪​‪‏⁯‭⁭⁯⁯‭‍‍‬‬⁭⁬⁪‫⁫⁬⁭⁮‌⁮‎‮⁪‮‪⁬‌‪⁬‮<string>(2704433137U));
              num1 = (int) num3 * -747175467 ^ -1123785847;
              continue;
            default:
              goto label_18;
          }
        }
      }
      catch (Exception ex)
      {
label_14:
        int num1 = 1988299727;
        while (true)
        {
          int num2 = 1264074890;
          uint num3;
          switch ((num3 = (uint) (num1 ^ num2)) % 4U)
          {
            case 1:
              ZoomChat.\u200B‭⁮‌⁭​‬‎⁯⁫⁫‫⁯​⁬⁪‍‭‮‎⁯‮‍‬⁫⁮⁪⁪‭​‏⁪‌​⁯‪⁫‌⁫‮(CoreObject.log, (object) ex);
              num1 = (int) num3 * 1784419196 ^ -1405603604;
              continue;
            case 2:
              num1 = (int) num3 * 1367145316 ^ 1966622402;
              continue;
            case 3:
              goto label_14;
            default:
              goto label_18;
          }
        }
      }
label_18:
      return flag;
    }

    static string[] \u202B‭⁫⁮‏‍‍‭‫‪⁪‌‫‪‮⁬‍‏‪⁬‎⁬⁬‎‭‏‏‮‪⁫‭‮⁯‌‬‭‮‏‬‫‮([In] string obj0, [In] char[] obj1)
    {
      return obj0.Split(obj1);
    }

    static string \u202A​⁪‮⁫‏‫⁮‭‪‬⁪⁮‪⁯⁪‏⁯‍⁫‎⁭‪⁪‎‬‏‏​‌‍⁬‍‍‭⁪⁫⁮⁬‍‮([In] string obj0, [In] IEnumerable<string> obj1)
    {
      return string.Join(obj0, obj1);
    }

    static bool \u202E⁯⁫‎‮‪⁫‫⁬‎‎⁪‏‪⁭‭‬‌‫‫‬‌‮‏‌‫‬⁬⁬‭‭‌‮⁬⁬‎⁮⁪‏‪‮([In] string obj0, [In] string obj1)
    {
      return obj0.Equals(obj1);
    }

    static bool \u206D‬‮⁫‪⁯‫‪⁯⁭‎⁭‪‍‪‪‮‍‭⁭‌⁬‭‬⁪‏‫⁮‍‍‬‏‏⁯‮⁪‏‏⁯⁮‮([In] string obj0)
    {
      return string.IsNullOrEmpty(obj0);
    }

    static string \u206D‍⁮‫⁫⁫‍‫‌⁯‍‍⁪‬‮⁪⁯⁯⁬⁮‍⁪⁯⁫‮‫⁮⁯‎‏⁮‌⁪‌⁯‎⁪‌⁫⁭‮([In] string obj0, [In] int obj1, [In] int obj2)
    {
      return obj0.Substring(obj1, obj2);
    }

    static string \u202C⁭⁭‭‬‎‎​‬‬​‬‪⁫‬‌‬⁬⁮‍⁬‮​⁫‭⁯‏‎‌⁯⁮⁭‪‏‭‌​‎⁭⁭‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
    {
      return string.Format(obj0, obj1, obj2, obj3);
    }

    static void \u200B‭⁮‌⁭​‬‎⁯⁫⁫‫⁯​⁬⁪‍‭‮‎⁯‮‍‬⁫⁮⁪⁪‭​‏⁪‌​⁯‪⁫‌⁫‮([In] ILog obj0, [In] object obj1)
    {
      obj0.Error(obj1);
    }
  }
}
