public class EtelatbehdashtiMapper : AutoMapperProfile
{
    public EtelatbehdashtiMapper()
    {
        CreateMap<TEtelatbehdashti, EtelatbehdashtiDto>();
        CreateMap<EtelatbehdashtiDto, TEtelatbehdashti>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdEtelatbehdashti, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdEtelatbehdashtiApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}