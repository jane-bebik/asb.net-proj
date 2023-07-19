using LabWebApp.Data;
using Microsoft.EntityFrameworkCore;

// ...

public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();

    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("<secret>")));
}

// ...

