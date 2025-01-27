using Microsoft.EntityFrameworkCore;
using Sakshi_Web_APP.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//ApplicationDbContext is a class middle layer which connect our dtabase to project 
builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(
	builder.Configuration.GetConnectionString("Default_connection")
	));

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


app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
