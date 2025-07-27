
# بکاپ سامانه شیمیایی


این سامانه وظیفه گرفتن بکاپ، ذخیره سازی و ارسال بکاپ مورد نیاز کاربران سامانه شیمیایی را دارد. 

## توضیحات  
این پروژه به صورت api در دسترس است و با استفاده از 4 اکشن اصلی مورد استفاده قرار می‌گیرد.
- <code >GetAllBackups()</code>
  
لیست تمامی بکاپ هایی که کاربر تا به الان گرفته است را نمایش می‌دهد.(خلاصه نحوه کار: کاربر با وارد کردن id admin خود، لیست تمامی بکاپ هایی که در گذشته گرفته را دریافت میکند)



- <code >ConfigBackup()</code>
  
  این اکشن را میتوان اصلی ترین اکش نرم افزار خواند. این اکشن مقدمه بکاپ گیری است. کاربر با برقراری ارتباط با این اکشن لیست جداولی که میخواهد از آنها بکاپ بگیرد را به سیستم معرفی میکند. کاربر از زمان معرفی تا 30 دقیقه فرصت دارد تا همه جداولی که قبلا اسامی آنها را به سیستم گزارش داده با استفاده از اکشن AddTable پر بکند.


  
- <code >AddTable()</code>
  
   کاربر می‌تواند با برقراری ارتباط با این اکشن اطلاعات هر جدول داخل سیستم خود را که قبلا نام آم را به سیستم بکاپ گزارش داده بود در قابل دیتای json به بکند ارسال کند.


  
- <code >GetTable()</code>

  کاربر با استفاده از این اکشن و اعلام BackupId خود جدول مورد نظر خود را از سیستم دریافت کند. 



  
این پروژه دارای یک سرویس پس‌زمینه (Background Service) مبتنی بر .NET است که با استفاده از Entity Framework Core داده‌های بکاپ قدیمی را مدیریت و حذف می‌کند. ویژگی‌های اصلی شامل:  
- حذف خودکار بکاپ‌های قدیمی‌تر از 30 دقیقه  
- پشتیبانی از چندین جدول دیتابیس  
- استفاده از AutoMapper برای مپینگ داده‌ها  


## پیش‌نیازها  
برای اجرای پروژه، موارد زیر نیاز است:  
- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet/9.0)  
- SQL Server (یا هر دیتابیس سازگار با EF Core)  
- Git  
- AutoMapper
- Swagger
- Entity Framework Core 9.0.7
- .NET 9.0  

## نصب 
1. مخزن را کلون کن:  
```bash
git clone https://github.com/mjh315]/ChemicalBackupApi.git
```

2. پیکربندی پکیج ها:
      ```bash dotnet build```



## ‌استفاده برای دیگر پروژه‌ها:
شما به راحتی می‌توانید با اعمال تغییرات از این سرویس برای پروژه‌های خودتان استفاده کنید.
مراحل انجام کار بدین شرح است:
<details dir="rtl">

<summary>1️⃣ افزودن جداول و برقراری ارتباط بین جداول:</summary>


> #### ✔ - نامگذاری جداول را براساس منطق زیر انجام می‌دهیم:
  > -  `T_"main-table-name"`
  > -  `T_L_"Lookup-table-name"`
  > -  `T_M_"between-table-name"`
