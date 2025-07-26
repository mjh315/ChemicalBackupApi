using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

public class TLMyLibrary : IBackupable
{
    [Key]
    public required string IdMyLibrary { get; set; }
    [StringLength(450)]
    public string? UserId { get; set; }
    public string? Kammiat { get; set; }
    public string? MakanOrTajhiz { get; set; }





    public int IdMyLibraryApp { get; set; }
    public int TAllmadehIdApp { get; set; }
    public int TLVahedIdApp { get; set; }



    public Guid BackupStatusId { get; set; }
    [ForeignKey("BackupStatusId")]
    public virtual BackupStatus? BackupStatus { get; set; }

    // navigation
    public string? FK_TAllmadehId { get; set; }
    [ForeignKey("FK_TAllmadehId")]
    public virtual TAllmadeh? TAllmadeh { get; set; }


    public string? FK_TLVahedId { get; set; }
    [ForeignKey("FK_TLVahedId")]
    public virtual TLVahed? TLVahed { get; set; }
}

