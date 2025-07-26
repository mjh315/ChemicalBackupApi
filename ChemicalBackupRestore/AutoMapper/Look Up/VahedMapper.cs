
public class VahedMapper : AutoMapperProfile
{
    public VahedMapper()
    {
        CreateMap<TLVahed, VahedDto>();
        CreateMap<VahedDto, TLVahed>()
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            .ForMember(dest => dest.IdLVahed, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdLVahedApp.ToString()));
    }
}