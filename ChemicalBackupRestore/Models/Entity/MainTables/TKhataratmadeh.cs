using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TKhataratmadeh : IBackupable
{
    [Key]
    public required string IdKhataratmadeh { get; set; }



    public string? Saratanzayi { get; set; }

    [StringLength(550)]
    public string? PolimerizasionKhatarnak { get; set; }
    public string? KhataratHad { get; set; }
    public string? KhataratMozmen { get; set; }
    public string? MahsolatSamiSokhtan { get; set; }
    public string? TajziyeKhatarnak { get; set; }
    public string? EghdamatEhtiyati { get; set; }
    public string? SayerKhataratTabagheBandiNashode { get; set; }



    public int IdKhataratmadehApp { get; set; }
    public int TAllmadehIdApp { get; set; }




    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}
