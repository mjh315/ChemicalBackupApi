public class ReactivityDto : IBackupable
{
    public int TAllmadeh1Id { get; set; }
    public int TAllmadeh2Id { get; set; }
    public string? Vakonesh { get; set; }
    public string? HazardPredictions { get; set; }
    public string? GasPrediction { get; set; }



    public int IdReactivityApp { get; set; }
    public int TAllmadehIdApp { get; set; }


    public Guid BackupStatusId { get; set; }
}

