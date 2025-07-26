using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TTajhizatHefazatfardi : IBackupable
{
    [Key]
    public required string IdTajhizatHefazatfardi { get; set; }


    [StringLength(250)]
    public string? HefazatCheshm { get; set; }
    [StringLength(550)]
    public string? HefazatDast { get; set; }
    [StringLength(550)]
    public string? HefazatBadan { get; set; }
    public string? HefazatSystemtanafosi { get; set; }
    [StringLength(550)]
    public string? HefazatPa { get; set; }
    public string? FaktorhayeHefazatTanafosi { get; set; }
    public string? HoodoodMojazBiologic { get; set; }
    public string? EghdamatControliMohandesi { get; set; }
    public string? VasayelHefazatiHararati { get; set; }



    public int IdTajhizatHefazatfardiApp { get; set; }
    public int TAllmadehIdApp { get; set; }



    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
}

