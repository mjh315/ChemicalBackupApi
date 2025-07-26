public class AllmadehMapper : AutoMapperProfile
{
    public AllmadehMapper()
    {
            CreateMap<TAllmadeh, AllmadehDto>();
        CreateMap<AllmadehDto, TAllmadeh>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdAllmadeh, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdAllmadehApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TLAdadEtalatHarighId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TLAdadEtalatHarighIdApp.ToString()))
            .ForMember(dest => dest.FK_TLAdadEtelatBehdashtiId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TLAdadEtelatBehdashtiIdApp.ToString()))
            .ForMember(dest => dest.FK_TLAdadEtelatVakonoshdehiId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TLAdadEtelatVakonoshdehiIdApp.ToString()))
            .ForMember(dest => dest.FK_TLKhataratKhasId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TLKhataratKhasIdApp.ToString()));
    }
}