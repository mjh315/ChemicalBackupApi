using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class T_Makan : IBackupable
{

    [Key]
    public required string ID_Makan { get; set; }
    public int ID_MakanApp { get; set; }

    [StringLength(500)]
    public string? OnvanMakan { get; set; }


    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

    // navigation
    public virtual ICollection<T_Madeh_Movajehe>? T_Madeh_Movajehe { get; set; }
    public virtual ICollection<T_Map_Locations>? T_Map_Locations { get; set; }
    public virtual ICollection<TTags>? T_Tag { get; set; }
}
