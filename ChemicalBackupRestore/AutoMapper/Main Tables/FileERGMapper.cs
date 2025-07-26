public class FileERGMapper : AutoMapperProfile
{
    public FileERGMapper()
    {
        CreateMap<TFileERG, FileERGDto>();
        CreateMap<FileERGDto, TFileERG>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdFileERG, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdFileERGApp.ToString()))
            //foreign keys
            ;
    }
}