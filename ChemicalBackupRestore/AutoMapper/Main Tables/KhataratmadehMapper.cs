public class KhataratmadehMapper : AutoMapperProfile
{
    public KhataratmadehMapper()
    {
        CreateMap<TKhataratmadeh, KhataratmadehDto>();
        CreateMap<KhataratmadehDto, TKhataratmadeh>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdKhataratmadeh, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}