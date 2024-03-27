var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();
//controller/action/id?
//app.MapDefaultControllerRoute();

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name:"default",
    pattern : "{controller=Home}/{action=Index}/{id?}"//default routeı meeting controllera atadık
);
//üstteki ile aynı şey

app.Run();
