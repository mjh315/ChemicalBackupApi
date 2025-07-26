using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


public class TFileERG  : IBackupable
{
    [Key]
    public required string IdFileERG { get; set; }
    public int IdFileERGApp { get; set; }
    public string? Url { get; set; }
    public string? Format { get; set; }
    public string? Onvan { get; set; }
    public DateTime? DateCreate { get; set; }
    public string? UserId { get; set; }


    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }
}

