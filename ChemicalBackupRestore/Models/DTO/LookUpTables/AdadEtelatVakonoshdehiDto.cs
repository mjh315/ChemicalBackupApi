using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


public partial class AdadEtelatVakonoshdehiDto : IBackupable
{
    public required string IdAdadEtelatVakonoshdehiApp { get; set; }
    public string? TitelsAdadEtelatVakonoshdehi { get; set; }
    public string? CodeEtalatVakonoshdehi { get; set; }


    public Guid BackupStatusId { get; set; }
}

