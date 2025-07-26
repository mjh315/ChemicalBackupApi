using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


public partial class TAllmadeh : IBackupable
{

    [Key]
    public required string IdAllmadeh { get; set; }




    public string? NameEn { get; set; }
    public string? NameFa { get; set; }
    public string? Formol { get; set; }
    public string? Cas { get; set; }
    public string? Erg { get; set; }
    public string? Un { get; set; }
    public string? ClaseKhatarDot { get; set; }
    public string? HamNamHa { get; set; }
    public string? EstefadehayeAsli { get; set; }
    public string? BatanKhatarGhs { get; set; }
    public string? Sobat { get; set; }
    public string? OmreMofid { get; set; }
    public string? Img1 { get; set; }
    public string? Img2 { get; set; }
    public string? Img3 { get; set; }
    public string? Img4 { get; set; }
    public string? Img5 { get; set; }
    public string? Img6 { get; set; }
    public string? Img7 { get; set; }
    public string? Img8 { get; set; }
    public string? Img9 { get; set; }
    public bool IsTarkibi { get; set; }
    public bool IsNoEtelatMadeh { get; set; }
    public string? NameFileMadeh { get; set; }







    public int IdAllmadehApp { get; set; }
    public int TLAdadEtelatBehdashtiIdApp { get; set; }
    public int TLAdadEtalatHarighIdApp { get; set; }
    public int TLAdadEtelatVakonoshdehiIdApp { get; set; }
    public int TLKhataratKhasIdApp { get; set; }






    public string? FK_TLAdadEtelatBehdashtiId { get; set; }
    [ForeignKey("FK_TLAdadEtelatBehdashtiId")]
    public virtual TLAdadEtelatBehdashti? TLAdadEtelatBehdashti { get; set; }

    public string? FK_TLAdadEtalatHarighId { get; set; }
    [ForeignKey("FK_TLAdadEtalatHarighId")]
    public virtual TLAdadEtalatHarigh? TLAdadEtalatHarigh { get; set; }

    public string? FK_TLAdadEtelatVakonoshdehiId { get; set; }
    [ForeignKey("FK_TLAdadEtelatVakonoshdehiId")]
    public virtual TLAdadEtelatVakonoshdehi? TLAdadEtelatVakonoshdehi { get; set; }

    public string? FK_TLKhataratKhasId { get; set; }
    [ForeignKey("FK_TLKhataratKhasId")]
    public virtual TLKhataratKhas? TLKhataratKhas { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }







    public virtual IList<TEghdamatDarmani>? TEghdamatDarmani { get; set; }

    public virtual IList<TEtelatAnbardari>? TEtelatAnbardari { get; set; }

    public virtual IList<TEtelatHamlonaghl>? TEtelatHamlonaghl { get; set; }

    public virtual IList<TEtelatHarigh>? TEtelatHarigh { get; set; }
    public virtual IList<TEtelatSamShenas>? TEtelatSamShenas { get; set; }
    public virtual IList<TEtelatbehdashti>? TEtelatbehdashti { get; set; }
    public virtual IList<TGhs>? TGhs { get; set; }
    public virtual IList<THododmojazmovajehe>? THododmojazmovajehe { get; set; }
    public virtual IList<TKhataratmadeh>? TKhataratmadeh { get; set; }
    public virtual IList<TKhavasfiziki>? TKhavasfiziki { get; set; }
    public virtual IList<TKomakhayeAvaleyeh>? TKomakhayeAvaleyeh { get; set; }
    public virtual IList<TOsolkontoroli>? TOsolkontoroli { get; set; }
    public virtual IList<TPaydarimadeh>? TPaydarimadeh { get; set; }
    public virtual IList<TSarneveshtZistmohiti>? TSarneveshtZistmohiti { get; set; }
    public virtual IList<TSharayetezterari>? TSharayetezterari { get; set; }
    public virtual IList<TTajhizatHefazatfardi>? TTajhizatHefazatfardi { get; set; }
    public virtual IList<TLMyLibrary>? TLMyLibrary { get; set; }
    public virtual IList<TReactivity>? TReactivity { get; set; }
    public virtual IList<TRahnamayeMoayenat>? TRahnamayeMoayenat { get; set; }
    public virtual ICollection<T_Map_Madeh>? T_Map_Madeh { get; set; }
    public virtual ICollection<T_Madeh_Movajehe>? T_Madeh_Movajehe { get; set; }
}

