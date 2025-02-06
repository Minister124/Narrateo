var builder = WebApplication.CreateBuilder();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("Home/Error");
    app.UseHsts();
}


app.MapControllerRoute(
    name: "firstRoute",
    pattern:"{controller=PostBlogs}/{action=Index}/{id?}"
);

app.Run();