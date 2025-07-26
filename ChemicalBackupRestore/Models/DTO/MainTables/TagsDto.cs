public class TagsDto : IBackupable
{
    public required string ID_Tag { get; set; }

    public string? Number_Tag { get; set; }
    public DateTime DateCreate { get; set; }
    public bool Active { get; set; }
    public string? Mogheyat_Makan { get; set; }



    public int T_Makan_IDApp { get; set; }
    public int T_Vaheds_IDApp { get; set; }
    public int T_Tajhiz_IDApp { get; set; }
    public int ID_TagApp { get; set; }




    public Guid BackupStatusId { get; set; }
}

