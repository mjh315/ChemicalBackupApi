using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class HododmojazmovajeheDto : IBackupable
{
    public required string IdHododmojazmovajehe { get; set; }



    public string? TlvTwa { get; set; }
    public double TlvTwaNum { get; set; }
    public string? TlvStel { get; set; }
    public double TlvStelNum { get; set; }
    public string? TlvC { get; set; }
    public string? OelTwa { get; set; }
    public string? OelStel { get; set; }
    public string? OelC { get; set; }
    public string? Pel { get; set; }
    public string? LimitBase { get; set; }





    public int TAllmadehIdApp { get; set; }
    public int IdHododmojazmovajeheApp { get; set; }



    public Guid BackupStatusId { get; set; }
}

