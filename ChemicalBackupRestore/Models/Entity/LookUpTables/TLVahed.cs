using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


public partial class TLVahed : IBackupable
{
    [Key]
    public required string IdLVahed { get; set; }
    public int IdLVahedApp { get; set; }
    public required string TiletVahed { get; set; }
    public required string Map_Name_File { get; set; }

    public virtual ICollection<TLMyLibrary>? MyLibrary { get; set; }
    public virtual ICollection<T_Map_Locations>? T_Map_Locations { get; set; }
    public virtual ICollection<T_OnvanShoghli>? T_OnvanShoghli { get; set; }
    public virtual ICollection<TTags>? TTags { get; set; }
    public virtual ICollection<TTajhiz>? TTajhiz { get; set; }
    public Guid BackupStatusId { get; set; }
}

