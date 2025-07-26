using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class TTagMatter : IBackupable
{
    [Key]
    public required string ID_TagMatter { get; set; }


    public string? Feshar { get; set; }
    public string? Dama { get; set; }
    public string? Sath { get; set; }
    public int Darsad { get; set; }





    public int TAllmadehIdApp { get; set; }
    public int ID_TagMatterApp { get; set; }
    public int T_Tag_IDApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }


    public string? FK_T_Tag_ID { get; set; }
    [ForeignKey("FK_T_Tag_ID")]
    public virtual TTags? T_Tag { get; set; }


    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

