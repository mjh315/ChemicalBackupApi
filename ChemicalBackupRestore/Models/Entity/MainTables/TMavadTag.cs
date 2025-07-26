using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


public class TMavadTag : IBackupable
{
    [Key]
    public required string ID_Mavad_Tag { get; set; }



    public int T_Allmadehs_IDApp { get; set; }
    public int ID_Mavad_TagApp { get; set; }
    public int T_Tag_IDApp { get; set; }




    public string? FK_T_Tag_ID { get; set; }
    [ForeignKey("FK_T_Tag_ID")]
    public virtual TTags? T_Tag { get; set; }

    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }


    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

