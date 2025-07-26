using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TGhs : IBackupable
{
    [Key]
    public required string IdGhs { get; set; }


    [StringLength(250)]
    public string? Signal { get; set; }
    public string? BayaneKhatar { get; set; }
    [StringLength(250)]
    public string? JomleEhtiyati { get; set; }
    [StringLength(550)]
    public string? Piktogram { get; set; }




    public int IdGhsApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

