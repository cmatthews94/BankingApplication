using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;
using BankingApplication;
using BankingApplicationBlazorWebpage.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using BankingApplicationBlazorWebpage.Services;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMudServices();

builder.Services.AddDbContext<BankingApplicationDbContext>(options =>
    options.UseSqlServer(@"Data Source=.\HYDAELYN;Initial Catalog=BankingApplicationDb;Integrated Security=True;Encrypt=False;"));

builder.Services.AddTransient<IBankUserService, BankUserService>();
builder.Services.AddTransient<IBankAccountService, BankAccountService>();
builder.Services.AddTransient<ITransactionService, TransactionService>();
builder.Services.AddTransient<IPasswordHashingService, PasswordHashingService>();

builder.Services.AddSingleton<AppState>();
builder.Services.AddScoped<HomePageRefreshState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

