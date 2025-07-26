public class CEIMapper : AutoMapperProfile
{
    public CEIMapper()
    {
        CreateMap<T_CEI, CEIDto>();
        CreateMap<CEIDto, T_CEI>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdCEI, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdCEIApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
    }
}