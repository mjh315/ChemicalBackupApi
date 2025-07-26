public class EtelatHamlonaghlMapper : AutoMapperProfile
{
    public EtelatHamlonaghlMapper()
    {
            CreateMap<TEtelatHamlonaghl, EtelatHamlonaghlDto>();
        CreateMap<EtelatHamlonaghlDto, TEtelatHamlonaghl>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdEtelatHamlonaghl, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdEtelatHamlonaghlApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}