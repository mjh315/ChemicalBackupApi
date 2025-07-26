using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


public class TReactivity : IBackupable
{
    [Key]
    public required string IdReactivity { get; set; }


    public int TAllmadeh1Id { get; set; }
    public int TAllmadeh2Id { get; set; }
    public string? Vakonesh { get; set; }
    public string? HazardPredictions { get; set; }
    public string? GasPrediction { get; set; }



    public int IdReactivityApp { get; set; }
    public int TAllmadehIdApp { get; set; }



    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

