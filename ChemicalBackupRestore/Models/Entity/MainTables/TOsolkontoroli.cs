using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TOsolkontoroli : IBackupable
{
    [Key]
    public required string IdOsolkontoroli { get; set; }


    public string? RaveshHamlonaghlJabejayi { get; set; }
    public string? TajhizatHefazatFardi { get; set; }
    public string? OtherProtectiveActions { get; set; }



    public int IdOsolkontoroliApp { get; set; }
    public int TAllmadehIdApp { get; set; }




    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }


    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

