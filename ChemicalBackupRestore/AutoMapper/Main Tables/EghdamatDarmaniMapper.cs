public class EghdamatDarmaniMapper : AutoMapperProfile
{
    public EghdamatDarmaniMapper()
    {
        CreateMap<TEghdamatDarmani, EghdamatDarmaniDto>();
        CreateMap<EghdamatDarmaniDto, TEghdamatDarmani>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdEghdamatDarmani, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdEghdamatDarmaniApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdEghdamatDarmaniApp.ToString()));
    }
}