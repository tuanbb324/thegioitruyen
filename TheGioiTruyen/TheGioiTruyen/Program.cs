using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

//string redisConnectionstring = builder.Configuration.GetConnectionString("RedisConnection");
//builder.Services.AddSingleton<IConnectionMultiplexer>(
//    sp =>
//    {
//        return ConnectionMultiplexer.Connect(redisConnectionstring);
//    }
//    );

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// check

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
