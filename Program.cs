using Blazored.Toast;
using Blazored.Modal;
using Blazored.LocalStorage;
using PRIORI_SERVICES_WEB.Handler.Services;
using PRIORI_SERVICES_WEB.Data.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredModal();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();
builder.Services.AddSingleton<HttpClient>();
builder.Services.AddScoped<IAsyncService, AsyncService>();
builder.Services.AddScoped<ISMTPService, SMTPService>().AddOptions<SMTPConfiguration>().BindConfiguration(SMTPConfiguration.DefaultSectionName);

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
