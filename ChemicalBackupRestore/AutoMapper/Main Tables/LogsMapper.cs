public class LogsMapper : AutoMapperProfile
{
    public LogsMapper()
    {
        CreateMap<TLogs, LogsDto>();
        CreateMap<LogsDto, TLogs>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdLog, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdLogApp.ToString()))
            //foreign keys
            ;
    }
}