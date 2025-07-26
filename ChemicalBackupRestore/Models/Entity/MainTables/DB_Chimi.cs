using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ChangeTracking;

public class DB_Chimi : DbContext
{
    public DB_Chimi(DbContextOptions dbContextOptions)
    : base(dbContextOptions)
    {

    }
    public DbSet<BackupStatus> BackupStatuses { get; set; }
    public DbSet<TAllmadeh> Allmadehs { get; set; }
    public DbSet<TEghdamatDarmani> EghdamatDarmanis { get; set; }
    public DbSet<TEtelatAnbardari> EtelatAnbardaris { get; set; }
    public DbSet<TEtelatbehdashti> Etelatbehdashtis { get; set; }
    public DbSet<TEtelatHamlonaghl> EtelatHamlonaghls { get; set; }
    public DbSet<TEtelatHarigh> EtelatHarighs { get; set; }
    public DbSet<TEtelatSamShenas> EtelatSamShenas { get; set; }
    public DbSet<TGhs> Ghs { get; set; }
    public DbSet<TLogs> Log { get; set; }
    public DbSet<THododmojazmovajehe> Hododmojazmovajehes { get; set; }
    public DbSet<TKhataratmadeh> Khataratmadehs { get; set; }
    public DbSet<TKhavasfiziki> Khavasfizikis { get; set; }
    public DbSet<TKomakhayeAvaleyeh> KomakhayeAvaleyehs { get; set; }
    public DbSet<TLAdadEtalatHarigh> AdadEtalatHarighs { get; set; }
    public DbSet<TLAdadEtelatBehdashti> AdadEtelatBehdashtis { get; set; }
    public DbSet<TLAdadEtelatVakonoshdehi> AdadEtelatVakonoshdehis { get; set; }
    public DbSet<TLKhataratKhas> KhataratKhases { get; set; }
    public DbSet<TOsolkontoroli> Osolkontorolis { get; set; }
    public DbSet<TPaydarimadeh> Paydarimadehs { get; set; }
    public DbSet<TSarneveshtZistmohiti> SarneveshtZistmohitis { get; set; }
    public DbSet<TSharayetezterari> Sharayetezteraris { get; set; }
    public DbSet<T_Map_Locations> T_Map_Locations { get; set; }
    public DbSet<T_Map_Madeh> T_Map_Madeh { get; set; }
    public DbSet<TTajhizatHefazatfardi> TajhizatHefazatfardis { get; set; }
    public DbSet<T_Makan> T_Makan { get; set; }
    public DbSet<T_CEI> CEIs { get; set; }
    public DbSet<TLVahed> Vaheds { get; set; }
    public DbSet<TLMyLibrary> MyLibraries { get; set; }
    public DbSet<TReactivity> Reactivities { get; set; }
    public DbSet<TFileERG> FileERGs { get; set; }
    public DbSet<TRahnamayeMoayenat> RahnamayeMoayenats { get; set; }
    public DbSet<TModelsaziEnteshar> ModelsaziEnteshars { get; set; }
    public DbSet<TArzyabi> Arzyabis { get; set; }
    public DbSet<T_L_Rotbebandi_Movajehe> T_L_Rotbebandi_Movajehe { get; set; }
    public DbSet<T_Madeh_Movajehe> T_Madeh_Movajehe { get; set; }
    public DbSet<TAllmadehTarkibi> TAllmadehTarkibi { get; set; }
    public DbSet<TTags> T_Tag { get; set; }
    public DbSet<TTajhiz> T_Tajhiz { get; set; }
    public DbSet<TMavadTag> T_Mavad_Tag { get; set; }
    public DbSet<TTagMatter> T_Tag_Matters { get; set; }
    public DbSet<T_OnvanShoghli> T_OnvanShoghli { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

    }
    public class ArrayConverter : ValueConverter<double[], string>
    {
        public ArrayConverter()
            : base(x => string.Join(";", x), x => x.Split(";", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray())
        {
        }
    }

    public class ArrayComparer : ValueComparer<double[]>
    {
        public ArrayComparer()
            : base((c1, c2) => c1.SequenceEqual(c2), c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), c => c.ToArray())
        {
        }
    }
}
