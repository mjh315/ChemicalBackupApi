public class TagMatterMapper : AutoMapperProfile
{
    public TagMatterMapper()
    {
            CreateMap<TTagMatter, TagMatterDto>();
        CreateMap<TagMatterDto, TTagMatter>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_TagMatter, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_TagMatterApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()))
            .ForMember(dest => dest.FK_T_Tag_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Tag_IDApp.ToString()));
    }
}