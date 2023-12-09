using Library_BlazorUI_Group_A_R53.Data.Models;

namespace Library_BlazorUI_Group_A_R53
{
    public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> GetAllInvoice();
        Task<Invoice> GetInvoiceById(int id);
        Task CreateInvoices(Invoice invoice);
    }
}
