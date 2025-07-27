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

2. پیکربندی پکیج ها:
      ```bash dotnet build```



## ‌استفاده برای دیگر پروژه‌ها:
شما به راحتی می‌توانید با اعمال تغییرات از این سرویس برای پروژه‌های خودتان استفاده کنید.
مراحل انجام کار بدین شرح است:
-  افزودن جداول و برقراری ارتباط بین جداول:
  1  نامگذاری جداول را براساس منطق زیر انجام می‌دهیم:
  -  T_"main-table-name"
  -  T_L_"Lookup-table-name"
  -  T_M_"between-table-name"
  2  برای هر جدول اقدامات زیر را انجام می‌دهیم:
     - هر جدول را از IBackupable ارث‌بری می‌کنیم => با این کار می‌بایستی پراپرتی و navigation مربوط به این اینترفیس رو به پروژه اضافه کنی:
       
public Guid BackupStatusId { get; set; }
[ForeignKey("BackupStatusId")]
public virtual BackupStatus? BackupStatus { get; set; }



     - کلید اصلی را از نوع string قرار می دهیم
       
public required string IdGhs { get; set; }

     - به ازای هر کلید خارجی یک پراپرتی با نام همان کلید خارجی  با پیشوند <code>"FK_"</code> و از نوع <code>string</code> ایجاد می‌کنیم (حتما از navigation ها هم استفاده میکنیم.)
   
public string? FK_TAllmadehId { get; set; }
[ForeignKey("FK_TAllmadehId")]
public virtual TAllmadeh? TAllmadeh { get; set; }

-  ایجاد کلاس‌های dto بر اساس فایل‌های جداول[^2].
-  ایجاد Mapper برای هر جفت جدول و dto [3^].
استفاده برای دیگر پروژه‌ها
برای استفاده از این سرویس در پروژه‌های دیگر، مراحل زیر را دنبال کنید:

افزودن جداول
نام‌گذاری:
T_"main-table-name"
T_L_"lookup-table-name"
T_M_"between-table-name"
پیکربندی:
از IBackupable ارث‌بری کنید و پراپرتی‌های زیر را اضافه کنید:
public Guid BackupStatusId { get; set; }
[ForeignKey("BackupStatusId")] public virtual BackupStatus? BackupStatus { get; set; }
کلید اصلی را از نوع string تعریف کنید:
public required string IdGhs { get; set; }
برای کلیدهای خارجی، پراپرتی و ناوبگیشن بسازید:
public string? FK_TAllmadehId { get; set; }
[ForeignKey("FK_TAllmadehId")] public virtual TAllmadeh? TAllmadeh { get; set; }
مراحل بعدی

  
