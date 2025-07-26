using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public class TTags : IBackupable
{

    [Key]
    public required string ID_Tag { get; set; }

    [MaxLength(150)]
    public string? Number_Tag { get; set; }
    public DateTime DateCreate { get; set; }
    public bool Active { get; set; }
    [StringLength(500)]
    public string? Mogheyat_Makan { get; set; }



    public int T_Makan_IDApp { get; set; }
    public int T_Vaheds_IDApp { get; set; }
    public int T_Tajhiz_IDApp { get; set; }
    public int ID_TagApp { get; set; }



    public string? FK_T_Makan_ID { get; set; }
    [ForeignKey("FK_T_Makan_ID")]
    public virtual T_Makan? T_Makan { get; set; }


    public string? FK_T_Vaheds_ID { get; set; }
    [ForeignKey("FK_T_Vaheds_ID")]
    public virtual TLVahed? T_Vaheds { get; set; }


    public string? FK_T_Tajhiz_ID { get; set; }
    [ForeignKey("FK_T_Vaheds_ID")]
    public virtual TTajhiz? T_Tajhiz { get; set; }


    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }}

