
public class AdadEtelatVakonoshdehiMapper  : AutoMapperProfile
{
    public AdadEtelatVakonoshdehiMapper()
    {
      CreateMap<TLAdadEtelatVakonoshdehi, AdadEtelatVakonoshdehiDto>();
        CreateMap<AdadEtelatVakonoshdehiDto, TLAdadEtelatVakonoshdehi>()
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            .ForMember(dest => dest.IdAdadEtelatVakonoshdehi, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdAdadEtelatVakonoshdehiApp.ToString()));

    }
}