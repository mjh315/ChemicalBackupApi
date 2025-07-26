using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TEtelatAnbardari : IBackupable
{
    [Key]
    public required string IdEtelatAnbardari { get; set; }



    public string? DamayeNegahdari { get; set; }

    public string? SharayetNegahdari { get; set; }
    public string? MavadNasazegar { get; set; }
    public string? ModatZamanNegahdari { get; set; }
    public string? SharayetMamnoehAnbaresh { get; set; }
    public string? ZorofMonasebAnbaresh { get; set; }




    public int IdEtelatAnbardariApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}
