using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProcessRUs.Data;
using ProcessRUs.Interfaces;
using ProcessRUs.Services;
using System.Text;

namespace ProcessRUs.Helpers
{
    public static class ApplicationServices
    {
        public static void InitAppServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IFruitService, FruitService>();
            services.AddScoped<IdentityHelper>();
            services.AddDbContext<ProcessRUsContext>(opt => opt.UseInMemoryDatabase("ProcessRUsDevDb"));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

    }
}