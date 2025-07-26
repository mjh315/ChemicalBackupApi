public class Map_LocationsMapper : AutoMapperProfile
{
    public Map_LocationsMapper()
    {
        CreateMap<T_Map_Locations, Map_LocationsDto>();
        CreateMap<Map_LocationsDto, T_Map_Locations>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_Map_Locations, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_Map_LocationsApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_T_Makan_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Makan_IDApp.ToString()))
            .ForMember(dest => dest.FK_T_Tajhiz_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Tajhiz_IDApp.ToString()))
            .ForMember(dest => dest.FK_T_Vahed_Id, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Vahed_IdApp.ToString()));
    }
}