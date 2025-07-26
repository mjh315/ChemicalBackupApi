public class SarneveshtZistmohitiMapper : AutoMapperProfile
{
    public SarneveshtZistmohitiMapper()
    {
        CreateMap<TSarneveshtZistmohiti, SarneveshtZistmohitiDto>();
        CreateMap<SarneveshtZistmohitiDto, TSarneveshtZistmohiti>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdSarneveshtZistmohiti, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdSarneveshtZistmohitiApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}