public class SharayetezterariMapper : AutoMapperProfile
{
    public SharayetezterariMapper()
    {
            CreateMap<TSharayetezterari, SharayetezterariDto>();
        CreateMap<SharayetezterariDto, TSharayetezterari>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdSharayetezterari, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdSharayetezterariApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}