public class Map_MadehDto : IBackupable
{
    public int ID_Map_MadehApp { get; set; }
    public int? T_Map_Locations_IDApp { get; set; }
    public int TAllmadehIdApp { get; set; }
    public Guid BackupStatusId { get; set; }

}
