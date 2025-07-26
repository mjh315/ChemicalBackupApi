using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TEtelatHamlonaghl : IBackupable
{
    [Key]
    public required string IdEtelatHamlonaghl { get; set; }




    [StringLength(550)]
    public string? RaveshHamlonaghl { get; set; }
    public string? AdadHamloNaghlSazmanMelal { get; set; }
    public string? GroupDasteBandi { get; set; }
    public string? ZorofEstandardHamlonaghl { get; set; }
    public string? EhtiyatatVijheHamlonaghl { get; set; }
    public string? HamlonaghlDaryaei { get; set; }




    public int IdEtelatHamlonaghlApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }


    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

