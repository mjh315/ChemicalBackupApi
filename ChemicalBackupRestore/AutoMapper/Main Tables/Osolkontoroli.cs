public class Osolkontoroli : AutoMapperProfile
{
    public Osolkontoroli()
    {
            CreateMap<TOsolkontoroli, OsolkontoroliDto>();
        CreateMap<OsolkontoroliDto, TOsolkontoroli>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdOsolkontoroli, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdOsolkontoroliApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdOsolkontoroliApp.ToString()));
    }
}