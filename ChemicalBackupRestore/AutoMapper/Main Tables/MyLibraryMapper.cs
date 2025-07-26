// public class MyLibraryMapper : AutoMapperProfile
// {
//     public MyLibraryMapper()
//     {
//             CreateMap<TLMyLibrary, MyLibraryDto>();
//         CreateMap<MyLibraryDto, TLMyLibrary>()
//             .ForMember(dest => dest.id, act => act.MapFrom(src => src.BackupStatusId))
//             .ForMember(dest => dest.ID_Makan, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.ID_MakanApp.ToString()));
//     }
// }