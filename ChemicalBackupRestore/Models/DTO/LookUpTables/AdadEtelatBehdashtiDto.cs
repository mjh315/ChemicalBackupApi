using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


public partial class AdadEtelatBehdashtiDto : IBackupable
{
    public int IdAdadEtelatBehdashtiApp { get; set; }
    public string? TitelsAdadEtelatBehdashti { get; set; }
    public string? CodeEtalatBehdashti { get; set; }


    public Guid BackupStatusId { get; set; }
}

