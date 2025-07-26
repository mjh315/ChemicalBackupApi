
public class AdadEtelatBehdashtiMapper : AutoMapperProfile
{
    public AdadEtelatBehdashtiMapper()
    {
        CreateMap<TLAdadEtelatBehdashti, AdadEtelatBehdashtiDto>();
        CreateMap<AdadEtelatBehdashtiDto, TLAdadEtelatBehdashti>()
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            .ForMember(dest => dest.IdAdadEtelatBehdashti, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdAdadEtelatBehdashtiApp.ToString()));
    }
}