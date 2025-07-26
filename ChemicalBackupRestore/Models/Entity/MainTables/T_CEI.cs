using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

public class T_CEI : IBackupable
{
    [Key]
    public required string IdCEI { get; set; }
    public int IdCEIApp { get; set; }
    public string? Zarf { get; set; }
    public int? QotrLole { get; set; }
    public int? QotrParegi { get; set; }
    public int? MotaselBeZarf { get; set; }
    public string? OnvaneSenario { get; set; }
    public string? Vahed { get; set; }
    public string? Tajhiz { get; set; }
    public string? VahedTajhiz { get; set; }
    public string? HalatRahayeshMade { get; set; }
    public int? MeghdarKolMade { get; set; }
    public int? DamayeFarayand { get; set; }
    public int? Meghdargij { get; set; }
    public int? ErtefSathMayeAzMahalRahaYesh { get; set; }
    public int? MasahatDayk { get; set; }
    public int? MakhazenDayk { get; set; }
    public int? Mw { get; set; }
    public int? DansitehBokhar { get; set; }



    
    // Haman BP dar jadval khavasFiziki
    public int? NoghteJoosh { get; set; }
    public int? FesharBokharMaye { get; set; }
    public int? GarmayeTabkhir { get; set; }
    public int? GarmayeSokhtan { get; set; }
    public int? ERPG1 { get; set; }
    public int? ERPG2 { get; set; }
    public int? ERPG3 { get; set; }
    public int? DamayeMadehDarMohit { get; set; }




    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? Allmadeh { get; set; }

    
    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

