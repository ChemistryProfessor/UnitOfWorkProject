

using UnitOfWork.Repository;
using UnitOfWork.Servises;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IClassDb1Repository, ClassDb1Repo>();
builder.Services.AddTransient<IClassDb2Repository, ClassDb2Repo>();
builder.Services.AddTransient<IClassDb3Repository, ClassDb3Repo>();
builder.Services.AddTransient<IClassDb4Repository, ClassDb4Repo>();
builder.Services.AddTransient<IClassDb5Repository, ClassDb5Repo>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
