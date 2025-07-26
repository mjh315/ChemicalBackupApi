using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class KhataratmadehDto : IBackupable
{
    public string? Saratanzayi { get; set; }
    public string? PolimerizasionKhatarnak { get; set; }
    public string? KhataratHad { get; set; }
    public string? KhataratMozmen { get; set; }
    public string? MahsolatSamiSokhtan { get; set; }
    public string? TajziyeKhatarnak { get; set; }
    public string? EghdamatEhtiyati { get; set; }
    public string? SayerKhataratTabagheBandiNashode { get; set; }



    public int IdKhataratmadehApp { get; set; }
    public int TAllmadehIdApp { get; set; }




    public Guid BackupStatusId { get; set; }

}
