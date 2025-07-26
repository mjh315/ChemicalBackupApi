public class PaydarimadehMapper : AutoMapperProfile
{
    public PaydarimadehMapper()
    {
        CreateMap<TPaydarimadeh, PaydarimadehDto>();
        CreateMap<PaydarimadehDto, TPaydarimadeh>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdPaydarimadeh, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}