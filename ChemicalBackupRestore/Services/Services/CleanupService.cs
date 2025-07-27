using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

public class CleanupService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly TimeSpan _interval = TimeSpan.FromMinutes(5); // بررسی هر 5 دقیقه

    public CleanupService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<DB_Chimi>();
                    var cutoffTime = DateTime.UtcNow.AddMinutes(-30); // 30 دقیقه قبل

                    // حذف ردیف‌هایی که بیش از 30 دقیقه از ایجادشان گذشته
                    var backup = await context.BackupStatuses
                        .Where(e => e.DateStarted < cutoffTime && e.Status != "Completed")
                        .ToListAsync(stoppingToken);

                    if (backup.Any())
                    {
                        foreach (var record in backup)
                        {
                            List<CheckListTableDto> ListOfTables = StringToCheckList(record.ListOfTablesBackup);
                            foreach (var table in ListOfTables)
                            {
                                switch (table.Name)
                                {
                                    // TL tables
                                    case "RotbebandiMovajehe":
                                        var recs = context.T_L_Rotbebandi_Movajehe.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_L_Rotbebandi_Movajehe.RemoveRange(recs);
                                        break;
                                    case "AdadEtalatHarigh":
                                        var adadEtalatHarighRecs = context.AdadEtalatHarighs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.AdadEtalatHarighs.RemoveRange(adadEtalatHarighRecs);
                                        break;
                                    case "AdadEtelatVakonoshdehi":
                                        var adadEtelatVakonoshdehiRecs = context.AdadEtelatVakonoshdehis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.AdadEtelatVakonoshdehis.RemoveRange(adadEtelatVakonoshdehiRecs);
                                        break;
                                    case "AdadEtelatBehdashti":
                                        var adadEtelatBehdashtiRecs = context.AdadEtelatBehdashtis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.AdadEtelatBehdashtis.RemoveRange(adadEtelatBehdashtiRecs);
                                        break;
                                    case "KhataratKhas":
                                        var khataratKhasRecs = context.KhataratKhases.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.KhataratKhases.RemoveRange(khataratKhasRecs);
                                        break;
                                    case "Vahed":
                                        var vahedRecs = context.Vaheds.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Vaheds.RemoveRange(vahedRecs);
                                        break;
                                    case "Arzyabi":
                                        var arzyabiRecs = context.Arzyabis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Arzyabis.RemoveRange(arzyabiRecs);
                                        break;
                                    case "FileERG":
                                        var fileERGRecs = context.FileERGs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.FileERGs.RemoveRange(fileERGRecs);
                                        break;
                                    case "Logs":
                                        var logsRecs = context.Log.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Log.RemoveRange(logsRecs);
                                        break;
                                    case "Makan":
                                        var makanRecs = context.T_Makan.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Makan.RemoveRange(makanRecs);
                                        break;
                                    case "ModelsaziEnteshar":
                                        var modelsaziEntesharRecs = context.ModelsaziEnteshars.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.ModelsaziEnteshars.RemoveRange(modelsaziEntesharRecs);
                                        break;
                                    case "Allmadeh":
                                        var allmadehRecs = context.Allmadehs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Allmadehs.RemoveRange(allmadehRecs);
                                        break;
                                    case "MyLibrary":
                                        var myLibraryRecs = context.MyLibraries.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.MyLibraries.RemoveRange(myLibraryRecs);
                                        break;
                                    case "EghdamatDarmani":
                                        var eghdamatDarmaniRecs = context.EghdamatDarmanis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.EghdamatDarmanis.RemoveRange(eghdamatDarmaniRecs);
                                        break;
                                    case "EtelatAnbardari":
                                        var etelatAnbardariRecs = context.EtelatAnbardaris.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.EtelatAnbardaris.RemoveRange(etelatAnbardariRecs);
                                        break;
                                    case "EtelatBehdashti":
                                        var etelatBehdashtiRecs = context.Etelatbehdashtis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Etelatbehdashtis.RemoveRange(etelatBehdashtiRecs);
                                        break;
                                    case "EtelatHamlonaghl":
                                        var etelatHamlonaghlRecs = context.EtelatHamlonaghls.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.EtelatHamlonaghls.RemoveRange(etelatHamlonaghlRecs);
                                        break;
                                    case "EtelatHarigh":
                                        var etelatHarighRecs = context.EtelatHarighs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.EtelatHarighs.RemoveRange(etelatHarighRecs);
                                        break;
                                    case "EtelatSamShenas":
                                        var etelatSamShenasRecs = context.EtelatSamShenas.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.EtelatSamShenas.RemoveRange(etelatSamShenasRecs);
                                        break;
                                    case "AllmadehTarkibi":
                                        var allmadehTarkibiRecs = context.TAllmadehTarkibi.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.TAllmadehTarkibi.RemoveRange(allmadehTarkibiRecs);
                                        break;
                                    case "CEI":
                                        var ceiRecs = context.CEIs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.CEIs.RemoveRange(ceiRecs);
                                        break;
                                    case "Ghs":
                                        var ghsRecs = context.Ghs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Ghs.RemoveRange(ghsRecs);
                                        break;
                                    case "Hododmojazmovajehe":
                                        var hododmojazmovajeheRecs = context.Hododmojazmovajehes.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Hododmojazmovajehes.RemoveRange(hododmojazmovajeheRecs);
                                        break;
                                    case "Khataratmadeh":
                                        var khataratmadehRecs = context.Khataratmadehs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Khataratmadehs.RemoveRange(khataratmadehRecs);
                                        break;
                                    case "Khavasfiziki":
                                        var khavasfizikiRecs = context.Khavasfizikis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Khavasfizikis.RemoveRange(khavasfizikiRecs);
                                        break;
                                    case "KomakhayeAvaleyeh":
                                        var komakhayeAvaleyehRecs = context.KomakhayeAvaleyehs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.KomakhayeAvaleyehs.RemoveRange(komakhayeAvaleyehRecs);
                                        break;
                                    case "Tajhiz":
                                        var tajhizRecs = context.T_Tajhiz.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Tajhiz.RemoveRange(tajhizRecs);
                                        break;
                                    case "Paydarimadeh":
                                        var paydarimadehRecs = context.Paydarimadehs.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Paydarimadehs.RemoveRange(paydarimadehRecs);
                                        break;
                                    case "RahnamayeMoayenat":
                                        var rahnamayeMoayenatRecs = context.RahnamayeMoayenats.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.RahnamayeMoayenats.RemoveRange(rahnamayeMoayenatRecs);
                                        break;
                                    case "SarneveshtZistmohiti":
                                        var sarneveshtZistmohitiRecs = context.SarneveshtZistmohitis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.SarneveshtZistmohitis.RemoveRange(sarneveshtZistmohitiRecs);
                                        break;
                                    case "OnvanShoghli":
                                        var onvanShoghliRecs = context.T_OnvanShoghli.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_OnvanShoghli.RemoveRange(onvanShoghliRecs);
                                        break;
                                    case "Osolkontoroli":
                                        var osolkontoroliRecs = context.Osolkontorolis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Osolkontorolis.RemoveRange(osolkontoroliRecs);
                                        break;
                                    case "TajhizatHefazatfardi":
                                        var tajhizatHefazatfardiRecs = context.TajhizatHefazatfardis.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.TajhizatHefazatfardis.RemoveRange(tajhizatHefazatfardiRecs);
                                        break;
                                    case "Sharayetezterari":
                                        var sharayetezterariRecs = context.Sharayetezteraris.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Sharayetezteraris.RemoveRange(sharayetezterariRecs);
                                        break;
                                    case "Tags":
                                        var tagsRecs = context.T_Tag.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Tag.RemoveRange(tagsRecs);
                                        break;
                                    case "TagMatter":
                                        var tagMatterRecs = context.T_Tag_Matters.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Tag_Matters.RemoveRange(tagMatterRecs);
                                        break;
                                    case "Reactivity":
                                        var reactivityRecs = context.Reactivities.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.Reactivities.RemoveRange(reactivityRecs);
                                        break;
                                    case "MavadTag":
                                        var mavadTagRecs = context.T_Mavad_Tag.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Mavad_Tag.RemoveRange(mavadTagRecs);
                                        break;
                                    case "Map_Locations":
                                        var mapLocationsRecs = context.T_Map_Locations.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Map_Locations.RemoveRange(mapLocationsRecs);
                                        break;
                                    case "Map_Madeh":
                                        var mapMadehRecs = context.T_Map_Madeh.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Map_Madeh.RemoveRange(mapMadehRecs);
                                        break;
                                    case "Madeh_Movajehe":
                                        var madehMovajeheRecs = context.T_Madeh_Movajehe.Where(i => i.BackupStatusId == record.IdBackup);
                                        context.T_Madeh_Movajehe.RemoveRange(madehMovajeheRecs);
                                        break;
                                }
                            }

                        }
                        context.BackupStatuses.RemoveRange(backup);
                        await context.SaveChangesAsync(stoppingToken);
                    }
                }
            }
            catch (Exception ex)
            {
                // لاگ خطا (اختیاری)
                Console.WriteLine($"Error in CleanupService: {ex.Message}");
            }

            // انتظار تا بررسی بعدی
            await Task.Delay(_interval, stoppingToken);
        }
    }

    public void DeleteTable(string contexts)
    {

    }

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
}

