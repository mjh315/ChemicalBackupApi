using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class T_Madeh_Movajehe : IBackupable
{
    [Key]
    public required string ID_Madeh_Movajehe { get; set; }







    public int Tedad_Shaghelin { get; set; }
    public int? Modat_Movajehe { get; set; }
    [StringLength(1500)]
    public string? Moshakhasat_PPF { get; set; }
    public bool? Active_PPG_bit { get; set; }
    public DateTime? Date_Create { get; set; }








    public int T_Tajhiz_IDApp { get; set; }
    public int T_Makan_IDApp { get; set; }
    public int TAllmadehIdApp { get; set; }
    public int T_L_Rotbebandi_Movajehe_IDApp { get; set; }
    public int T_OnvanShoghli_IDApp { get; set; }
    public int ID_Madeh_MovajeheApp { get; set; }







    public string? FK_T_Tajhiz_ID { get; set; }
    [ForeignKey("FK_T_Tajhiz_ID")]
    public virtual TTajhiz? T_Tajhiz { get; set; }

    public string? FK_T_Makan_ID { get; set; }
    [ForeignKey("FK_T_Makan_ID")]
    public virtual T_Makan? T_Makan { get; set; }

    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? Allmadeh { get; set; }

    public string? FK_T_L_Rotbebandi_Movajehe_ID { get; set; }
    [ForeignKey("FK_T_L_Rotbebandi_Movajehe_ID")]
    public virtual T_L_Rotbebandi_Movajehe? T_L_Rotbebandi_Movajehe { get; set; }

    public string? FK_T_OnvanShoghli_ID { get; set; }
    [ForeignKey("FK_T_OnvanShoghli_ID")]
    public virtual TOsolkontoroli? T_OnvanShoghli { get; set; }





    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
    
}
