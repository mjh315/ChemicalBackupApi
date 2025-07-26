public class Map_MadehMapper : AutoMapperProfile
{
    public Map_MadehMapper()
    {
            CreateMap<T_Map_Madeh, Map_MadehDto>();
        CreateMap<Map_MadehDto, T_Map_Madeh>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_Map_Madeh, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_Map_MadehApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}