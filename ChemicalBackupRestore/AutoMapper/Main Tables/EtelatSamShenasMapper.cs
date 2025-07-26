public class EtelatSamShenasMapper : AutoMapperProfile
{
    public EtelatSamShenasMapper()
    {
        CreateMap<TEtelatSamShenas, EtelatSamShenasDto>();
        CreateMap<EtelatSamShenasDto, TEtelatSamShenas>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdEtelatSamShenasi, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}