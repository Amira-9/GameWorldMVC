namespace WebApplication2.Services
{
    public interface IDevicesService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}
