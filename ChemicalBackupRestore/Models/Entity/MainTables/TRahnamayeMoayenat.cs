using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


public partial class TRahnamayeMoayenat : IBackupable
{
    [Key]
    public required string IdRahnamayeMoayenat { get; set; }


    public string? MoayenatOmoumi { get; set; }
    public string? MamnoueeyatMoayene { get; set; }
    public string? Tanafosi { get; set; }
    public string? Cheshm { get; set; }
    public string? Post { get; set; }
    public string? Khon { get; set; }
    public string? Eskeleti { get; set; }
    public string? MaqzOAsab { get; set; }
    public string? Tanasoli { get; set; }
    public string? QalbuOurough { get; set; }
    public string? Kabed { get; set; }
    public string? Kolie { get; set; }
    public string? Govaresh { get; set; }
    public string? Edrari { get; set; }
    public string? Goosh { get; set; }
    public string? BioMarker { get; set; }
    public string? Bini { get; set; }
    public string? DahanVaGelou { get; set; }
    public string? DamayeBadan { get; set; }
    public string? TestAzmayeshgahi { get; set; }
    public string? SayerMpayenat { get; set; }
    public string? ModiriatRahhayHavaei { get; set; }
    public string? HazfPishrafte { get; set; }
    public string? ShokiYaKoma { get; set; }
    public string? HEENT { get; set; }
    public string? TaghiiratHourmoni { get; set; }




    public int IdRahnamayeMoayenatApp { get; set; }
    public int TAllmadehIdApp { get; set; }


    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

