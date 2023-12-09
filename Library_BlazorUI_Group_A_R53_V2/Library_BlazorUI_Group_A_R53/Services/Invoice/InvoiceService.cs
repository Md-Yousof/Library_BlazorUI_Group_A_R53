using Library_BlazorUI_Group_A_R53.Data.Models;
using System.Net.Http;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public class InvoiceService : IInvoiceService
    {
        private HttpClient _httpClient;
        public InvoiceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Invoice>> GetAllInvoice()
        {
          return await _httpClient.GetFromJsonAsync<Invoice[]>("api/Invoice");
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
          return await _httpClient.GetFromJsonAsync<Invoice>($"api/Invoice/{id}");
            
        }
        public async Task CreateInvoices(Invoice invoice)
        {
            await _httpClient.PostAsJsonAsync("api/Invoice", invoice);
        }
    }
}
