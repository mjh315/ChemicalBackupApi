
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

public partial class TAllmadehTarkibi : IBackupable
{
    [Key]
    public required string IdAllmadehTarkibi { get; set; }

    public string? Darsad { get; set; }
    public string? MatterName { get; set; }



    public int IdAllmadehTarkibiApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

