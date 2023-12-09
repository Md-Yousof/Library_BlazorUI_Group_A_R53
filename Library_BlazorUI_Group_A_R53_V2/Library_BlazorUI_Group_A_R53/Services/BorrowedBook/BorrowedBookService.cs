using Library_BlazorUI_Group_A_R53.Data.Models;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public class BorrowedBookService : IBorrowedBookService
    {
        private readonly HttpClient httpClient;

        public BorrowedBookService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<BorrowedBook>> GetBorrowedBooks()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<IEnumerable<BorrowedBook>>("api/BorrowBook/all-borrowlist");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching borrowed books.", ex);
            }
        }
        public async Task<IEnumerable<BorrowedBook>> GetUserName(string username)  //This for Serching Box. 
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<IEnumerable<BorrowedBook>>($"api/BorrowBook/all-request/{username}");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching borrowed books by username.", ex);
            }
        }
        public async Task ApproveBorrowedBook(int borrowedBookId)
        {
            try
            {
                // Call the API to approve the borrowed book
                await httpClient.PutAsync($"api/BorrowBook/Approve/{borrowedBookId}", null);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while approving the borrowed book.", ex);
            }
        }

        // BorrowedBookService
        public async Task CancelBorrowedBook(int borrowedBookId, string comment)
        {
            var response = await httpClient.PutAsync($"api/BorrowBook/Cancel/{borrowedBookId}?comment={comment}", null);
            response.EnsureSuccessStatusCode();
        }

        public async Task ReturnBorrowedBook(int borrowedBookId, string remarks, decimal miscFine)
        {
            //var response = await httpClient.PutAsync($"api/BorrowBook/Return/{borrowedBookId}?remarks={remarks}?miscFine={miscFine}?", null);
            var response = await httpClient.PutAsync($"api/BorrowBook/Return/{borrowedBookId}?remarks={remarks}&miscFine={miscFine}", null);

            response.EnsureSuccessStatusCode();
        }
    }
}

