using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class TModelsaziEnteshar : IBackupable
{
    [Key]
    public required string IdModelsaziEnteshar { get; set; }
    public string? UserId { get; set; }
    public string? Mw { get; set; }
    public DateTime DateCraeted { get; set; }
    public string? DansitehBokhar { get; set; }
    public string? NoghteJoosh { get; set; }
    public string? FesharBokharMaye { get; set; }
    public string? GarmayeTabkhir { get; set; }
    public string? GarmayeSokhtan { get; set; }
    public string? ERPG1 { get; set; }
    public string? ERPG2 { get; set; }
    public string? ERPG3 { get; set; }
    public string? TlvTwa { get; set; }
    public string? TlvStel { get; set; }
    public string? TlvC { get; set; }
    public string? Lc50 { get; set; }
    public string? Ld50 { get; set; }
    public string? Ph { get; set; }
    public double IdCEI { get; set; }
    public string? Zarf { get; set; }
    public string? HalatRahayeshMade { get; set; }
    public int TAllmadehId { get; set; }
    public double QotrLole { get; set; }
    public double QotrParegi { get; set; }
    public double MotaselBeZarf { get; set; }
    public string? OnvaneSenario { get; set; }
    public string? Vahed { get; set; }
    public string? Tajhiz { get; set; }
    public string? ShomareTajhiz { get; set; }
    public double MeghdarKolMade { get; set; }
    public double DamayeFarayand { get; set; }
    public double FesharGij { get; set; }
    public double ErtefSathMayeAzMahalRahaYesh { get; set; }
    public double MasahatDayk { get; set; }
    public double MakhazenDayk { get; set; }
    public string? DamayeMadehDarMohit { get; set; }

    // Final Values
    public string? CEI { get; set; }
    public string? HD1 { get; set; }
    public string? HD2 { get; set; }
    public string? HD3 { get; set; }



    public int IdModelsaziEntesharApp { get; set; }






    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

