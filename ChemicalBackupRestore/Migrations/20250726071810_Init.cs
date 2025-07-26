using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemicalBackupRestore.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackupStatuses",
                columns: table => new
                {
                    IdBackup = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    ListOfTablesBackup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackupDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackupStatuses", x => x.IdBackup);
                });

            migrationBuilder.CreateTable(
                name: "AdadEtalatHarighs",
                columns: table => new
                {
                    IdAdadEtalatHarigh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdAdadEtalatHarighApp = table.Column<int>(type: "int", nullable: false),
                    TitelsAdadEtalatHarigh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeEtalatHarigh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdadEtalatHarighs", x => x.IdAdadEtalatHarigh);
                    table.ForeignKey(
                        name: "FK_AdadEtalatHarighs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdadEtelatBehdashtis",
                columns: table => new
                {
                    IdAdadEtelatBehdashti = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdAdadEtelatBehdashtiApp = table.Column<int>(type: "int", nullable: false),
                    TitelsAdadEtelatBehdashti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeEtalatBehdashti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdadEtelatBehdashtis", x => x.IdAdadEtelatBehdashti);
                    table.ForeignKey(
                        name: "FK_AdadEtelatBehdashtis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdadEtelatVakonoshdehis",
                columns: table => new
                {
                    IdAdadEtelatVakonoshdehi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdAdadEtelatVakonoshdehiApp = table.Column<int>(type: "int", nullable: false),
                    TitelsAdadEtelatVakonoshdehi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeEtalatVakonoshdehi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdadEtelatVakonoshdehis", x => x.IdAdadEtelatVakonoshdehi);
                    table.ForeignKey(
                        name: "FK_AdadEtelatVakonoshdehis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arzyabis",
                columns: table => new
                {
                    IdArzyabi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SathRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnvaneShoghli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCraeted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Matter1 = table.Column<int>(type: "int", nullable: false),
                    DarajeKhatar_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_MizanMovajehe_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_TLV_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_MianginZaman_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_TedadDafaat_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_MizanMadeEstefade_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_NesbatBeTLV_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_ModatKarHafte_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_EghdanatControlli_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_FesharBokhar_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_AndazeZarat_Matter1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Matter2 = table.Column<int>(type: "int", nullable: false),
                    DarajeKhatar_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_MizanMovajehe_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_TLV_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_MianginZaman_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_TedadDafaat_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_MizanMadeEstefade_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_NesbatBeTLV_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_ModatKarHafte_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_EghdanatControlli_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_FesharBokhar_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_AndazeZarat_Matter2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Matter3 = table.Column<int>(type: "int", nullable: false),
                    Name_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DarajeKhatar_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_MizanMovajehe_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_TLV_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_MianginZaman_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M_TedadDafaat_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_MizanMadeEstefade_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_NesbatBeTLV_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_ModatKarHafte_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_EghdanatControlli_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_FesharBokhar_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    N_AndazeZarat_Matter3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaatKarDarHafte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatijeNahaei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vahed = table.Column<int>(type: "int", nullable: false),
                    Tarikh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Onvane = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arzyab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdArzyabiApp = table.Column<int>(type: "int", nullable: false),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arzyabis", x => x.IdArzyabi);
                    table.ForeignKey(
                        name: "FK_Arzyabis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileERGs",
                columns: table => new
                {
                    IdFileERG = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdFileERGApp = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Onvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileERGs", x => x.IdFileERG);
                    table.ForeignKey(
                        name: "FK_FileERGs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhataratKhases",
                columns: table => new
                {
                    IdKhataratKhas = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhataratKhasApp = table.Column<int>(type: "int", nullable: false),
                    TitelsKhataratKhas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeKhataratKhas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhataratKhases", x => x.IdKhataratKhas);
                    table.ForeignKey(
                        name: "FK_KhataratKhases_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    IdLog = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLogApp = table.Column<int>(type: "int", nullable: false),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.IdLog);
                    table.ForeignKey(
                        name: "FK_Log_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelsaziEnteshars",
                columns: table => new
                {
                    IdModelsaziEnteshar = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCraeted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DansitehBokhar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoghteJoosh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FesharBokharMaye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GarmayeTabkhir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GarmayeSokhtan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERPG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERPG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERPG3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TlvTwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TlvStel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TlvC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lc50 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ld50 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCEI = table.Column<double>(type: "float", nullable: false),
                    Zarf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HalatRahayeshMade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAllmadehId = table.Column<int>(type: "int", nullable: false),
                    QotrLole = table.Column<double>(type: "float", nullable: false),
                    QotrParegi = table.Column<double>(type: "float", nullable: false),
                    MotaselBeZarf = table.Column<double>(type: "float", nullable: false),
                    OnvaneSenario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vahed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tajhiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShomareTajhiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeghdarKolMade = table.Column<double>(type: "float", nullable: false),
                    DamayeFarayand = table.Column<double>(type: "float", nullable: false),
                    FesharGij = table.Column<double>(type: "float", nullable: false),
                    ErtefSathMayeAzMahalRahaYesh = table.Column<double>(type: "float", nullable: false),
                    MasahatDayk = table.Column<double>(type: "float", nullable: false),
                    MakhazenDayk = table.Column<double>(type: "float", nullable: false),
                    DamayeMadehDarMohit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HD3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdModelsaziEntesharApp = table.Column<int>(type: "int", nullable: false),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelsaziEnteshars", x => x.IdModelsaziEnteshar);
                    table.ForeignKey(
                        name: "FK_ModelsaziEnteshars_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_L_Rotbebandi_Movajehe",
                columns: table => new
                {
                    ID_L_Rotbebandi_MovajeheApp = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_L_Rotbebandi_Movajehe = table.Column<int>(type: "int", nullable: false),
                    Titels_Rotbebandi_Movajehe = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Active_bit = table.Column<bool>(type: "bit", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_L_Rotbebandi_Movajehe", x => x.ID_L_Rotbebandi_MovajeheApp);
                    table.ForeignKey(
                        name: "FK_T_L_Rotbebandi_Movajehe_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Makan",
                columns: table => new
                {
                    ID_Makan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_MakanApp = table.Column<int>(type: "int", nullable: false),
                    OnvanMakan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Makan", x => x.ID_Makan);
                    table.ForeignKey(
                        name: "FK_T_Makan_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaheds",
                columns: table => new
                {
                    IdLVahed = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdLVahedApp = table.Column<int>(type: "int", nullable: false),
                    TiletVahed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Map_Name_File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackupStatusIdBackup = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaheds", x => x.IdLVahed);
                    table.ForeignKey(
                        name: "FK_Vaheds_BackupStatuses_BackupStatusIdBackup",
                        column: x => x.BackupStatusIdBackup,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup");
                });

            migrationBuilder.CreateTable(
                name: "Allmadehs",
                columns: table => new
                {
                    IdAllmadeh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameFa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Formol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Erg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Un = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaseKhatarDot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HamNamHa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstefadehayeAsli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatanKhatarGhs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OmreMofid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTarkibi = table.Column<bool>(type: "bit", nullable: false),
                    IsNoEtelatMadeh = table.Column<bool>(type: "bit", nullable: false),
                    NameFileMadeh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAllmadehApp = table.Column<int>(type: "int", nullable: false),
                    TLAdadEtelatBehdashtiIdApp = table.Column<int>(type: "int", nullable: false),
                    TLAdadEtalatHarighIdApp = table.Column<int>(type: "int", nullable: false),
                    TLAdadEtelatVakonoshdehiIdApp = table.Column<int>(type: "int", nullable: false),
                    TLKhataratKhasIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TLAdadEtelatBehdashtiId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_TLAdadEtalatHarighId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_TLAdadEtelatVakonoshdehiId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_TLKhataratKhasId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allmadehs", x => x.IdAllmadeh);
                    table.ForeignKey(
                        name: "FK_Allmadehs_AdadEtalatHarighs_FK_TLAdadEtalatHarighId",
                        column: x => x.FK_TLAdadEtalatHarighId,
                        principalTable: "AdadEtalatHarighs",
                        principalColumn: "IdAdadEtalatHarigh");
                    table.ForeignKey(
                        name: "FK_Allmadehs_AdadEtelatBehdashtis_FK_TLAdadEtelatBehdashtiId",
                        column: x => x.FK_TLAdadEtelatBehdashtiId,
                        principalTable: "AdadEtelatBehdashtis",
                        principalColumn: "IdAdadEtelatBehdashti");
                    table.ForeignKey(
                        name: "FK_Allmadehs_AdadEtelatVakonoshdehis_FK_TLAdadEtelatVakonoshdehiId",
                        column: x => x.FK_TLAdadEtelatVakonoshdehiId,
                        principalTable: "AdadEtelatVakonoshdehis",
                        principalColumn: "IdAdadEtelatVakonoshdehi");
                    table.ForeignKey(
                        name: "FK_Allmadehs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Allmadehs_KhataratKhases_FK_TLKhataratKhasId",
                        column: x => x.FK_TLKhataratKhasId,
                        principalTable: "KhataratKhases",
                        principalColumn: "IdKhataratKhas");
                });

            migrationBuilder.CreateTable(
                name: "T_OnvanShoghli",
                columns: table => new
                {
                    ID_OnvanShoghli = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Onvan_Shoghli = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Sharhe_Shoghli = table.Column<string>(type: "nvarchar(1900)", maxLength: 1900, nullable: true),
                    ID_OnvanShoghliApp = table.Column<int>(type: "int", nullable: false),
                    T_Vaheds_ID = table.Column<int>(type: "int", nullable: false),
                    FK_T_Vaheds_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OnvanShoghli", x => x.ID_OnvanShoghli);
                    table.ForeignKey(
                        name: "FK_T_OnvanShoghli_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_OnvanShoghli_Vaheds_FK_T_Vaheds_ID",
                        column: x => x.FK_T_Vaheds_ID,
                        principalTable: "Vaheds",
                        principalColumn: "IdLVahed");
                });

            migrationBuilder.CreateTable(
                name: "T_Tajhiz",
                columns: table => new
                {
                    ID_Tajhiz = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Onvan_Tajhiz = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Onvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Tedad_Shaghelin = table.Column<int>(type: "int", nullable: false),
                    ID_TajhizApp = table.Column<int>(type: "int", nullable: false),
                    T_Vaheds_IDApp = table.Column<int>(type: "int", nullable: false),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_T_Vaheds_ID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Tajhiz", x => x.ID_Tajhiz);
                    table.ForeignKey(
                        name: "FK_T_Tajhiz_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Tajhiz_Vaheds_FK_T_Vaheds_ID",
                        column: x => x.FK_T_Vaheds_ID,
                        principalTable: "Vaheds",
                        principalColumn: "IdLVahed");
                });

            migrationBuilder.CreateTable(
                name: "CEIs",
                columns: table => new
                {
                    IdCEI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdCEIApp = table.Column<int>(type: "int", nullable: false),
                    Zarf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QotrLole = table.Column<int>(type: "int", nullable: true),
                    QotrParegi = table.Column<int>(type: "int", nullable: true),
                    MotaselBeZarf = table.Column<int>(type: "int", nullable: true),
                    OnvaneSenario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vahed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tajhiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VahedTajhiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HalatRahayeshMade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeghdarKolMade = table.Column<int>(type: "int", nullable: true),
                    DamayeFarayand = table.Column<int>(type: "int", nullable: true),
                    Meghdargij = table.Column<int>(type: "int", nullable: true),
                    ErtefSathMayeAzMahalRahaYesh = table.Column<int>(type: "int", nullable: true),
                    MasahatDayk = table.Column<int>(type: "int", nullable: true),
                    MakhazenDayk = table.Column<int>(type: "int", nullable: true),
                    Mw = table.Column<int>(type: "int", nullable: true),
                    DansitehBokhar = table.Column<int>(type: "int", nullable: true),
                    NoghteJoosh = table.Column<int>(type: "int", nullable: true),
                    FesharBokharMaye = table.Column<int>(type: "int", nullable: true),
                    GarmayeTabkhir = table.Column<int>(type: "int", nullable: true),
                    GarmayeSokhtan = table.Column<int>(type: "int", nullable: true),
                    ERPG1 = table.Column<int>(type: "int", nullable: true),
                    ERPG2 = table.Column<int>(type: "int", nullable: true),
                    ERPG3 = table.Column<int>(type: "int", nullable: true),
                    DamayeMadehDarMohit = table.Column<int>(type: "int", nullable: true),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CEIs", x => x.IdCEI);
                    table.ForeignKey(
                        name: "FK_CEIs_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_CEIs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EghdamatDarmanis",
                columns: table => new
                {
                    IdEghdamatDarmani = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModiriyatRahTanafosi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModiriyatMovajeheCheshmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModiriyatMovajeheKhoraki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModiriyatMovajehePosti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TashkhisEftraghi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeyarhayeEzambeMarakzDarman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeyarhayePazireshVaBastari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeyarhayeErayeMoshverPezeshki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeyarhayeTarkhis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlodegizodaiPishBimarestani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlodegizodaiBimarestani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlodegizodaiDarManzel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEghdamatDarmaniApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EghdamatDarmanis", x => x.IdEghdamatDarmani);
                    table.ForeignKey(
                        name: "FK_EghdamatDarmanis_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_EghdamatDarmanis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EtelatAnbardaris",
                columns: table => new
                {
                    IdEtelatAnbardari = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DamayeNegahdari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SharayetNegahdari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MavadNasazegar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModatZamanNegahdari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SharayetMamnoehAnbaresh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZorofMonasebAnbaresh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEtelatAnbardariApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtelatAnbardaris", x => x.IdEtelatAnbardari);
                    table.ForeignKey(
                        name: "FK_EtelatAnbardaris_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_EtelatAnbardaris_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etelatbehdashtis",
                columns: table => new
                {
                    IdEtelatbehdashti = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AlaemMovajehe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsaratMozmen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsaratHad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhabeleyatTahrik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AndamHadaf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsaratKotahModat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RahhayeMovajehe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoayenatPezeshki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoayenatPezeshiPasazMovajehe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEtelatbehdashtiApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etelatbehdashtis", x => x.IdEtelatbehdashti);
                    table.ForeignKey(
                        name: "FK_Etelatbehdashtis_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Etelatbehdashtis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EtelatHamlonaghls",
                columns: table => new
                {
                    IdEtelatHamlonaghl = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RaveshHamlonaghl = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    AdadHamloNaghlSazmanMelal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupDasteBandi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZorofEstandardHamlonaghl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EhtiyatatVijheHamlonaghl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HamlonaghlDaryaei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEtelatHamlonaghlApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtelatHamlonaghls", x => x.IdEtelatHamlonaghl);
                    table.ForeignKey(
                        name: "FK_EtelatHamlonaghls_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_EtelatHamlonaghls_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EtelatHarighs",
                columns: table => new
                {
                    IdEtelatHarigh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HadaghalEnerzhiehteragh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PotansiyelEhteragh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaveshEtfayeHarigh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhataratSokhtan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahsolatEhteragh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TajhizatHefazati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VakoneshDehiBaAb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskHarigh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhatarShimiaei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhatarEnfejar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtelaatAtashneshani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MadehMonasebEtfaei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEtelatHarighApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtelatHarighs", x => x.IdEtelatHarigh);
                    table.ForeignKey(
                        name: "FK_EtelatHarighs_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_EtelatHarighs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EtelatSamShenas",
                columns: table => new
                {
                    IdEtelatSamShenasi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Idlh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lc50 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lc50Num = table.Column<double>(type: "float", nullable: false),
                    Ld50 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiologicToxicityValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModiriatMasmomiatShadid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModiriatMasmomiatMolayem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toksicokentic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZhnotoKesisiti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SammiatHad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SammiatMozmen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhatarAspirasion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEtelatSamShenasiApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtelatSamShenas", x => x.IdEtelatSamShenasi);
                    table.ForeignKey(
                        name: "FK_EtelatSamShenas_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_EtelatSamShenas_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ghs",
                columns: table => new
                {
                    IdGhs = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Signal = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BayaneKhatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JomleEhtiyati = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Piktogram = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    IdGhsApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghs", x => x.IdGhs);
                    table.ForeignKey(
                        name: "FK_Ghs_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Ghs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hododmojazmovajehes",
                columns: table => new
                {
                    IdHododmojazmovajehe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TlvTwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TlvTwaNum = table.Column<double>(type: "float", nullable: false),
                    TlvStel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TlvStelNum = table.Column<double>(type: "float", nullable: false),
                    TlvC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OelTwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OelStel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OelC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LimitBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    IdHododmojazmovajeheApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hododmojazmovajehes", x => x.IdHododmojazmovajehe);
                    table.ForeignKey(
                        name: "FK_Hododmojazmovajehes_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Hododmojazmovajehes_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Khataratmadehs",
                columns: table => new
                {
                    IdKhataratmadeh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Saratanzayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolimerizasionKhatarnak = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    KhataratHad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhataratMozmen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahsolatSamiSokhtan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TajziyeKhatarnak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EghdamatEhtiyati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SayerKhataratTabagheBandiNashode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKhataratmadehApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khataratmadehs", x => x.IdKhataratmadeh);
                    table.ForeignKey(
                        name: "FK_Khataratmadehs_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Khataratmadehs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Khavasfizikis",
                columns: table => new
                {
                    IdKhavasfiziki = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HalatfizikiVaziyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vozoh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mazeh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ghabelenhelal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GarmayeTabkhir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GarmayeSokhtan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoghteEnjemad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZaribTajzieh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamayeTajzieh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MwNum = table.Column<double>(type: "float", nullable: false),
                    Bp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BpNum = table.Column<double>(type: "float", nullable: false),
                    Vi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VdNum = table.Column<double>(type: "float", nullable: false),
                    Sg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SgNum = table.Column<double>(type: "float", nullable: false),
                    Ph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhNum = table.Column<double>(type: "float", nullable: false),
                    Mp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LelNum = table.Column<double>(type: "float", nullable: false),
                    Uel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UelNum = table.Column<double>(type: "float", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtNum = table.Column<double>(type: "float", nullable: false),
                    Vp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FpNum = table.Column<double>(type: "float", nullable: false),
                    IdKhavasfizikiApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khavasfizikis", x => x.IdKhavasfiziki);
                    table.ForeignKey(
                        name: "FK_Khavasfizikis_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Khavasfizikis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KomakhayeAvaleyehs",
                columns: table => new
                {
                    IdKomakhayeAvaleyeh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AntiDot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KomakhayeAvaleyePosti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KomakhayeAvaleyeTanafosi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KomakhayeAvaleyeCheshmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KomakhayeAvaleyeGovareshi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KomakhayeAvaleyeGhalbi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlodegiZodaeiEzterari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeyarhayeEzambeBimarestan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhatayeEhtemaliDarman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KomakHayeAvalieMovajeheHad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlaemHayati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoreZamani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TasiratTakhiriMovajehe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DarmanhayeEkhtesasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKomakhayeAvaleyehApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomakhayeAvaleyehs", x => x.IdKomakhayeAvaleyeh);
                    table.ForeignKey(
                        name: "FK_KomakhayeAvaleyehs_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_KomakhayeAvaleyehs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyLibraries",
                columns: table => new
                {
                    IdMyLibrary = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Kammiat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakanOrTajhiz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdMyLibraryApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    TLVahedIdApp = table.Column<int>(type: "int", nullable: false),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_TLVahedId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyLibraries", x => x.IdMyLibrary);
                    table.ForeignKey(
                        name: "FK_MyLibraries_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_MyLibraries_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyLibraries_Vaheds_FK_TLVahedId",
                        column: x => x.FK_TLVahedId,
                        principalTable: "Vaheds",
                        principalColumn: "IdLVahed");
                });

            migrationBuilder.CreateTable(
                name: "Osolkontorolis",
                columns: table => new
                {
                    IdOsolkontoroli = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RaveshHamlonaghlJabejayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TajhizatHefazatFardi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherProtectiveActions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdOsolkontoroliApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osolkontorolis", x => x.IdOsolkontoroli);
                    table.ForeignKey(
                        name: "FK_Osolkontorolis_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Osolkontorolis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paydarimadehs",
                columns: table => new
                {
                    IdPaydarimadeh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Paydari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SharayetGhabelEhteraz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhataratVakoneshdehi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MahsolatTajziyeKhatarnak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdadVakoneshDehiNfpa = table.Column<int>(type: "int", nullable: true),
                    IdPaydarimadehApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paydarimadehs", x => x.IdPaydarimadeh);
                    table.ForeignKey(
                        name: "FK_Paydarimadehs_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Paydarimadehs_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RahnamayeMoayenats",
                columns: table => new
                {
                    IdRahnamayeMoayenat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MoayenatOmoumi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MamnoueeyatMoayene = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tanafosi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cheshm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Khon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eskeleti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaqzOAsab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tanasoli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QalbuOurough = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kabed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kolie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Govaresh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edrari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goosh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BioMarker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bini = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DahanVaGelou = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamayeBadan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestAzmayeshgahi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SayerMpayenat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModiriatRahhayHavaei = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HazfPishrafte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShokiYaKoma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaghiiratHourmoni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRahnamayeMoayenatApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RahnamayeMoayenats", x => x.IdRahnamayeMoayenat);
                    table.ForeignKey(
                        name: "FK_RahnamayeMoayenats_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_RahnamayeMoayenats_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reactivities",
                columns: table => new
                {
                    IdReactivity = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TAllmadeh1Id = table.Column<int>(type: "int", nullable: false),
                    TAllmadeh2Id = table.Column<int>(type: "int", nullable: false),
                    Vakonesh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HazardPredictions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GasPrediction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdReactivityApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactivities", x => x.IdReactivity);
                    table.ForeignKey(
                        name: "FK_Reactivities_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Reactivities_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SarneveshtZistmohitis",
                columns: table => new
                {
                    IdSarneveshtZistmohiti = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SarneveshtZistmohiti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoajehMohiti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JazbDrKhak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AsibBeEqosistem = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    AsaratDerazModat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaydariDrMohitzist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SamiiatZisti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhabeliatTajamoZisti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SobatVaTajrobeNapazirizisti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSarneveshtZistmohitiApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SarneveshtZistmohitis", x => x.IdSarneveshtZistmohiti);
                    table.ForeignKey(
                        name: "FK_SarneveshtZistmohitis_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_SarneveshtZistmohitis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sharayetezteraris",
                columns: table => new
                {
                    IdSharayetezterari = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    JodasaziFori = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    TakhliyeAvaliyeh = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    Jodasazi = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    Takhliye = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    JodasaziRahayeshKockak = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    FaselehJodaavaleDrRoz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaselehJodaavaleDrShab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JodasaziRahayeshBozorg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaselehJodasaziRBozorgDrRoz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaselehJodasaziRBozorgDrShab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VasayelHefazatiFardi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoaTakhliyeNashtKochak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoaTakhliyeNashtBozorg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaveshDaf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaveshJamavari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Erpg_1 = table.Column<double>(type: "float", nullable: true),
                    Erpg_2 = table.Column<double>(type: "float", nullable: true),
                    Erpg_3 = table.Column<double>(type: "float", nullable: true),
                    Aegl1_10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl1_30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl1_60 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl1_4h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl1_8h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl2_10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl2_30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl2_60 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl2_4h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl2_8h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl3_10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl3_30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl3_60 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl3_4h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aegl3_8h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Erpg1 = table.Column<double>(type: "float", nullable: false),
                    Erpg2 = table.Column<double>(type: "float", nullable: false),
                    Erpg3 = table.Column<double>(type: "float", nullable: false),
                    MGA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MGB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MZC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JodasaziAvalieh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tajhizat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoayenatPezeshkiPazMovajehe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EhtiyatatZistMohiti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MadehJazebMonaseb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HefazatAzAfradAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSharayetezterariApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sharayetezteraris", x => x.IdSharayetezterari);
                    table.ForeignKey(
                        name: "FK_Sharayetezteraris_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_Sharayetezteraris_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TajhizatHefazatfardis",
                columns: table => new
                {
                    IdTajhizatHefazatfardi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HefazatCheshm = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    HefazatDast = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    HefazatBadan = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    HefazatSystemtanafosi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HefazatPa = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    FaktorhayeHefazatTanafosi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoodoodMojazBiologic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EghdamatControliMohandesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VasayelHefazatiHararati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTajhizatHefazatfardiApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TajhizatHefazatfardis", x => x.IdTajhizatHefazatfardi);
                    table.ForeignKey(
                        name: "FK_TajhizatHefazatfardis_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_TajhizatHefazatfardis_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TAllmadehTarkibi",
                columns: table => new
                {
                    IdAllmadehTarkibi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Darsad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAllmadehTarkibiApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAllmadehTarkibi", x => x.IdAllmadehTarkibi);
                    table.ForeignKey(
                        name: "FK_TAllmadehTarkibi_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_TAllmadehTarkibi_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Map_Locations",
                columns: table => new
                {
                    ID_Map_Locations = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Left1 = table.Column<int>(type: "int", nullable: true),
                    Top1 = table.Column<int>(type: "int", nullable: true),
                    Width1 = table.Column<int>(type: "int", nullable: true),
                    Height1 = table.Column<int>(type: "int", nullable: true),
                    Point_Left = table.Column<int>(type: "int", nullable: true),
                    Point_Top = table.Column<int>(type: "int", nullable: true),
                    Name_Makan = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ID_Map_LocationsApp = table.Column<int>(type: "int", nullable: false),
                    T_Tajhiz_ID = table.Column<int>(type: "int", nullable: false),
                    T_Makan_ID = table.Column<int>(type: "int", nullable: false),
                    T_Vahed_Id = table.Column<int>(type: "int", nullable: false),
                    FK_T_Makan_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_Tajhiz_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_Vahed_Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Map_Locations", x => x.ID_Map_Locations);
                    table.ForeignKey(
                        name: "FK_T_Map_Locations_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Map_Locations_T_Makan_FK_T_Makan_ID",
                        column: x => x.FK_T_Makan_ID,
                        principalTable: "T_Makan",
                        principalColumn: "ID_Makan");
                    table.ForeignKey(
                        name: "FK_T_Map_Locations_T_Tajhiz_FK_T_Tajhiz_ID",
                        column: x => x.FK_T_Tajhiz_ID,
                        principalTable: "T_Tajhiz",
                        principalColumn: "ID_Tajhiz");
                    table.ForeignKey(
                        name: "FK_T_Map_Locations_Vaheds_FK_T_Vahed_Id",
                        column: x => x.FK_T_Vahed_Id,
                        principalTable: "Vaheds",
                        principalColumn: "IdLVahed");
                });

            migrationBuilder.CreateTable(
                name: "T_Tag",
                columns: table => new
                {
                    ID_Tag = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number_Tag = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Mogheyat_Makan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    T_Makan_IDApp = table.Column<int>(type: "int", nullable: false),
                    T_Vaheds_IDApp = table.Column<int>(type: "int", nullable: false),
                    T_Tajhiz_IDApp = table.Column<int>(type: "int", nullable: false),
                    ID_TagApp = table.Column<int>(type: "int", nullable: false),
                    FK_T_Makan_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_Vaheds_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_Tajhiz_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Tag", x => x.ID_Tag);
                    table.ForeignKey(
                        name: "FK_T_Tag_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Tag_T_Makan_FK_T_Makan_ID",
                        column: x => x.FK_T_Makan_ID,
                        principalTable: "T_Makan",
                        principalColumn: "ID_Makan");
                    table.ForeignKey(
                        name: "FK_T_Tag_T_Tajhiz_FK_T_Vaheds_ID",
                        column: x => x.FK_T_Vaheds_ID,
                        principalTable: "T_Tajhiz",
                        principalColumn: "ID_Tajhiz");
                    table.ForeignKey(
                        name: "FK_T_Tag_Vaheds_FK_T_Vaheds_ID",
                        column: x => x.FK_T_Vaheds_ID,
                        principalTable: "Vaheds",
                        principalColumn: "IdLVahed");
                });

            migrationBuilder.CreateTable(
                name: "T_Madeh_Movajehe",
                columns: table => new
                {
                    ID_Madeh_Movajehe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tedad_Shaghelin = table.Column<int>(type: "int", nullable: false),
                    Modat_Movajehe = table.Column<int>(type: "int", nullable: true),
                    Moshakhasat_PPF = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Active_PPG_bit = table.Column<bool>(type: "bit", nullable: true),
                    Date_Create = table.Column<DateTime>(type: "datetime2", nullable: true),
                    T_Tajhiz_IDApp = table.Column<int>(type: "int", nullable: false),
                    T_Makan_IDApp = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    T_L_Rotbebandi_Movajehe_IDApp = table.Column<int>(type: "int", nullable: false),
                    T_OnvanShoghli_IDApp = table.Column<int>(type: "int", nullable: false),
                    ID_Madeh_MovajeheApp = table.Column<int>(type: "int", nullable: false),
                    FK_T_Tajhiz_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_Makan_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_L_Rotbebandi_Movajehe_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_OnvanShoghli_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    T_OnvanShoghliID_OnvanShoghli = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Madeh_Movajehe", x => x.ID_Madeh_Movajehe);
                    table.ForeignKey(
                        name: "FK_T_Madeh_Movajehe_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_T_Madeh_Movajehe_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Madeh_Movajehe_Osolkontorolis_FK_T_OnvanShoghli_ID",
                        column: x => x.FK_T_OnvanShoghli_ID,
                        principalTable: "Osolkontorolis",
                        principalColumn: "IdOsolkontoroli");
                    table.ForeignKey(
                        name: "FK_T_Madeh_Movajehe_T_L_Rotbebandi_Movajehe_FK_T_L_Rotbebandi_Movajehe_ID",
                        column: x => x.FK_T_L_Rotbebandi_Movajehe_ID,
                        principalTable: "T_L_Rotbebandi_Movajehe",
                        principalColumn: "ID_L_Rotbebandi_MovajeheApp");
                    table.ForeignKey(
                        name: "FK_T_Madeh_Movajehe_T_Makan_FK_T_Makan_ID",
                        column: x => x.FK_T_Makan_ID,
                        principalTable: "T_Makan",
                        principalColumn: "ID_Makan");
                    table.ForeignKey(
                        name: "FK_T_Madeh_Movajehe_T_OnvanShoghli_T_OnvanShoghliID_OnvanShoghli",
                        column: x => x.T_OnvanShoghliID_OnvanShoghli,
                        principalTable: "T_OnvanShoghli",
                        principalColumn: "ID_OnvanShoghli");
                    table.ForeignKey(
                        name: "FK_T_Madeh_Movajehe_T_Tajhiz_FK_T_Tajhiz_ID",
                        column: x => x.FK_T_Tajhiz_ID,
                        principalTable: "T_Tajhiz",
                        principalColumn: "ID_Tajhiz");
                });

            migrationBuilder.CreateTable(
                name: "T_Map_Madeh",
                columns: table => new
                {
                    ID_Map_Madeh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_Map_MadehApp = table.Column<int>(type: "int", nullable: false),
                    T_Map_Locations_IDApp = table.Column<int>(type: "int", nullable: true),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_Map_LocationsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Map_Madeh", x => x.ID_Map_Madeh);
                    table.ForeignKey(
                        name: "FK_T_Map_Madeh_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_T_Map_Madeh_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Map_Madeh_T_Map_Locations_FK_T_Map_LocationsId",
                        column: x => x.FK_T_Map_LocationsId,
                        principalTable: "T_Map_Locations",
                        principalColumn: "ID_Map_Locations");
                });

            migrationBuilder.CreateTable(
                name: "T_Mavad_Tag",
                columns: table => new
                {
                    ID_Mavad_Tag = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    T_Allmadehs_IDApp = table.Column<int>(type: "int", nullable: false),
                    ID_Mavad_TagApp = table.Column<int>(type: "int", nullable: false),
                    T_Tag_IDApp = table.Column<int>(type: "int", nullable: false),
                    FK_T_Tag_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Mavad_Tag", x => x.ID_Mavad_Tag);
                    table.ForeignKey(
                        name: "FK_T_Mavad_Tag_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_T_Mavad_Tag_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Mavad_Tag_T_Tag_FK_T_Tag_ID",
                        column: x => x.FK_T_Tag_ID,
                        principalTable: "T_Tag",
                        principalColumn: "ID_Tag");
                });

            migrationBuilder.CreateTable(
                name: "T_Tag_Matters",
                columns: table => new
                {
                    ID_TagMatter = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Feshar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Darsad = table.Column<int>(type: "int", nullable: false),
                    TAllmadehIdApp = table.Column<int>(type: "int", nullable: false),
                    ID_TagMatterApp = table.Column<int>(type: "int", nullable: false),
                    T_Tag_IDApp = table.Column<int>(type: "int", nullable: false),
                    FK_TAllmadehId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FK_T_Tag_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BackupStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Tag_Matters", x => x.ID_TagMatter);
                    table.ForeignKey(
                        name: "FK_T_Tag_Matters_Allmadehs_FK_TAllmadehId",
                        column: x => x.FK_TAllmadehId,
                        principalTable: "Allmadehs",
                        principalColumn: "IdAllmadeh");
                    table.ForeignKey(
                        name: "FK_T_Tag_Matters_BackupStatuses_BackupStatusId",
                        column: x => x.BackupStatusId,
                        principalTable: "BackupStatuses",
                        principalColumn: "IdBackup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Tag_Matters_T_Tag_FK_T_Tag_ID",
                        column: x => x.FK_T_Tag_ID,
                        principalTable: "T_Tag",
                        principalColumn: "ID_Tag");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdadEtalatHarighs_BackupStatusId",
                table: "AdadEtalatHarighs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdadEtelatBehdashtis_BackupStatusId",
                table: "AdadEtelatBehdashtis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdadEtelatVakonoshdehis_BackupStatusId",
                table: "AdadEtelatVakonoshdehis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Allmadehs_BackupStatusId",
                table: "Allmadehs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Allmadehs_FK_TLAdadEtalatHarighId",
                table: "Allmadehs",
                column: "FK_TLAdadEtalatHarighId");

            migrationBuilder.CreateIndex(
                name: "IX_Allmadehs_FK_TLAdadEtelatBehdashtiId",
                table: "Allmadehs",
                column: "FK_TLAdadEtelatBehdashtiId");

            migrationBuilder.CreateIndex(
                name: "IX_Allmadehs_FK_TLAdadEtelatVakonoshdehiId",
                table: "Allmadehs",
                column: "FK_TLAdadEtelatVakonoshdehiId");

            migrationBuilder.CreateIndex(
                name: "IX_Allmadehs_FK_TLKhataratKhasId",
                table: "Allmadehs",
                column: "FK_TLKhataratKhasId");

            migrationBuilder.CreateIndex(
                name: "IX_Arzyabis_BackupStatusId",
                table: "Arzyabis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CEIs_BackupStatusId",
                table: "CEIs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CEIs_FK_TAllmadehId",
                table: "CEIs",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_EghdamatDarmanis_BackupStatusId",
                table: "EghdamatDarmanis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EghdamatDarmanis_FK_TAllmadehId",
                table: "EghdamatDarmanis",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatAnbardaris_BackupStatusId",
                table: "EtelatAnbardaris",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatAnbardaris_FK_TAllmadehId",
                table: "EtelatAnbardaris",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Etelatbehdashtis_BackupStatusId",
                table: "Etelatbehdashtis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Etelatbehdashtis_FK_TAllmadehId",
                table: "Etelatbehdashtis",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatHamlonaghls_BackupStatusId",
                table: "EtelatHamlonaghls",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatHamlonaghls_FK_TAllmadehId",
                table: "EtelatHamlonaghls",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatHarighs_BackupStatusId",
                table: "EtelatHarighs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatHarighs_FK_TAllmadehId",
                table: "EtelatHarighs",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatSamShenas_BackupStatusId",
                table: "EtelatSamShenas",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EtelatSamShenas_FK_TAllmadehId",
                table: "EtelatSamShenas",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_FileERGs_BackupStatusId",
                table: "FileERGs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ghs_BackupStatusId",
                table: "Ghs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ghs_FK_TAllmadehId",
                table: "Ghs",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Hododmojazmovajehes_BackupStatusId",
                table: "Hododmojazmovajehes",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Hododmojazmovajehes_FK_TAllmadehId",
                table: "Hododmojazmovajehes",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_KhataratKhases_BackupStatusId",
                table: "KhataratKhases",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Khataratmadehs_BackupStatusId",
                table: "Khataratmadehs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Khataratmadehs_FK_TAllmadehId",
                table: "Khataratmadehs",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Khavasfizikis_BackupStatusId",
                table: "Khavasfizikis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Khavasfizikis_FK_TAllmadehId",
                table: "Khavasfizikis",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_KomakhayeAvaleyehs_BackupStatusId",
                table: "KomakhayeAvaleyehs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_KomakhayeAvaleyehs_FK_TAllmadehId",
                table: "KomakhayeAvaleyehs",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Log_BackupStatusId",
                table: "Log",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelsaziEnteshars_BackupStatusId",
                table: "ModelsaziEnteshars",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MyLibraries_BackupStatusId",
                table: "MyLibraries",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MyLibraries_FK_TAllmadehId",
                table: "MyLibraries",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_MyLibraries_FK_TLVahedId",
                table: "MyLibraries",
                column: "FK_TLVahedId");

            migrationBuilder.CreateIndex(
                name: "IX_Osolkontorolis_BackupStatusId",
                table: "Osolkontorolis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Osolkontorolis_FK_TAllmadehId",
                table: "Osolkontorolis",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Paydarimadehs_BackupStatusId",
                table: "Paydarimadehs",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Paydarimadehs_FK_TAllmadehId",
                table: "Paydarimadehs",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_RahnamayeMoayenats_BackupStatusId",
                table: "RahnamayeMoayenats",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RahnamayeMoayenats_FK_TAllmadehId",
                table: "RahnamayeMoayenats",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactivities_BackupStatusId",
                table: "Reactivities",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactivities_FK_TAllmadehId",
                table: "Reactivities",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_SarneveshtZistmohitis_BackupStatusId",
                table: "SarneveshtZistmohitis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SarneveshtZistmohitis_FK_TAllmadehId",
                table: "SarneveshtZistmohitis",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Sharayetezteraris_BackupStatusId",
                table: "Sharayetezteraris",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sharayetezteraris_FK_TAllmadehId",
                table: "Sharayetezteraris",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_T_L_Rotbebandi_Movajehe_BackupStatusId",
                table: "T_L_Rotbebandi_Movajehe",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Madeh_Movajehe_BackupStatusId",
                table: "T_Madeh_Movajehe",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Madeh_Movajehe_FK_T_L_Rotbebandi_Movajehe_ID",
                table: "T_Madeh_Movajehe",
                column: "FK_T_L_Rotbebandi_Movajehe_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Madeh_Movajehe_FK_T_Makan_ID",
                table: "T_Madeh_Movajehe",
                column: "FK_T_Makan_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Madeh_Movajehe_FK_T_OnvanShoghli_ID",
                table: "T_Madeh_Movajehe",
                column: "FK_T_OnvanShoghli_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Madeh_Movajehe_FK_T_Tajhiz_ID",
                table: "T_Madeh_Movajehe",
                column: "FK_T_Tajhiz_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Madeh_Movajehe_FK_TAllmadehId",
                table: "T_Madeh_Movajehe",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Madeh_Movajehe_T_OnvanShoghliID_OnvanShoghli",
                table: "T_Madeh_Movajehe",
                column: "T_OnvanShoghliID_OnvanShoghli");

            migrationBuilder.CreateIndex(
                name: "IX_T_Makan_BackupStatusId",
                table: "T_Makan",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Map_Locations_BackupStatusId",
                table: "T_Map_Locations",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Map_Locations_FK_T_Makan_ID",
                table: "T_Map_Locations",
                column: "FK_T_Makan_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Map_Locations_FK_T_Tajhiz_ID",
                table: "T_Map_Locations",
                column: "FK_T_Tajhiz_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Map_Locations_FK_T_Vahed_Id",
                table: "T_Map_Locations",
                column: "FK_T_Vahed_Id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Map_Madeh_BackupStatusId",
                table: "T_Map_Madeh",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Map_Madeh_FK_T_Map_LocationsId",
                table: "T_Map_Madeh",
                column: "FK_T_Map_LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Map_Madeh_FK_TAllmadehId",
                table: "T_Map_Madeh",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Mavad_Tag_BackupStatusId",
                table: "T_Mavad_Tag",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Mavad_Tag_FK_T_Tag_ID",
                table: "T_Mavad_Tag",
                column: "FK_T_Tag_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Mavad_Tag_FK_TAllmadehId",
                table: "T_Mavad_Tag",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_T_OnvanShoghli_BackupStatusId",
                table: "T_OnvanShoghli",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_OnvanShoghli_FK_T_Vaheds_ID",
                table: "T_OnvanShoghli",
                column: "FK_T_Vaheds_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tag_BackupStatusId",
                table: "T_Tag",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tag_FK_T_Makan_ID",
                table: "T_Tag",
                column: "FK_T_Makan_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tag_FK_T_Vaheds_ID",
                table: "T_Tag",
                column: "FK_T_Vaheds_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tag_Matters_BackupStatusId",
                table: "T_Tag_Matters",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tag_Matters_FK_T_Tag_ID",
                table: "T_Tag_Matters",
                column: "FK_T_Tag_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tag_Matters_FK_TAllmadehId",
                table: "T_Tag_Matters",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tajhiz_BackupStatusId",
                table: "T_Tajhiz",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Tajhiz_FK_T_Vaheds_ID",
                table: "T_Tajhiz",
                column: "FK_T_Vaheds_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TajhizatHefazatfardis_BackupStatusId",
                table: "TajhizatHefazatfardis",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TajhizatHefazatfardis_FK_TAllmadehId",
                table: "TajhizatHefazatfardis",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_TAllmadehTarkibi_BackupStatusId",
                table: "TAllmadehTarkibi",
                column: "BackupStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TAllmadehTarkibi_FK_TAllmadehId",
                table: "TAllmadehTarkibi",
                column: "FK_TAllmadehId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaheds_BackupStatusIdBackup",
                table: "Vaheds",
                column: "BackupStatusIdBackup");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arzyabis");

            migrationBuilder.DropTable(
                name: "CEIs");

            migrationBuilder.DropTable(
                name: "EghdamatDarmanis");

            migrationBuilder.DropTable(
                name: "EtelatAnbardaris");

            migrationBuilder.DropTable(
                name: "Etelatbehdashtis");

            migrationBuilder.DropTable(
                name: "EtelatHamlonaghls");

            migrationBuilder.DropTable(
                name: "EtelatHarighs");

            migrationBuilder.DropTable(
                name: "EtelatSamShenas");

            migrationBuilder.DropTable(
                name: "FileERGs");

            migrationBuilder.DropTable(
                name: "Ghs");

            migrationBuilder.DropTable(
                name: "Hododmojazmovajehes");

            migrationBuilder.DropTable(
                name: "Khataratmadehs");

            migrationBuilder.DropTable(
                name: "Khavasfizikis");

            migrationBuilder.DropTable(
                name: "KomakhayeAvaleyehs");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "ModelsaziEnteshars");

            migrationBuilder.DropTable(
                name: "MyLibraries");

            migrationBuilder.DropTable(
                name: "Paydarimadehs");

            migrationBuilder.DropTable(
                name: "RahnamayeMoayenats");

            migrationBuilder.DropTable(
                name: "Reactivities");

            migrationBuilder.DropTable(
                name: "SarneveshtZistmohitis");

            migrationBuilder.DropTable(
                name: "Sharayetezteraris");

            migrationBuilder.DropTable(
                name: "T_Madeh_Movajehe");

            migrationBuilder.DropTable(
                name: "T_Map_Madeh");

            migrationBuilder.DropTable(
                name: "T_Mavad_Tag");

            migrationBuilder.DropTable(
                name: "T_Tag_Matters");

            migrationBuilder.DropTable(
                name: "TajhizatHefazatfardis");

            migrationBuilder.DropTable(
                name: "TAllmadehTarkibi");

            migrationBuilder.DropTable(
                name: "Osolkontorolis");

            migrationBuilder.DropTable(
                name: "T_L_Rotbebandi_Movajehe");

            migrationBuilder.DropTable(
                name: "T_OnvanShoghli");

            migrationBuilder.DropTable(
                name: "T_Map_Locations");

            migrationBuilder.DropTable(
                name: "T_Tag");

            migrationBuilder.DropTable(
                name: "Allmadehs");

            migrationBuilder.DropTable(
                name: "T_Makan");

            migrationBuilder.DropTable(
                name: "T_Tajhiz");

            migrationBuilder.DropTable(
                name: "AdadEtalatHarighs");

            migrationBuilder.DropTable(
                name: "AdadEtelatBehdashtis");

            migrationBuilder.DropTable(
                name: "AdadEtelatVakonoshdehis");

            migrationBuilder.DropTable(
                name: "KhataratKhases");

            migrationBuilder.DropTable(
                name: "Vaheds");

            migrationBuilder.DropTable(
                name: "BackupStatuses");
        }
    }
}
