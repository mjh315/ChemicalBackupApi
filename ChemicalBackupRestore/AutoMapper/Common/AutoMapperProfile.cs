using AutoMapper;
using System.Reflection;

public class AutoMapperProfile : Profile 
{
    public AutoMapperProfile()
    {
        // این قانون به اتومپر می‌گوید پروپرتی‌هایی که متد get آنها virtual است را مپ نکند
        ShouldMapProperty = p => p.GetMethod != null && !p.GetMethod.IsVirtual;
    }
}