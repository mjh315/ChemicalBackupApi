using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TPaydarimadeh : IBackupable
{
    [Key]
    public required string IdPaydarimadeh { get; set; }


    public string? Paydari { get; set; }
    public string? SharayetGhabelEhteraz { get; set; }
    public string? KhataratVakoneshdehi { get; set; }
    public string? MahsolatTajziyeKhatarnak { get; set; }
    public int? AdadVakoneshDehiNfpa { get; set; }




    public int IdPaydarimadehApp { get; set; }
    public int TAllmadehIdApp { get; set; }



    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

