using System.Reflection;
using AutoWrapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RecipeBook.Core.Extensions;
using RecipeBook.Data;
using RecipeBook.DataAccess.Repository;

namespace RecipeBook.Application
{
    public class DependencyInjectionOptions
    {
        public Assembly[]? AutoMapperAssemblies { get; set; }
    }

    public static class DependencyInjection
    {
        private static readonly bool IsDevelopment = EnvironmentExtension.IsDevelopment;
        private static readonly bool IsStaging = EnvironmentExtension.IsStaging;
        private static readonly bool IsProduction = EnvironmentExtension.IsPreProduction;
        private static readonly bool IsPreProduction = EnvironmentExtension.IsPreProduction;
        public static IServiceCollection ConfigureDependencyInjections(this IServiceCollection services,
            IConfiguration configuration, DependencyInjectionOptions options)
        {
            //var contentRoot = Environment.Con;

            services.AddMemoryCache();
            services
                .ConfigureDatabase(configuration)
                .AddHttpClient()
                .AddRepositories()
                .ConfigureAutoMapper(options.AutoMapperAssemblies)
                .ConfigureServices()
                .ConfigureCors()
                .ConfigureRequestBodyLimit()
                .AddMediator();
            return services;
        }

        public static IServiceCollection ConfigureRequestBodyLimit(this IServiceCollection services)
        {
            const int maxBodyLimit = 5000000;//5mb
            const int maxFileSizeLimit = 40000000; //40mb
            const int maxLimit = maxBodyLimit + maxFileSizeLimit;
            const long multipartBodyLengthLimit = maxLimit;
            services.Configure<IISServerOptions>(options =>
            {
                options.MaxRequestBodySize = multipartBodyLengthLimit;

            });

            services.Configure<KestrelServerOptions>(options =>
            {
                options.Limits.MaxRequestBodySize = multipartBodyLengthLimit; // if don't set default value is: 30 MB  41MB
            });

            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = maxLimit;
                x.MultipartBodyLengthLimit = multipartBodyLengthLimit; // if don't set default value is: 128 MB
                x.MultipartHeadersLengthLimit = maxLimit;
            });
            return services;
        }

        public static IApplicationBuilder ConfigureAutoWrapperMiddleware(this IApplicationBuilder builder)
        {
            builder.UseApiResponseAndExceptionWrapper(new AutoWrapperOptions
            {
                //UseApiProblemDetailsException = true,
                IgnoreNullValue = false,
                ShowStatusCode = true,
                ShowIsErrorFlagForSuccessfulResponse = true,
                IsDebug = IsDevelopment || IsStaging,
                EnableExceptionLogging = false,
                EnableResponseLogging = false,
                LogRequestDataOnException = false,
                ShouldLogRequestData = false,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                UseCustomExceptionFormat = false,
            });

            return builder;
        }


        public static IServiceCollection AddMediator(this IServiceCollection services)
        {

            services
                .AddMediatR(Assembly.GetExecutingAssembly());


            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            // i assume your service interfaces inherit from IRepositoryBase<>
            Assembly ass = typeof(IRepositoryIdentifier).GetTypeInfo().Assembly;

            // get all concrete types which implements IRepositoryIdentifier
            var allRepositories = ass.GetTypes().Where(t =>
                t.GetTypeInfo().IsClass &&
                !t.IsGenericType &&
                !t.GetTypeInfo().IsAbstract &&
                typeof(IRepositoryIdentifier).IsAssignableFrom(t));

            foreach (var type in allRepositories)
            {
                var allInterfaces = type.GetInterfaces();
                var mainInterfaces = allInterfaces.Where(t => typeof(IRepositoryIdentifier) != t && (!t.IsGenericType || t.GetGenericTypeDefinition() != typeof(IRepository<>)));
                foreach (var itype in mainInterfaces)
                {
                    if (allRepositories.Any(x => x != type && itype.IsAssignableFrom(x)))
                    {
                        throw new Exception("The " + itype.Name + " type has more than one implementations, please change your filter");
                    }
                    services.AddScoped(itype, type);
                }
            }
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
        private static IServiceCollection ConfigureAutoMapper(this IServiceCollection services, Assembly[] assemblies)
        {
            services.AddAutoMapper(assemblies);
            return services;
        }
        private static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            //services.AddScoped<AuthService>();

            return services;
        }

        private static IServiceCollection ConfigureDatabase(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("DefaultPostgre")));

            return services;
        }

        public static IServiceCollection ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:4200");
                    });
            });
            return services;
        }

    }
}
