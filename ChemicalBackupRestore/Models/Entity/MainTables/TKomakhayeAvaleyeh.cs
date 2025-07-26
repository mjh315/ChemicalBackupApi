using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TKomakhayeAvaleyeh : IBackupable
{
    [Key]
    public required string IdKomakhayeAvaleyeh { get; set; }


    public string? AntiDot { get; set; }
    public string? KomakhayeAvaleyePosti { get; set; }
    public string? KomakhayeAvaleyeTanafosi { get; set; }
    public string? KomakhayeAvaleyeCheshmi { get; set; }
    public string? KomakhayeAvaleyeGovareshi { get; set; }
    public string? KomakhayeAvaleyeGhalbi { get; set; }
    public string? AlodegiZodaeiEzterari { get; set; }
    public string? MeyarhayeEzambeBimarestan { get; set; }
    public string? KhatayeEhtemaliDarman { get; set; }
    public string? KomakHayeAvalieMovajeheHad { get; set; }
    public string? AlaemHayati { get; set; }
    public string? DoreZamani { get; set; }
    public string? TasiratTakhiriMovajehe { get; set; }
    public string? DarmanhayeEkhtesasi { get; set; }




    public int IdKomakhayeAvaleyehApp { get; set; }
    public int TAllmadehIdApp { get; set; }




    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}
