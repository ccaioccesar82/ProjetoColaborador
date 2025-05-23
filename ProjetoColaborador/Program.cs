using ProjetoColaborador.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDepedencies(builder.Configuration); //Injeta as dependÍncias no sistema

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
    pattern: "{controller=Colaborador}/{action=Index}/{id?}");

ValidateMyDatabase(builder.Configuration);

app.Run();



void ValidateMyDatabase(IConfiguration configuration)
{

    string? connectionString = configuration.GetConnectionString("Connection");

    if (connectionString != null)
    {
        MigrateDatabase.EnsureDatabaseIsCreated(connectionString);
    }
}
;