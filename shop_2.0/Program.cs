using System.Text.Json.Serialization;
using shop_2._0.JsonConverters.Converters;
using shop_2._0.JsonConverters.Policies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation()
    .AddJsonOptions(option =>
    {
        option.JsonSerializerOptions.PropertyNamingPolicy = new SnakeNamePolicy();
        option.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowReadingFromString |
                                                      JsonNumberHandling.AllowNamedFloatingPointLiterals;
        option.JsonSerializerOptions.Converters.Add(new DoubleJsonConverter());
        option.JsonSerializerOptions.Converters.Add(new ProductTypeJsonConverter());
    });

    
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();