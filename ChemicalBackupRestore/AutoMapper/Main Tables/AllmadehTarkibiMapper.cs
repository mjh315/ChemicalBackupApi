public class AllmadehTarkibiMapper : AutoMapperProfile
{
    public AllmadehTarkibiMapper()
    {
        CreateMap<TAllmadehTarkibi, AllmadehTarkibiDto>();
        CreateMap<AllmadehTarkibiDto, TAllmadehTarkibi>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdAllmadehTarkibi, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdAllmadehTarkibiApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}