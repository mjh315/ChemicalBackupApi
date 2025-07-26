using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TEtelatHarigh : IBackupable
{
    [Key]
    public required string IdEtelatHarigh { get; set; }

    public string? HadaghalEnerzhiehteragh { get; set; }
    public string? PotansiyelEhteragh { get; set; }
    public string? RaveshEtfayeHarigh { get; set; }
    public string? KhataratSokhtan { get; set; }
    public string? MahsolatEhteragh { get; set; }
    public string? TajhizatHefazati { get; set; }
    public string? VakoneshDehiBaAb { get; set; }
    public string? RiskHarigh { get; set; }
    public string? KhatarShimiaei { get; set; }
    public string? KhatarEnfejar { get; set; }
    public string? EtelaatAtashneshani { get; set; }
    public string? MadehMonasebEtfaei { get; set; }





    public int IdEtelatHarighApp { get; set; }
    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