>
>
>
> #### ✔ هر جدول را از IBackupable ارث‌بری می‌کنیم => با این کار می‌بایستی پراپرتی و navigation مربوط به این اینترفیس رو به پروژه اضافه کنی:
>
>```C#       
>public Guid BackupStatusId { get; set; }
>[ForeignKey("BackupStatusId")]
>public virtual BackupStatus? BackupStatus { get; set; }
>```
>
> #### ✔ کلید اصلی را از نوع **`string`** قرار می دهیم
> 
>```C# 
>public required string IdGhs { get; set; }
>````
>
>
> #### ✔ به ازای هر کلید خارجی یک پراپرتی با نام همان کلید خارجی  با پیشوند <code>"FK_"</code> و از نوع <code>string</code> ایجاد می‌کنیم (حتما از navigation ها هم استفاده میکنیم.)
  >
>```C# 
>public string? FK_TAllmadehId { get; set; }
>[ForeignKey("FK_TAllmadehId")]
>public virtual TAllmadeh? TAllmadeh { get; set; }
>```
>
>
>
> #### ✔ به ازای هرکلید داخلی و خارجی (که در مرحله گذشته نوع آنها را به `string` تغییر دادیم) یک پراپرتی از نوع int و به پیشوند `App` باشه:
>
>
>```C# 
>    public int IdGhsApp { get; set; }
>    public int TAllmadehIdApp { get; set; }
>```
>
>
> #### ✔ هر پراپرتی که بیانگر navigation است حتما باید از نوع `public virtual` باشه. اگر اینطور نباشه mapper به مشکل میخوره.
>
> #### ✔ حالا باید فایل BackupStatus.cs رو تغییر بدیم. بین این جدول و تمامی جداول دیگه که قراره بکاپ گرفته بشن رابطه یک به چند ایجاد کنید به صورتی که هر سطر جدول BackupStatus بتونه با چند سطر مابقی جداول ارتباط برقرار بکنه.
</details>







<details dir="rtl">

<summary>2️⃣ ایجاد کلاس های dto:</summary>


> #### ✔ محتوای جدول را کامل کپی کرده و در فایل dto جایگذاری می‌کنیم همچنین ابتدای نام فایل جدول را حذف و به انتهای آن Dto اضافه می‌کنیم:
>
>
>  -  `T_"main-table-name"` => `"main-table-name"Dto`
>
>
>
> #### ✔ همه ویژگی های `DataAnnotations` و `Navigation` به همراه همه `id`هایی که از نوع string هستند را حذف می‌کنیم:
>
>
>     
>```C#
>//[Key]
>//public required string IdGhs { get; set; }
>//[StringLength(250)]
>public string? Signal { get; set; }
>public Guid BackupStatusId { get; set; }
>//[ForeignKey("BackupStatusId")]
>//public virtual BackupStatus? BackupStatus { get; set; }
>
>public int IdGhsApp { get; set; }
>public int TAllmadehIdApp { get; set; }
>    // More Codes...
>
>```
>
>
> #### ✔ هر جدول را از `IBackupable` ارث‌بری می‌کنیم


</details>



<details dir="rtl">

<summary>3️⃣ ایجاد فایل‌های Mapper:</summary>


> #### ✔ نامگذاری `Mapper` را براساس منطق زیر انجام می‌دهیم:
>  -  `T_"main-table-name"` => `"main-table-name"Mapper`
>
>    
>
>  
> #### ✔ هر `Mapper` را از `AutoMapperProfile` ارث‌بری می‌کنیم
>
>
> #### ✔ ساختار فایل `Mapper` را مانند نمونه کد زیر تنظیم می‌کنیم:
>
>
>```C# 
>public class GhsMapper : AutoMapperProfile
>{
>    public GhsMapper()
>    {
>        CreateMap<TGhs, GhsDto>();
>        CreateMap<GhsDto, TGhs>()
>        // id backup
>            .ForMember(dest => dest.BackupStatusId, act => act.MapFrom(src => src.BackupStatusId))
>            // id primary key
>            .ForMember(dest => dest.IdGhs, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.IdGhsApp.ToString()))
>            //foreign keys
>            .ForMember(dest => dest.FK_TAllmadehId, act => act.MapFrom(src => src.BackupStatusId.ToString() + "_ID:_" + src.TAllmadehIdApp.ToString()));
>    }
>}
>````




</details>


<details dir="rtl">

<summary>4️⃣ تنظیمات فایل BackupRepository.cs :</summary>


> #### ✔ دیکشنری `_tableActions` رو بر اساس جدول ها و dto ها بازنویسی و بر اساس کمترین وابستگی(کلید خارجی) به بیشترین وابستگی مرتبشون کنید.
>
> 
>    نمونه مقداردهی شده:
>```C#
>    // ...
>    {
>        "Ghs",
>        new TableActionInfo(typeof(GhsDto),
>        typeof(TGhs),
>        AddEntitiesAsync<GhsDto, TGhs>,
>        async (backupId) => await GetEntitiesAsync<TGhs, GhsDto>(backupId))
>    },
>    // ...
>```
>
>  

</details>




<details dir="rtl">

<summary>5️⃣ تنظیمات فایل CleanupService.cs :</summary>


> #### ✔ سوییچ موجود در سرویس را مانند نمونه به جهت حذف هر 35 دقیقه یکبار جداولی که بکاپ آنها ناقص است تکمیل کنید.
>
> 
>    نمونه مقداردهی شده:
>```C#
>    // ...
>        case "Ghs":
>            var ghsRecs = context.Ghs.Where(i => i.BackupStatusId == record.IdBackup);
>            context.Ghs.RemoveRange(ghsRecs);
>            break;
>    // ...
>```
>
>  

</details>
