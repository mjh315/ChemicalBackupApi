public class Madeh_MovajeheMapper : AutoMapperProfile
{
    public Madeh_MovajeheMapper()
    {
        CreateMap<T_Madeh_Movajehe, Madeh_MovajeheDto>();
        CreateMap<Madeh_MovajeheDto, T_Madeh_Movajehe>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_Madeh_Movajehe, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_Madeh_MovajeheApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()))
            .ForMember(dest => dest.FK_T_L_Rotbebandi_Movajehe_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_L_Rotbebandi_Movajehe_IDApp.ToString()))
            .ForMember(dest => dest.FK_T_Makan_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Makan_IDApp.ToString()))
            .ForMember(dest => dest.FK_T_OnvanShoghli_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_OnvanShoghli_IDApp.ToString()))
            .ForMember(dest => dest.FK_T_Tajhiz_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Tajhiz_IDApp.ToString()));
    }
}