using BookShoop.Data;
using BookShoop.Models;
using BookShoop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddDbContext<BooksStoreContext>(
    options => options.UseSqlServer("Data Source=localhost;Initial Catalog=BookStore;" +
    "Integrated Security=True;TrustServerCertificate=True; User Id=sa; Password=Genovese123!;"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseHttpsRedirection();
app.UseStaticFiles(); //primo

app.UseRouting();

app.UseAuthorization(); //secondo

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

