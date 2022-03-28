using Application.Business.Services;
using Application.DataAccess;
using Application.Logic;
using Application.Logic.Interfaces.Especific;
using Application.Logic.Interfaces.Generals;
using Application.Logic.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Business
{
    public static class ServiceConfiguration
    {
        public static void AddLogicLayer(this IServiceCollection services)
        {
            services.AddScoped<IProductosRepository, ProductosRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //url absolutas
            services
                .AddSingleton<IActionContextAccessor, ActionContextAccessor>()
                .AddScoped<IUrlHelper>(x => x
                    .GetRequiredService<IUrlHelperFactory>()
                    .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext));

            AppExampleBlazorDbContext.BuildConnectionString();
        }

        public static void AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<ProductosServices>();


        }
    }
}
