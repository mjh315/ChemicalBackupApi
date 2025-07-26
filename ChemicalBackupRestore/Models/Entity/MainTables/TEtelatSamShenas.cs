using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TEtelatSamShenas : IBackupable
{
    [Key]
    public required string IdEtelatSamShenasi { get; set; }


    public string? Idlh { get; set; }
    public string? Lc50 { get; set; }
    public double Lc50Num { get; set; }
    public string? Ld50 { get; set; }
    public string? BiologicToxicityValues { get; set; }
    public string? ModiriatMasmomiatShadid { get; set; }
    public string? ModiriatMasmomiatMolayem { get; set; }
    public string? Toksicokentic { get; set; }
    public string? ZhnotoKesisiti { get; set; }
    public string? SammiatHad { get; set; }
    public string? SammiatMozmen { get; set; }
    public string? KhatarAspirasion { get; set; }






    public int IdEtelatSamShenasiApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

