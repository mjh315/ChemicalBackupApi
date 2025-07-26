using System.ComponentModel.DataAnnotations;

public class BackupStatus
{
    [Key]
    public Guid IdBackup { get; set; }
    public int AdminId { get; set; }

    [MaxLength]
    public required string ListOfTablesBackup { get; set; } // example: "Add_Shift_FirefightersEntities: 0, Add_TestEntities, 0"
    public required string Status { get; set; } // "Created", "Pending" , "Completed", "Failed"
    public required string BackupName { get; set; } 
    [MaxLength]
    public required string BackupDescription { get; set; } 
    public DateTime DateStarted { get; set; }
    public DateTime DateEnded { get; set; }
    public string? ErrorMessage { get; set; }


    

    // Navigation properties
    public ICollection<T_L_Rotbebandi_Movajehe>? T_L_Rotbebandi_Movajehes { get; set; }
    public ICollection<TLAdadEtalatHarigh>? TLAdadEtalatHarighs { get; set; }
    public ICollection<TLAdadEtelatBehdashti>? TLAdadEtelatBehdashtis { get; set; }
    public ICollection<TLAdadEtelatVakonoshdehi>? TLAdadEtelatVakonoshdehis { get; set; }
    public ICollection<TLKhataratKhas>? TLKhataratKhases { get; set; }
    public ICollection<TLVahed>? TLVaheds { get; set; }


    public ICollection<TAllmadeh>? TAllmadehs { get; set; }
    public ICollection<TEghdamatDarmani>? TEghdamatDarmanis { get; set; }
    public ICollection<TEtelatAnbardari>? TEtelatAnbardaris { get; set; }
    public ICollection<TEtelatbehdashti>? TEtelatbehdashtis { get; set; }
    public ICollection<TEtelatHamlonaghl>? TEtelatHamlonaghls { get; set; }
    public ICollection<TEtelatHarigh>? TEtelatHarighs { get; set; }
    public ICollection<TEtelatSamShenas>? TEtelatSamShenas { get; set; }
    public ICollection<TGhs>? TGhses { get; set; }
    public ICollection<TLogs>? TLogs { get; set; }
    public ICollection<THododmojazmovajehe>? THododmojazmovajehes { get; set; }
    public ICollection<TKhataratmadeh>? TKhataratmadehes { get; set; }
    public ICollection<TKhavasfiziki>? TKhavasfizikis { get; set; }
    public ICollection<TKomakhayeAvaleyeh>? TKomakhayeAvaleyehs { get; set; }
    public ICollection<T_Madeh_Movajehe>? T_Madeh_Movajehes { get; set; }
    public ICollection<T_Makan>? T_Makans { get; set; }
    public ICollection<T_Map_Locations>? T_Map_Locations { get; set; }
    public ICollection<T_Map_Madeh>? T_Map_Madehs { get; set; }
    public ICollection<T_OnvanShoghli>? T_OnvanShoghlis { get; set; }
    public ICollection<TAllmadehTarkibi>? TAllmadehTarkibis { get; set; }
    public ICollection<TArzyabi>? TArzyabis { get; set; }
    public ICollection<TLMyLibrary>? TLMyLibrarys { get; set; }
    public ICollection<TMavadTag>? TMavadTags { get; set; }
    public ICollection<TModelsaziEnteshar>? TModelsaziEnteshars { get; set; }
    public ICollection<TOsolkontoroli>? TOsolkontorolis { get; set; }
    public ICollection<TPaydarimadeh>? TPaydarimadeh { get; set; }
    public ICollection<TRahnamayeMoayenat>? TRahnamayeMoayenats { get; set; }
    public ICollection<TReactivity>? TReactivitys { get; set; }
    public ICollection<TSarneveshtZistmohiti>? TSarneveshtZistmohitis { get; set; }
    public ICollection<TSharayetezterari>? TSharayetezteraris { get; set; }
    public ICollection<TTagMatter>? TTagMatters { get; set; }
    public ICollection<TTags>? TTags { get; set; }
    public ICollection<TTajhiz>? TTajhizs { get; set; }
    public ICollection<TTajhizatHefazatfardi>? TTajhizatHefazatfardis { get; set; }
    public ICollection<T_CEI>? T_CEIs { get; set; }
    public ICollection<TFileERG>? TFileERG { get; set; }


}