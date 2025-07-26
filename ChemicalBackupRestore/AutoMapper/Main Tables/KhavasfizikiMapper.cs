public class KhavasfizikiMapper : AutoMapperProfile
{
    public KhavasfizikiMapper()
    {
            CreateMap<TKhavasfiziki, KhavasfizikiDto>();
        CreateMap<KhavasfizikiDto, TKhavasfiziki>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdKhavasfiziki, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdKhavasfizikiApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}