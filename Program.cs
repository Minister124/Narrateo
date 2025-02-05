var builder = WebApplication.CreateBuilder();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection(); //Redirect HTTP request to HTTPS for encryption
app.UseStaticFiles(); //Allows to serve the static files from wwwroot folder directly, improving performance

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "defaultRoute",
    pattern: "{controller=Blogs}/{action=Index}/{id?}"
);

app.Run();
