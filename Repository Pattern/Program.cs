using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Context;
using Repository_Pattern.Data;
using Repository_Pattern.Service;

var builder = WebApplication.CreateBuilder(args);


//MS SQL
//builder.Services.AddDbContext<TaskContext>(
//options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLDefault")));

//NPG
builder.Services.AddDbContext<TaskContext>(
options => options.UseNpgsql(builder.Configuration.GetConnectionString("NpgDefault")));


//Dependancy injection
builder.Services.AddScoped<ITaskDataService, TaskDataService>();
builder.Services.AddScoped<ITaskService, TaskService>();


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

//Seed Db
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    Repository_Pattern.Data.Seed.Seed.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();



app.Run();




