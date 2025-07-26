public class MyLibraryMapper : AutoMapperProfile
{
    public MyLibraryMapper()
    {
            CreateMap<TLMyLibrary, MyLibraryDto>();
        CreateMap<MyLibraryDto, TLMyLibrary>()
        // id backup
            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
            // id primary key
            .ForMember(dest => dest.IdMyLibrary, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdMyLibraryApp.ToString()))
            //foreign keys
            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.FK_TAllmadehIdApp.ToString()))
            .ForMember(dest => dest.FK_TLVahedId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.FK_TLVahedIdApp.ToString()));
    }
}