using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class T_Map_Madeh : IBackupable
{
    [Key]
    public required string ID_Map_Madeh { get; set; }





    public int ID_Map_MadehApp { get; set; }

    public int? T_Map_Locations_IDApp { get; set; }

    public int TAllmadehIdApp { get; set; }







    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public TAllmadeh? TAllmadeh { get; set; }


    public string? FK_T_Map_LocationsId { get; set; }
    [ForeignKey("FK_T_Map_LocationsId")]
    public virtual T_Map_Locations? T_Map_Locations { get; set; }



    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

}
