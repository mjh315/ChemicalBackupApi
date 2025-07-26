public class MakanMapper : AutoMapperProfile
{
    public MakanMapper()
    {
        CreateMap<T_Makan, MakanDto>();
        CreateMap<MakanDto, T_Makan>()
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            .ForMember(dest => dest.ID_Makan, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_MakanApp.ToString()));
    }
}