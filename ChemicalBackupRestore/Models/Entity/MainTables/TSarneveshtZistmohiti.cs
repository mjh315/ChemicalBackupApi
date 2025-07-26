using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TSarneveshtZistmohiti : IBackupable
{
    [Key]
    public required string IdSarneveshtZistmohiti { get; set; }



    public string? SarneveshtZistmohiti { get; set; }
    public string? MoajehMohiti { get; set; }
    public string? JazbDrKhak { get; set; }
    [StringLength(550)]
    public string? AsibBeEqosistem { get; set; }
    public string? AsaratDerazModat { get; set; }
    public string? PaydariDrMohitzist { get; set; }
    public string? SamiiatZisti { get; set; }
    public string? GhabeliatTajamoZisti { get; set; }
    public string? SobatVaTajrobeNapazirizisti { get; set; }





    public int IdSarneveshtZistmohitiApp { get; set; }
    public int TAllmadehIdApp { get; set; }





    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

