public class TajhizMapper : AutoMapperProfile
{
    public TajhizMapper()
    {
        CreateMap<TTajhiz, TajhizDto>();
        CreateMap<TajhizDto, TTajhiz>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_Tajhiz, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_TajhizApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_T_Vaheds_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Vaheds_IDApp.ToString()));
    }
}