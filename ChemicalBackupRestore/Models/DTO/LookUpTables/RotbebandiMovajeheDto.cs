using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public partial class RotbebandiMovajeheDto : IBackupable
{
    public int ID_L_Rotbebandi_MovajeheApp { get; set; }
    public string? Titels_Rotbebandi_Movajehe { get; set; }
    public bool? Active_bit { get; set; }

    public Guid BackupStatusId { get; set; }
}

