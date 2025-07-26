using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TSharayetezterari : IBackupable
{
    [Key]
    public required string IdSharayetezterari { get; set; }






    [StringLength(550)]
    public string? JodasaziFori { get; set; }
    [StringLength(550)]
    public string? TakhliyeAvaliyeh { get; set; }
    [StringLength(550)]
    public string? Jodasazi { get; set; }
    [StringLength(550)]
    public string? Takhliye { get; set; }
    [StringLength(550)]
    public string? JodasaziRahayeshKockak { get; set; }
    public string? FaselehJodaavaleDrRoz { get; set; }
    public string? FaselehJodaavaleDrShab { get; set; }
    public string? JodasaziRahayeshBozorg { get; set; }
    public string? FaselehJodasaziRBozorgDrRoz { get; set; }
    public string? FaselehJodasaziRBozorgDrShab { get; set; }
    public string? VasayelHefazatiFardi { get; set; }
    public string? ShoaTakhliyeNashtKochak { get; set; }
    public string? ShoaTakhliyeNashtBozorg { get; set; }
    public string? RaveshDaf { get; set; }
    public string? RaveshJamavari { get; set; }

    public double? Erpg_1 { get; set; }
    public double? Erpg_2 { get; set; }
    public double? Erpg_3 { get; set; }

    public string? Aegl1_10 { get; set; }
    public string? Aegl1_30 { get; set; }
    public string? Aegl1_60 { get; set; }
    public string? Aegl1_4h { get; set; }
    public string? Aegl1_8h { get; set; }

    public string? Aegl2_10 { get; set; }
    public string? Aegl2_30 { get; set; }
    public string? Aegl2_60 { get; set; }
    public string? Aegl2_4h { get; set; }
    public string? Aegl2_8h { get; set; }

    public string? Aegl3_10 { get; set; }
    public string? Aegl3_30 { get; set; }
    public string? Aegl3_60 { get; set; }
    public string? Aegl3_4h { get; set; }
    public string? Aegl3_8h { get; set; }

    public double Erpg1 { get; set; }
    public double Erpg2 { get; set; }
    public double Erpg3 { get; set; }

    public string? MGA { get; set; }
    public string? MGB { get; set; }
    public string? MZC { get; set; }
    public string? MSD { get; set; }
    public string? JodasaziAvalieh { get; set; }
    public string? Tajhizat { get; set; }
    public string? MoayenatPezeshkiPazMovajehe { get; set; }
    public string? EhtiyatatZistMohiti { get; set; }
    public string? MadehJazebMonaseb { get; set; }
    public string? HefazatAzAfradAdi { get; set; }




    public int IdSharayetezterariApp { get; set; }
    public int TAllmadehIdApp { get; set; }





    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

