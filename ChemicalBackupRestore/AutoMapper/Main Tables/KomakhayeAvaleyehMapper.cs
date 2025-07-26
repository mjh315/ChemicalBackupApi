public class KomakhayeAvaleyehMapper : AutoMapperProfile
{
    public KomakhayeAvaleyehMapper()
    {
            CreateMap<TKomakhayeAvaleyeh, KomakhayeAvaleyehDto>();
        CreateMap<KomakhayeAvaleyehDto, TKomakhayeAvaleyeh>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdKomakhayeAvaleyeh, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdKomakhayeAvaleyehApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}