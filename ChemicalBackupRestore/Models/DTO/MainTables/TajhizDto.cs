public class TajhizDto : IBackupable
{
    public string? Onvan_Tajhiz { get; set; }
    public string? Url { get; set; }
    public string? Onvan { get; set; }
    public DateTime DateCreate { get; set; }
    public bool Active { get; set; }
    public int Tedad_Shaghelin { get; set; }



    public int ID_TajhizApp { get; set; }
    public int T_Vaheds_IDApp { get; set; }



    public Guid BackupStatusId { get; set; }

}

