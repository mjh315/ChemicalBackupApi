public class GhsMapper : AutoMapperProfile
{
    public GhsMapper()
    {
        CreateMap<TGhs, GhsDto>();
        CreateMap<GhsDto, TGhs>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdGhs, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdGhsApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}