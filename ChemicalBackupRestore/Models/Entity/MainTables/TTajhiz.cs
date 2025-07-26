using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class TTajhiz : IBackupable
{
    [Key]
    public required string ID_Tajhiz { get; set; }



    [MaxLength(250)]
    public string? Onvan_Tajhiz { get; set; }
    public string? Url { get; set; }
    public string? Onvan { get; set; }
    public DateTime DateCreate { get; set; }
    public bool Active { get; set; }
    public int Tedad_Shaghelin { get; set; }



    public int ID_TajhizApp { get; set; }
    public int T_Vaheds_IDApp { get; set; }



    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
    public string? FK_T_Vaheds_ID { get; set; }
    [ForeignKey("FK_T_Vaheds_ID")]
    public virtual TLVahed? T_Vaheds { get; set; }

    public virtual ICollection<T_Madeh_Movajehe>? T_Madeh_Movajehe { get; set; }
    public virtual ICollection<T_Map_Locations>? T_Map_Locations { get; set; }
    public virtual ICollection<TTags>? TTags { get; set; }

}

