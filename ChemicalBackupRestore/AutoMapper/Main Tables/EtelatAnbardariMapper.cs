public class EtelatAnbardariMapper : AutoMapperProfile
{
    public EtelatAnbardariMapper()
    {
        CreateMap<TEtelatAnbardari, EtelatAnbardariDto>();
        CreateMap<EtelatAnbardariDto, TEtelatAnbardari>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdEtelatAnbardari, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdEtelatAnbardariApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()))
            ;
    }
}