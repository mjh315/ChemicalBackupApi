public class MyLibraryDto : IBackupable
{
    public string? UserId { get; set; }
    public string? Kammiat { get; set; }
    public string? MakanOrTajhiz { get; set; }



    public int IdMyLibraryApp { get; set; }
    public int FK_TLVahedIdApp { get; set; }
    public int FK_TAllmadehIdApp { get; set; }

    
    public Guid BackupStatusId { get; set; }
}

