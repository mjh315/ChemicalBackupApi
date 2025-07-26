using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


public partial class AdadEtalatHarighDto : IBackupable
{

    public int IdAdadEtalatHarighApp { get; set; }
    public string? TitelsAdadEtalatHarigh { get; set; }
    public string? CodeEtalatHarigh { get; set; }

    public Guid BackupStatusId { get; set; }

}

