public class OnvanShoghliMapper : AutoMapperProfile
{
    public OnvanShoghliMapper()
    {
            CreateMap<T_OnvanShoghli, OnvanShoghliDto>();
        CreateMap<OnvanShoghliDto, T_OnvanShoghli>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_OnvanShoghli, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_OnvanShoghliApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_T_Vaheds_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Vaheds_ID.ToString()));
    }
}