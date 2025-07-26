// قرارداد مشترک برای تمام داده‌های ورودی
public class RequestDataAndDetails<T>
{
    public required RequestDataDetails  rd { get; set; }
    public required T RequestData { get; set; }
}

public class RequestDataDetails 
{
    public int AdminID { get; set; }
    public Guid BackupId { get; set; }
}