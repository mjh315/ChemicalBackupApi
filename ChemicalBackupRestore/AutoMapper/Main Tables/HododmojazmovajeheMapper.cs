public class HododmojazmovajeheMapper : AutoMapperProfile
{
    public HododmojazmovajeheMapper()
    {
        CreateMap<THododmojazmovajehe, HododmojazmovajeheDto>();
        CreateMap<HododmojazmovajeheDto, THododmojazmovajehe>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdHododmojazmovajehe, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdHododmojazmovajeheApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdHododmojazmovajeheApp.ToString()));
    }
}