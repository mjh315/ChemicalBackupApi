using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


public partial class KhataratKhasDto : IBackupable
{
    public int IdKhataratKhasApp { get; set; }

    public string? TitelsKhataratKhas { get; set; }
    public string? CodeKhataratKhas { get; set; }


    public Guid BackupStatusId { get; set; }
}

