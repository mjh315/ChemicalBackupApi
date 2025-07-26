public class TagsMapper : AutoMapperProfile
{
    public TagsMapper()
    {
            CreateMap<TTags, TagsDto>();
        CreateMap<TagsDto, TTags>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_Tag, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_TagApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_T_Makan_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Makan_IDApp.ToString()))
            .ForMember(dest => dest.FK_T_Tajhiz_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Tajhiz_IDApp.ToString()))
            .ForMember(dest => dest.FK_T_Vaheds_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Vaheds_IDApp.ToString()));
    }
}