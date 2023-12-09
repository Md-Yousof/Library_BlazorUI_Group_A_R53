using Library_BlazorUI_Group_A_R53;
using Library_BlazorUI_Group_A_R53.Accounts;
using Library_BlazorUI_Group_A_R53.Accounts.Services;
using Library_BlazorUI_Group_A_R53.Data;
using Library_BlazorUI_Group_A_R53.Services;
using Library_BlazorUI_Group_A_R53.Services.ShelfService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.Design;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthentication>();
builder.Services.AddSingleton<UserAccountService>();
builder.Services.AddSingleton<WeatherForecastService>();

//Main Api Endpoint
var baseApiUrl = new Uri("http://localhost:5154/");
builder.Services.AddHttpClient<IAuthService, AuthService>((services, client) =>
{
    client.BaseAddress = baseApiUrl;   
});  //this for Account Service DI

builder.Services.AddHttpClient<IBookFloorService, BookFloorSercive>(client => {
    client.BaseAddress = baseApiUrl;
});

builder.Services.AddHttpClient<IShelfService, ShelfService>(client =>
{
    client.BaseAddress = baseApiUrl;
});

builder.Services.AddHttpClient<IPublisherService, PublisherService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<ICategoryService, CategoryService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<ISubcategoryService, SubcatergoryService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<IBookService, BookService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<IAuthorService,AuthorService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<ISubscriptionPlanService, SubscriptionPlanService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<IBookCopyService, BookCopyService>(client =>
{
    client.BaseAddress = baseApiUrl;
});

builder.Services.AddHttpClient<IBorrowedBookService, BorrowedBookService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<IInvoiceService, InvoiceService>(client =>
{
    client.BaseAddress = baseApiUrl;
});
builder.Services.AddHttpClient<ISubscriptionUserService, SubscriptionUserService>(client =>
{
    client.BaseAddress = baseApiUrl;
});






var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
