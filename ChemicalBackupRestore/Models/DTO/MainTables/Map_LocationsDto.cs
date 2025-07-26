public class Map_LocationsDto : IBackupable
{

    public int? Left1 { get; set; }

    public int? Top1 { get; set; }

    public int? Width1 { get; set; }

    public int? Height1 { get; set; }
    public int? Point_Left { get; set; }
    public int? Point_Top { get; set; }
    public string? Name_Makan { get; set; }




    public int ID_Map_LocationsApp { get; set; }
    public int T_Tajhiz_IDApp { get; set; }
    public int T_Makan_IDApp { get; set; }
    public int T_Vahed_IdApp { get; set; }



    public Guid BackupStatusId { get; set; }
}

