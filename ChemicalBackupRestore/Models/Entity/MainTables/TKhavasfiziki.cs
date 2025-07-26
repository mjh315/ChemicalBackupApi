using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class TKhavasfiziki : IBackupable
{
    [Key]
    public required string IdKhavasfiziki { get; set; }



    public string? HalatfizikiVaziyat { get; set; }
    public string? Vozoh { get; set; }
    public string? Boo { get; set; }
    public string? Mazeh { get; set; }
    public string? Ghabelenhelal { get; set; }


    public string? Color { get; set; }
    public string? GarmayeTabkhir { get; set; }
    public string? GarmayeSokhtan { get; set; }
    public string? NoghteEnjemad { get; set; }
    public string? ZaribTajzieh { get; set; }
    public string? DamayeTajzieh { get; set; }


    public string? Mw { get; set; }
    public double MwNum { get; set; }
    public string? Bp { get; set; }
    public double BpNum { get; set; }
    public string? Vi { get; set; }
    public string? Vd { get; set; }
    public double VdNum { get; set; }
    public string? Sg { get; set; }
    public double SgNum { get; set; }
    public string? Ph { get; set; }
    public double PhNum { get; set; }
    public string? Mp { get; set; }
    public string? Ait { get; set; }
    public string? Lel { get; set; }
    public double LelNum { get; set; }
    public string? Uel { get; set; }
    public double UelNum { get; set; }
    public string? Ip { get; set; }
    public string? Ot { get; set; }
    public double OtNum { get; set; }
    public string? Vp { get; set; }
    public string? Fp { get; set; }
    public double FpNum { get; set; }







    public int IdKhavasfizikiApp { get; set; }
    public int TAllmadehIdApp { get; set; }




    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }

    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}

