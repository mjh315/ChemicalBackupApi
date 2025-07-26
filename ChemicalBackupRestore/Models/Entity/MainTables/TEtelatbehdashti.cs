using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TEtelatbehdashti : IBackupable
{
    [Key]
    public required string IdEtelatbehdashti { get; set; }

    public string? AlaemMovajehe { get; set; }
    public string? AsaratMozmen { get; set; }
    public string? AsaratHad { get; set; }
    public string? GhabeleyatTahrik { get; set; }
    public string? AndamHadaf { get; set; }
    public string? AsaratKotahModat { get; set; }
    public string? RahhayeMovajehe { get; set; }
    public string? MoayenatPezeshki { get; set; }
    public string? MoayenatPezeshiPasazMovajehe { get; set; }





    public int IdEtelatbehdashtiApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}
