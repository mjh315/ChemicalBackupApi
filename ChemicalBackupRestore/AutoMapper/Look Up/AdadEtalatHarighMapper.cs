
public class AdadEtalatHarighMapper : AutoMapperProfile
{
    public AdadEtalatHarighMapper()
    {
        CreateMap<TLAdadEtalatHarigh, AdadEtalatHarighDto>();
        CreateMap<AdadEtalatHarighDto, TLAdadEtalatHarigh>()
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            .ForMember(dest => dest.IdAdadEtalatHarigh,
            act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdAdadEtalatHarighApp.ToString()));
    }
}