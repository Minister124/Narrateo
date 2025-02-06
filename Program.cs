var builder = WebApplication.CreateBuilder();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("Home/Error");
//     app.UseHsts();
// }


// app.UseHttpsRedirection(); //To redirect data from HTTP to HTTPS for encryption
// app.UseStaticRouting(); //To enable static Routing 


app.MapControllerRoute(
    name: "firstRoute",
    pattern:"{controller=PostBlogs}/{action=Index}/{id?}"
);

app.Run();