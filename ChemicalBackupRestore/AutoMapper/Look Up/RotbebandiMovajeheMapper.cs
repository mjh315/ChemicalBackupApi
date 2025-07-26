
public class RotbebandiMovajeheMapper : AutoMapperProfile
{
    public RotbebandiMovajeheMapper()
    {
        CreateMap<T_L_Rotbebandi_Movajehe, RotbebandiMovajeheDto>();
        CreateMap<RotbebandiMovajeheDto, T_L_Rotbebandi_Movajehe>()
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            .ForMember(dest => dest.ID_L_Rotbebandi_Movajehe, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_L_Rotbebandi_MovajeheApp.ToString()));
    }
}