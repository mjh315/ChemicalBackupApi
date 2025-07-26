public class ArzyabiMapper : AutoMapperProfile
{
    public ArzyabiMapper()
    {
        CreateMap<TArzyabi, ArzyabiDto>();
        CreateMap<ArzyabiDto, TArzyabi>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdArzyabi, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdArzyabiApp.ToString()))
            //foreign keys
            ;
    }
}