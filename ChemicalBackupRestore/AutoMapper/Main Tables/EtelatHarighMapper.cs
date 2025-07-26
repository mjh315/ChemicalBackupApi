public class EtelatHarighMapper : AutoMapperProfile
{
    public EtelatHarighMapper()
    {
            CreateMap<TEtelatHarigh, EtelatHarighDto>();
        CreateMap<EtelatHarighDto, TEtelatHarigh>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdEtelatHarigh, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}