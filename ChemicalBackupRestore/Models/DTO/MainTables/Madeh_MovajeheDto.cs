public class Madeh_MovajeheDto : IBackupable
{
    public int Tedad_Shaghelin { get; set; }
    public int? Modat_Movajehe { get; set; }
    public string? Moshakhasat_PPF { get; set; }
    public bool? Active_PPG_bit { get; set; }
    public DateTime? Date_Create { get; set; }








    public int T_Tajhiz_IDApp { get; set; }
    public int T_Makan_IDApp { get; set; }
    public int TAllmadehIdApp { get; set; }
    public int T_L_Rotbebandi_Movajehe_IDApp { get; set; }
    public int T_OnvanShoghli_IDApp { get; set; }
    public int ID_Madeh_MovajeheApp { get; set; }


    public Guid BackupStatusId { get; set; }
    
}
