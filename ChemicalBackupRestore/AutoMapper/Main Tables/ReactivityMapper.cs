public class ReactivityMapper : AutoMapperProfile
{
    public ReactivityMapper()
    {
        CreateMap<TReactivity, ReactivityDto>();
        CreateMap<ReactivityDto, TReactivity>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdReactivity, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdReactivityApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}