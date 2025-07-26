using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class T_Map_Locations : IBackupable
{
    [Key]
    public required string ID_Map_Locations { get; set; }

    public int? Left1 { get; set; }

    public int? Top1 { get; set; }

    public int? Width1 { get; set; }

    public int? Height1 { get; set; }
    public int? Point_Left { get; set; }
    public int? Point_Top { get; set; }

    [StringLength(250)]
    public string? Name_Makan { get; set; }




    public int ID_Map_LocationsApp { get; set; }
    public int T_Tajhiz_ID { get; set; }
    public int T_Makan_ID { get; set; }
    public int T_Vahed_Id { get; set; }




    public string? FK_T_Makan_ID { get; set; }
    [ForeignKey("FK_T_Makan_ID")]
    public virtual T_Makan? T_Makan { get; set; }



    public string? FK_T_Tajhiz_ID { get; set; }
    [ForeignKey("FK_T_Tajhiz_ID")]
    public virtual TTajhiz? T_Tajhiz { get; set; }



    public string? FK_T_Vahed_Id { get; set; }
    [ForeignKey("FK_T_Vahed_Id")]
    public virtual TLVahed? TLVahed { get; set; }



    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

    public virtual ICollection<T_Map_Madeh>? T_Map_Madeh { get; set; }
}

