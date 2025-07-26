
public class KhataratKhasMapper : AutoMapperProfile
{
    public KhataratKhasMapper()
    {
        CreateMap<TLKhataratKhas, KhataratKhasDto>();
        CreateMap<KhataratKhasDto, TLKhataratKhas>()
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            .ForMember(dest => dest.IdKhataratKhas, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdKhataratKhasApp.ToString()));
    }
}