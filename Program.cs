using Narrateo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapRazorPages();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "firstRoute",
    pattern:"{controller=PostBlogs}/{action=Index}/{id?}"
);

app.Run();