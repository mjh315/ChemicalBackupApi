
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class T_OnvanShoghli : IBackupable
{


    [Key]
    public required string ID_OnvanShoghli { get; set; }


    [StringLength(500)]
    public string? Onvan_Shoghli { get; set; }

    [StringLength(1900)]
    public string? Sharhe_Shoghli { get; set; }





    public int ID_OnvanShoghliApp { get; set; }
    public int T_Vaheds_ID { get; set; }






    public string? FK_T_Vaheds_ID { get; set; }
    [ForeignKey("FK_T_Vaheds_ID")]
    public virtual TLVahed? T_L_Vahed { get; set; }

    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

    public virtual ICollection<T_Madeh_Movajehe>? T_Madeh_Movajehe { get; set; }
}


