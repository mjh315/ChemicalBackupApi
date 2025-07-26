using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

public partial class TEghdamatDarmani : IBackupable
{
    [Key]
    public required string IdEghdamatDarmani { get; set; }


    public string? ModiriyatRahTanafosi { get; set; }
    public string? ModiriyatMovajeheCheshmi { get; set; }
    public string? ModiriyatMovajeheKhoraki { get; set; }
    public string? ModiriyatMovajehePosti { get; set; }
    public string? TashkhisEftraghi { get; set; }
    public string? MeyarhayeEzambeMarakzDarman { get; set; }
    public string? MeyarhayePazireshVaBastari { get; set; }
    public string? MeyarhayeErayeMoshverPezeshki { get; set; }
    public string? MeyarhayeTarkhis { get; set; }
    public string? AlodegizodaiPishBimarestani { get; set; }
    public string? AlodegizodaiBimarestani { get; set; }
    public string? AlodegizodaiDarManzel { get; set; }




    public int IdEghdamatDarmaniApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

