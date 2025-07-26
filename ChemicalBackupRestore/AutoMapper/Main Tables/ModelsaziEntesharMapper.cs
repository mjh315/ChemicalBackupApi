public class ModelsaziEntesharMapper : AutoMapperProfile
{
    public ModelsaziEntesharMapper()
    {
            CreateMap<TModelsaziEnteshar, ModelsaziEntesharDto>();
        CreateMap<ModelsaziEntesharDto, TModelsaziEnteshar>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdModelsaziEnteshar, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdModelsaziEntesharApp.ToString()));
            //foreign keys;
    }
}