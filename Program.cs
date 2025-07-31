var builder = WebApplication.CreateBuilder(args);

// Register MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();      // Redirect HTTP to HTTPS
app.UseStaticFiles();           // Enable serving static files (CSS, JS)

app.UseRouting();               // Enable routing
app.UseAuthorization();         // Enable authorization (optional)

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Create}/{id?}");

app.Run();
