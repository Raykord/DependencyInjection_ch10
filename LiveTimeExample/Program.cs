using LiveTimeExample.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddTransient<Repository>(); //Каждый раз новый
//builder.Services.AddTransient<DataContext>();

builder.Services.AddScoped<Repository>(); //Новый в рамках запроса
//builder.Services.AddScoped<DataContext>();

//builder.Services.AddSingleton<Repository>(); //Один на всех
builder.Services.AddSingleton<DataContext>();


var app = builder.Build();

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
