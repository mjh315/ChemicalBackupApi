
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class BackupRepository : IBackupRepository
{
    private readonly DB_Chimi _context;
    private readonly IMapper _mapper;
    private readonly Dictionary<string, TableActionInfo> _tableActions;
    public BackupRepository(DB_Chimi context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
        _tableActions = new Dictionary<string, TableActionInfo>
        {

            // LookUps
            {
                "RotbebandiMovajehe",
                new TableActionInfo (typeof(RotbebandiMovajeheDto),
                typeof(T_L_Rotbebandi_Movajehe),
                async (data, backupId) => await AddEntitiesAsync<RotbebandiMovajeheDto, T_L_Rotbebandi_Movajehe>(data, backupId),
                async (backupId) => await GetEntitiesAsync<T_L_Rotbebandi_Movajehe, RotbebandiMovajeheDto>(backupId))
                },
            {
                "AdadEtalatHarigh",
                new TableActionInfo(typeof(AdadEtalatHarighDto),
                typeof(TLAdadEtalatHarigh),
                AddEntitiesAsync<AdadEtalatHarighDto, TLAdadEtalatHarigh>,
                async (backupId) => await GetEntitiesAsync<TLAdadEtalatHarigh, AdadEtalatHarighDto>(backupId))
            },
            {
                "AdadEtelatVakonoshdehi",
                new TableActionInfo(typeof(AdadEtelatVakonoshdehiDto),
                typeof(TLAdadEtelatVakonoshdehi),
                AddEntitiesAsync<AdadEtelatVakonoshdehiDto, TLAdadEtelatVakonoshdehi>,
                async (backupId) => await GetEntitiesAsync<TLAdadEtelatVakonoshdehi, AdadEtelatVakonoshdehiDto>(backupId))
            },
            {
                "AdadEtelatBehdashti",
                new TableActionInfo(typeof(AdadEtelatBehdashtiDto),
                typeof(TLAdadEtelatBehdashti),
                AddEntitiesAsync<AdadEtelatBehdashtiDto, TLAdadEtelatBehdashti>,
                async (backupId) => await GetEntitiesAsync<TLAdadEtelatBehdashti, AdadEtelatBehdashtiDto>(backupId))
            },
            {
                "KhataratKhas",
                new TableActionInfo(typeof(KhataratKhasDto),
                typeof(TLKhataratKhas),
                AddEntitiesAsync<KhataratKhasDto, TLKhataratKhas>,
                async (backupId) => await GetEntitiesAsync<TLKhataratKhas, KhataratKhasDto>(backupId))
            },
            {
                "Vahed",
                new TableActionInfo(typeof(VahedDto),
                typeof(TLVahed),
                AddEntitiesAsync<VahedDto, TLVahed>,
                async (backupId) => await GetEntitiesAsync<TLVahed, VahedDto>(backupId))
            },







            {
                "Arzyabi",
                new TableActionInfo(typeof(ArzyabiDto),
                typeof(TArzyabi),
                AddEntitiesAsync<ArzyabiDto, TArzyabi>,
                async (backupId) => await GetEntitiesAsync<TArzyabi, ArzyabiDto>(backupId))
            },
            {
                "FileERG",
                new TableActionInfo(typeof(FileERGDto),
                typeof(TFileERG),
                AddEntitiesAsync<FileERGDto, TFileERG>,
                async (backupId) => await GetEntitiesAsync<TFileERG, FileERGDto>(backupId))
            },
            {
                "Logs",
                new TableActionInfo(typeof(LogsDto),
                typeof(TLogs),
                AddEntitiesAsync<LogsDto, TLogs>,
                async (backupId) => await GetEntitiesAsync<TLogs, LogsDto>(backupId))
            },
            {
                "Makan",
                new TableActionInfo(typeof(MakanDto),
                typeof(T_Makan),
                AddEntitiesAsync<MakanDto, T_Makan>,
                async (backupId) => await GetEntitiesAsync<T_Makan, MakanDto>(backupId))
            },
            {
                "ModelsaziEnteshar",
                new TableActionInfo(typeof(ModelsaziEntesharDto),
                typeof(TModelsaziEnteshar),
                AddEntitiesAsync<ModelsaziEntesharDto, TModelsaziEnteshar>,
                async (backupId) => await GetEntitiesAsync<TModelsaziEnteshar, ModelsaziEntesharDto>(backupId))
            },





            {
                "Allmadeh",
                new TableActionInfo(typeof(AllmadehDto),
                typeof(TAllmadeh),
                AddEntitiesAsync<AllmadehDto, TAllmadeh>,
                async (backupId) => await GetEntitiesAsync<TAllmadeh, AllmadehDto>(backupId))
            },



            {
                "MyLibrary",
                new TableActionInfo(typeof(MyLibraryDto),
                typeof(TLMyLibrary),
                AddEntitiesAsync<MyLibraryDto, TLMyLibrary>,
                async (backupId) => await GetEntitiesAsync<TLMyLibrary, MyLibraryDto>(backupId))
            },
            {
                "EghdamatDarmani",
                new TableActionInfo(typeof(EghdamatDarmaniDto),
                typeof(TEghdamatDarmani),
                AddEntitiesAsync<EghdamatDarmaniDto, TEghdamatDarmani>,
                async (backupId) => await GetEntitiesAsync<TEghdamatDarmani, EghdamatDarmaniDto>(backupId))
            },
            {
                "EtelatAnbardari",
                new TableActionInfo(typeof(EtelatAnbardariDto),
                typeof(TEtelatAnbardari),
                AddEntitiesAsync<EtelatAnbardariDto, TEtelatAnbardari>,
                async (backupId) => await GetEntitiesAsync<TEtelatAnbardari, EtelatAnbardariDto>(backupId))
            },
            {
                "EtelatBehdashti",
                new TableActionInfo(typeof(EtelatbehdashtiDto),
                typeof(TEtelatbehdashti),
                AddEntitiesAsync<EtelatbehdashtiDto, TEtelatbehdashti>,
                async (backupId) => await GetEntitiesAsync<TEtelatbehdashti, EtelatbehdashtiDto>(backupId))
            },
            {
                "EtelatHamlonaghl",
                new TableActionInfo(typeof(EtelatHamlonaghlDto),
                typeof(TEtelatHamlonaghl),
                AddEntitiesAsync<EtelatHamlonaghlDto, TEtelatHamlonaghl>,
                async (backupId) => await GetEntitiesAsync<TEtelatHamlonaghl, EtelatHamlonaghlDto>(backupId))
            },
            {
                "EtelatHarigh",
                new TableActionInfo(typeof(EtelatHarighDto),
                typeof(TEtelatHarigh),
                AddEntitiesAsync<EtelatHarighDto, TEtelatHarigh>,
                async (backupId) => await GetEntitiesAsync<TEtelatHarigh, EtelatHarighDto>(backupId))
            },
            {
                "EtelatSamShenas",
                new TableActionInfo(typeof(EtelatSamShenasDto),
                typeof(TEtelatSamShenas),
                AddEntitiesAsync<EtelatSamShenasDto, TEtelatSamShenas>,
                async (backupId) => await GetEntitiesAsync<TEtelatSamShenas, EtelatSamShenasDto>(backupId))
            },
                        {
                "AllmadehTarkibi",
                new TableActionInfo(typeof(AllmadehTarkibiDto),
                typeof(TAllmadehTarkibi),
                AddEntitiesAsync<AllmadehTarkibiDto, TAllmadehTarkibi>,
                async (backupId) => await GetEntitiesAsync<TAllmadehTarkibi, AllmadehTarkibiDto>(backupId))
            },
            {
                "CEI",
                new TableActionInfo(typeof(CEIDto),
                typeof(T_CEI),
                AddEntitiesAsync<CEIDto, T_CEI>,
                async (backupId) => await GetEntitiesAsync<T_CEI, CEIDto>(backupId))
            },
                        {
                "Ghs",
                new TableActionInfo(typeof(GhsDto),
                typeof(TGhs),
                AddEntitiesAsync<GhsDto, TGhs>,
                async (backupId) => await GetEntitiesAsync<TGhs, GhsDto>(backupId))
            },
            {
                "Hododmojazmovajehe",
                new TableActionInfo(typeof(HododmojazmovajeheDto),
                typeof(THododmojazmovajehe),
                AddEntitiesAsync<HododmojazmovajeheDto, THododmojazmovajehe>,
                async (backupId) => await GetEntitiesAsync<THododmojazmovajehe, HododmojazmovajeheDto>(backupId))
            },
            {
                "Khataratmadeh",
                new TableActionInfo(typeof(KhataratmadehDto),
                typeof(TKhataratmadeh),
                AddEntitiesAsync<KhataratmadehDto, TKhataratmadeh>,
                async (backupId) => await GetEntitiesAsync<TKhataratmadeh, KhataratmadehDto>(backupId))
            },
            {
                "Khavasfiziki",
                new TableActionInfo(typeof(KhavasfizikiDto),
                typeof(TKhavasfiziki),
                AddEntitiesAsync<KhavasfizikiDto, TKhavasfiziki>,
                async (backupId) => await GetEntitiesAsync<TKhavasfiziki, KhavasfizikiDto>(backupId))
            },
            {
                "KomakhayeAvaleyeh",
                new TableActionInfo(typeof(KomakhayeAvaleyehDto),
                typeof(TKomakhayeAvaleyeh),
                AddEntitiesAsync<KomakhayeAvaleyehDto, TKomakhayeAvaleyeh>,
                async (backupId) => await GetEntitiesAsync<TKomakhayeAvaleyeh, KomakhayeAvaleyehDto>(backupId))
            },
            {
                "Tajhiz",
                new TableActionInfo(typeof(TajhizDto),
                typeof(TTajhiz),
                AddEntitiesAsync<TajhizDto, TTajhiz>,
                async (backupId) => await GetEntitiesAsync<TTajhiz, TajhizDto>(backupId))
            },
            {
                "Paydarimadeh",
                new TableActionInfo(typeof(PaydarimadehDto),
                typeof(TPaydarimadeh),
                AddEntitiesAsync<PaydarimadehDto, TPaydarimadeh>,
                async (backupId) => await GetEntitiesAsync<TPaydarimadeh, PaydarimadehDto>(backupId))
            },
            {
                "RahnamayeMoayenat",
                new TableActionInfo(typeof(RahnamayeMoayenatDto),
                typeof(TRahnamayeMoayenat),
                AddEntitiesAsync<RahnamayeMoayenatDto, TRahnamayeMoayenat>,
                async (backupId) => await GetEntitiesAsync<TRahnamayeMoayenat, RahnamayeMoayenatDto>(backupId))
            },
            {
                "SarneveshtZistmohiti",
                new TableActionInfo(typeof(SarneveshtZistmohitiDto),
                typeof(TSarneveshtZistmohiti),
                AddEntitiesAsync<SarneveshtZistmohitiDto, TSarneveshtZistmohiti>,
                async (backupId) => await GetEntitiesAsync<TSarneveshtZistmohiti, SarneveshtZistmohitiDto>(backupId))
            },
            {
                "OnvanShoghli",
                new TableActionInfo(typeof(OnvanShoghliDto),
                typeof(T_OnvanShoghli),
                AddEntitiesAsync<OnvanShoghliDto, T_OnvanShoghli>,
                async (backupId) => await GetEntitiesAsync<T_OnvanShoghli, OnvanShoghliDto>(backupId))
            },
            {
                "Osolkontoroli",
                new TableActionInfo(typeof(OsolkontoroliDto),
                typeof(TOsolkontoroli),
                AddEntitiesAsync<OsolkontoroliDto, TOsolkontoroli>,
                async (backupId) => await GetEntitiesAsync<TOsolkontoroli, OsolkontoroliDto>(backupId))
            },
            {
                "TajhizatHefazatfardi",
                new TableActionInfo(typeof(TajhizatHefazatfardiDto),
                typeof(TTajhizatHefazatfardi),
                AddEntitiesAsync<TajhizatHefazatfardiDto, TTajhizatHefazatfardi>,
                async (backupId) => await GetEntitiesAsync<TTajhizatHefazatfardi, TajhizatHefazatfardiDto>(backupId))
            },
            {
                "Sharayetezterari",
                new TableActionInfo(typeof(SharayetezterariDto),
                typeof(TSharayetezterari),
                AddEntitiesAsync<SharayetezterariDto, TSharayetezterari>,
                async (backupId) => await GetEntitiesAsync<TSharayetezterari, SharayetezterariDto>(backupId))
            },
            {
                "Tags",
                new TableActionInfo(typeof(TagsDto),
                typeof(TTags),
                AddEntitiesAsync<TagsDto, TTags>,
                async (backupId) => await GetEntitiesAsync<TTags, TagsDto>(backupId))
            },
            {
                "TagMatter",
                new TableActionInfo(typeof(TagMatterDto),
                typeof(TTagMatter),
                AddEntitiesAsync<TagMatterDto, TTagMatter>,
                async (backupId) => await GetEntitiesAsync<TTagMatter, TagMatterDto>(backupId))
            },
            {
                "Reactivity",
                new TableActionInfo(typeof(ReactivityDto),
                typeof(TReactivity),
                AddEntitiesAsync<ReactivityDto, TReactivity>,
                async (backupId) => await GetEntitiesAsync<TReactivity, ReactivityDto>(backupId))
            },
            {
                "MavadTag",
                new TableActionInfo(typeof(MavadTagDto),
                typeof(TMavadTag),
                AddEntitiesAsync<MavadTagDto, TMavadTag>,
                async (backupId) => await GetEntitiesAsync<TMavadTag, MavadTagDto>(backupId))
            },
            {
                "Map_Locations",
                new TableActionInfo(typeof(Map_LocationsDto),
                typeof(T_Map_Locations),
                AddEntitiesAsync<Map_LocationsDto, T_Map_Locations>,
                async (backupId) => await GetEntitiesAsync<T_Map_Locations, Map_LocationsDto>(backupId))
            },
            {
                "Map_Madeh",
                new TableActionInfo(typeof(Map_MadehDto),
                typeof(T_Map_Madeh),
                AddEntitiesAsync<Map_MadehDto, T_Map_Madeh>,
                async (backupId) => await GetEntitiesAsync<T_Map_Madeh, Map_MadehDto>(backupId))
            },
            {
                "Madeh_Movajehe",
                new TableActionInfo(typeof(Madeh_MovajeheDto),
                typeof(T_Madeh_Movajehe),
                AddEntitiesAsync<Madeh_MovajeheDto, T_Madeh_Movajehe>,
                async (backupId) => await GetEntitiesAsync<T_Madeh_Movajehe, Madeh_MovajeheDto>(backupId))
            }












        };
    }
    #region Name

    private bool CheckBackupStatus(Guid backupId)
    {
        var backup = _context.BackupStatuses.Find(backupId);
        if (backup != null)
        {
            if (backup.Status == "Completed") return true;
        }
        return false;
    }
    private bool BackupDatabaseCompleted(Guid backupId)
    {
        var backup = _context.BackupStatuses.Find(backupId);
        if (backup != null)
        {
            backup.Status = "Completed";
            _context.SaveChanges();
            return true;
        }
        return false;
    }
    public async Task<ApiResponse<Guid>> ConfigBackupAsync(ConfigBackupReqDto request)
    {
        var result = ToCheckListString(request.TableName);
        if (result.IsValid)
        {
            try
            {
                var backup = new BackupStatus
                {
                    IdBackup = Guid.NewGuid(),
                    ListOfTablesBackup = result.Result,
                    Status = "Created",
                    BackupName = request.BackupName,
                    BackupDescription = request.BackupDescription,
                    AdminId = request.AdminId,
                    DateStarted = DateTime.Now
                };
                await _context.BackupStatuses.AddAsync(backup);
                await _context.SaveChangesAsync();

                return ApiResponse<Guid>.Success(backup.IdBackup, "پیکربندی پشتیبانی انجام شد", 200); // 200 به‌جای 500
            }
            catch (Exception ex)
            {
                return ApiResponse<Guid>.Fail(ex.ToString(), 500);
            }
        }
        else
        {
            return ApiResponse<Guid>.Fail("از جداول انتخاب شده نمی‌توان پشتیبانی گرفت: " + result.Result, 400); // 400 به‌جای 500
        }
    }
    // تبدیل لیست نام‌ها به رشته با فرمت "Name: 0" و بررسی صحت نام‌ها با لیست پیش‌فرض
    public static (bool IsValid, string Result) ToCheckListString(List<string> names)
    {
        bool isValid = names.All(name => DefaultNames.Contains(name));
        string result;
        if (isValid)
        {
            result = string.Join(", ", names.Select(name => $"{name}: 0"));
        }
        else
        {
            result = string.Join(", ", names.Where(name => !DefaultNames.Contains(name)).Select(name => $"{name}: 0"));
        }
        return (isValid, result);
    }
    // تبدیل لیست CheckListTableDto به رشته با فرمت "Name: 0/1, ..."
    public string CheckListToString(List<CheckListTableDto> list)
    {
        return string.Join(", ", list.Select(item => $"{item.Name}: {(item.IsComplited ? 1 : 0)}"));
    }
    // تبدیل رشته با فرمت "Name: 0/1, ..." به لیست CheckListTableDto
    public List<CheckListTableDto> StringToCheckList(string input)
    {
        var result = new List<CheckListTableDto>();
        if (string.IsNullOrWhiteSpace(input)) return result;

        var items = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in items)
        {
            var parts = item.Split(": ");
            if (parts.Length == 2 && bool.TryParse(parts[1] == "1" ? "true" : "false", out bool isCompleted))
            {
                result.Add(new CheckListTableDto
                {
                    Name = parts[0],
                    IsComplited = isCompleted
                });
            }
        }
        return result;
    }
    public bool CheckAccess(Guid backupId, string tableName, string action)
    {
        var c = _context.BackupStatuses.FirstOrDefault(b => b.IdBackup == backupId);
        var list = StringToCheckList(c.ListOfTablesBackup);
        if (action == "get")
        {
            return c != null && list.FirstOrDefault(item => item.Name == tableName)?.IsComplited == true && CheckBackupStatus(backupId);
        }
        else if (action == "set")
        {
            var check = CheckBackupStatus(backupId);
            if (c != null && !check && list.FirstOrDefault(item => item.Name == tableName)?.IsComplited == false)
            {
                list.FirstOrDefault(item => item.Name == tableName).IsComplited = true;
                if (list.Last()?.Name == tableName)
                {
                    var backupCompleted = BackupDatabaseCompleted(backupId);
                    return backupCompleted;
                }
                return true;
            }
            return false;
        }
        else
        {
            return false;
        }
    }
    public bool SetStatusTableComplete(Guid backupId, string tableName)
    {
        //var backupCompleted = BackupDatabaseCompleted(backupId);
        var c = _context.BackupStatuses.FirstOrDefault(b => b.IdBackup == backupId);
        var list = StringToCheckList(c.ListOfTablesBackup);
        list.FirstOrDefault(item => item.Name == tableName).IsComplited = true;
        var sList = CheckListToString(list);
        c.ListOfTablesBackup = sList;
        if (list.All(item => item.IsComplited))
        {
            c.Status = "Completed";
            c.DateEnded = DateTime.UtcNow;
        }
        _context.SaveChanges();
        return true;
    }
    public async Task<ApiResponse<object>> GetTableAsync(RequestDataDetails requestDataDetails, string tableName)
    {
        try
        {
            if (!_tableActions.TryGetValue(tableName, out var tableInfo))
                return ApiResponse<object>.Fail("Table not found", 404);

            var c = await _context.BackupStatuses.FirstOrDefaultAsync(a => a.IdBackup == requestDataDetails.BackupId);
            if (!CheckAccess(c.IdBackup, tableName, "get"))
                return ApiResponse<object>.Fail("Access denied", 403);

            var result = await tableInfo.GetAction(requestDataDetails.BackupId);
            return ApiResponse<object>.Success(result, "Entities retrieved successfully", 200);
        }
        catch (Exception ex)
        {
            return ApiResponse<object>.Fail(ex.ToString(), 500);
        }
    }
    private async Task<List<TDto>> GetEntitiesAsync<TEntity, TDto>(Guid backupId)
        where TEntity : class, IBackupable
        where TDto : class
    {
        var entities = await _context.Set<TEntity>()
            .Where(e => e.BackupStatusId == backupId)
            .ToListAsync();
        return _mapper.Map<List<TDto>>(entities);
    }
    private delegate Task<List<string>> AddTableDelegate(List<object> data, Guid backupId);
    private readonly Dictionary<string, AddTableDelegate> _addTableActions;
    private async Task<List<string>> AddEntitiesAsync<TDto, TEntity>(List<object> data, Guid backupId)
        where TEntity : class, IBackupable
        where TDto : IBackupable
    {
        var res = new List<string>();
        var stringList = data.OfType<string>();
        Console.WriteLine("BI HI HI: " + stringList.ToString());

        //var dtos = JsonConverter.DeserializeObject<List<TDto>>(JsonContent.SerializeObject(data));
        var jsonString = JsonConvert.SerializeObject(data);
        Console.WriteLine("َCI HI HI: " + jsonString.ToString());

        // ۲. حالا با اطمینان آن رشته را به لیست DTO مورد نظر تبدیل کن
        var dtos = JsonConvert.DeserializeObject<List<TDto>>(jsonString); Console.WriteLine($"Deserialized DTOs Count: {dtos?.Count}");
        Console.WriteLine("َDI HI HI: " + dtos.ToString());
        foreach (var item in dtos)
        {
            // TEntity entity;
            // entity.BackupStatusId = backupId;
            Console.WriteLine("HI HI HI: " + item.ToString());

            item.BackupStatusId = backupId;
            var entity = _mapper.Map<TEntity>(item);
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            var idProperty = entity.GetType().GetProperties().FirstOrDefault(p => p.Name.StartsWith("ID_"));
            if (idProperty != null)
            {
                res.Add(idProperty.GetValue(entity)?.ToString() ?? "");
            }
        }
        return res;
    }
    public async Task<ApiResponse<List<string>>> AddTableAsync(AddTableReqDto request)
    {
        try
        {
            var c = await _context.BackupStatuses.FirstOrDefaultAsync(a => a.IdBackup == request.BackupId);
            if (c == null || !CheckAccess(c.IdBackup, request.TableName, "set"))
            {
                return ApiResponse<List<string>>.Fail("Access denied", 403);
            }

            if (_tableActions.TryGetValue(request.TableName, out var tableInfo))
            {
                var res = await tableInfo.AddAction(request.RequestData, request.BackupId);
                await _context.SaveChangesAsync();
                SetStatusTableComplete(request.BackupId, request.TableName);
                return ApiResponse<List<string>>.Success(res, "Entities added successfully", 200);
            }

            return ApiResponse<List<string>>.Fail("Table not found", 404);
        }
        catch (Exception ex)
        {
            return ApiResponse<List<string>>.Fail(ex.ToString(), 500);
        }
    }

    public Task<ApiResponse<List<ConfigBackupResDto>>> GetAllBackupsAsync(int id)
    {
        return _context.BackupStatuses.Where(c => c.AdminId == id && c.Status == "Completed")
            .Select(c => new ConfigBackupResDto
            {
                BackupDate = c.DateStarted,
                BackupDescription = c.BackupDescription,
                BackupName = c.BackupName,
                TableName = StringToCheckList(c.ListOfTablesBackup).Select(a => a.Name).ToList(),

            })
            .ToListAsync()
            .ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    return ApiResponse<List<ConfigBackupResDto>>.Fail(task.Exception.ToString(), 500);
                }

                return ApiResponse<List<ConfigBackupResDto>>.Success(task.Result, "Backups retrieved successfully", 200);
            });
    }

    private class TableActionInfo
    {
        public Type TDto { get; }
        public Type TEntity { get; }
        public Func<List<object>, Guid, Task<List<string>>> AddAction { get; }
        public Func<Guid, Task<object>> GetAction { get; }

        public TableActionInfo(
            Type tDto,
            Type tEntity,
            Func<List<object>, Guid, Task<List<string>>> addAction,
            Func<Guid, Task<object>> getAction)
        {
            TDto = tDto;
            TEntity = tEntity;
            AddAction = addAction;
            GetAction = getAction;
        }
    }
    #endregion
    private static readonly List<string> DefaultNames = new List<string>
        {
        "RotbebandiMovajehe",
        "AdadEtalatHarigh",
        "AdadEtelatVakonoshdehi",
        "AdadEtelatBehdashti",
        "KhataratKhas",
        "Vahed",
        "Arzyabi",
        "FileERG",
        "Logs",
        "Makan",
        "ModelsaziEnteshar",
        "Allmadeh",
        "MyLibrary",
        "EghdamatDarmani",
        "EtelatAnbardari",
        "EtelatBehdashti",
        "EtelatHamlonaghl",
        "EtelatHarigh",
        "EtelatSamShenas",
        "AllmadehTarkibi",
        "CEI",
        "Ghs",
        "Hododmojazmovajehe",
        "Khataratmadeh",
        "Khavasfiziki",
        "KomakhayeAvaleyeh",
        "Tajhiz",
        "Paydarimadeh",
        "RahnamayeMoayenat",
        "SarneveshtZistmohiti",
        "OnvanShoghli",
        "Osolkontoroli",
        "TajhizatHefazatfardi",
        "Sharayetezterari",
        "Tags",
        "TagMatter",
        "Reactivity",
        "MavadTag",
        "Map_Locations",
        "Map_Madeh",
        "Madeh_Movajehe"
        };
}


