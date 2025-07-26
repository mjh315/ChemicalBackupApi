public class RahnamayeMoayenatMapper : AutoMapperProfile
{
    public RahnamayeMoayenatMapper()
    {
            CreateMap<TRahnamayeMoayenat, RahnamayeMoayenatDto>();
        CreateMap<RahnamayeMoayenatDto, TRahnamayeMoayenat>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdRahnamayeMoayenat, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdRahnamayeMoayenatApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}