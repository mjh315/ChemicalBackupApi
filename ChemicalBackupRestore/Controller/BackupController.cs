using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class BackupController : BaseController
{
    private readonly IBackupRepository _backupService;
    public BackupController(IBackupRepository backupService)
    {
        _backupService = backupService;
    }

    // table list: [ Add_Shift_FirefightersEntities, Add_TestEntities,
    // All_TestEntities, ArzyabEntities, Azay_Firefighters_GroupsEntities, 
    // Eghdam_EslahiEntities, Firefighters_GroupsEntities, FirefightersEntities,
    // Arzyab_Post_SazemaniEntities, Daraje_FirefightersEntities,
    // Items_ArzyabiEntities, Level_FirefightersEntities, Noe_TestEntities, 
    // Onvan_Eghdam_EslahiEntities, Post_SazmaniEntities, Sabeghe_KarEntities,
    // Vaziyat_NomrehEntities, SharhTestEntities, ShiftEntities ]


    [HttpGet("GetAllBackups/{id}")]
    public async Task<IActionResult> GetAllBackups(int id)
    {
        return ResponseResult(await _backupService.GetAllBackupsAsync(id));
    }

    [HttpPost("ConfigBackup")]
    public async Task<IActionResult> ConfigBackup(ConfigBackupReqDto request)
    {
        return ResponseResult(await _backupService.ConfigBackupAsync(request));
    }

    [HttpPost("AddTable")]
    public async Task<IActionResult> AddTable([FromBody] AddTableReqDto request)
    {
        return ResponseResult(await _backupService.AddTableAsync(request));
    }

    [HttpPost("GetTable")]
    public async Task<IActionResult> GetTable([FromBody] RequestDataDetails requestDataDetails, string tableName)
    {
        return ResponseResult(await _backupService.GetTableAsync(requestDataDetails, tableName));
    }

}