public class TajhizatHefazatfardiMapper : AutoMapperProfile
{
    public TajhizatHefazatfardiMapper()
    {
            CreateMap<TTajhizatHefazatfardi, TajhizatHefazatfardiDto>();
        CreateMap<TajhizatHefazatfardiDto, TTajhizatHefazatfardi>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdTajhizatHefazatfardi, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdTajhizatHefazatfardiApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdTajhizatHefazatfardiApp.ToString()));
    }
}