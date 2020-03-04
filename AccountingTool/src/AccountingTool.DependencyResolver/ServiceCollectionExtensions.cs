using System;
using System.Linq;
using System.Reflection;
using AccountingTool.Common;
using AccountingTool.Common.Contracts;
using AccountingTool.DAL.EF;
using AccountingTool.DAL.EF.Context;
using AccountingTool.DAL.Models.Entities;
using AccountingTool.DAL.Repositories.Contracts;
using AccountingTool.DAL.Repositories.Implementation;
using AccountingTool.Domain.QueryHandler.Position;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AccountingTool.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString, builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                }));

            services.AddIdentity<User, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            var assembly = typeof(GetPositionsQueryHandler).Assembly;
            services.AddMediatR(assembly);

            services.AddScoped<IDataInitializer, EFDataInitializer>();

            services.AddScoped(typeof(IAsyncRepository<>), typeof(EFRepositoryAsync<>));

            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            services.AddSingleton<IMapper, AccountingToolAutoMapper>();
        }
    }
    public static class AppDomainExtensions
    {
        public static Assembly GetAssemblyByName(this AppDomain domain, string assemblyName)
        {
            return domain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == assemblyName);
        }
    }
}