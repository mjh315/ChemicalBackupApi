public class MavadMapper : AutoMapperProfile
{
    public MavadMapper()
    {
            CreateMap<TMavadTag, MavadTagDto>();
        CreateMap<MavadTagDto, TMavadTag>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.ID_Mavad_Tag, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_Mavad_TagApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_T_Tag_ID, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Tag_IDApp.ToString()))
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.T_Allmadehs_IDApp.ToString()));
    }
}