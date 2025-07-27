using BazresiApi.DTO;

public interface IBackupRepository
{
    Task<ApiResponse<List<ConfigBackupResDto>>> GetAllBackupsAsync(int id);
    Task<ApiResponse<List<string>>> AddTableAsync(AddTableReqDto request);
    Task<ApiResponse<Guid>> ConfigBackupAsync(ConfigBackupReqDto request);
    string CheckListToString(List<CheckListTableDto> list);
    List<CheckListTableDto> StringToCheckList(string input);
    Task<ApiResponse<object>> GetTableAsync(RequestDataDetails requestDataDetails, string tableName);

}
