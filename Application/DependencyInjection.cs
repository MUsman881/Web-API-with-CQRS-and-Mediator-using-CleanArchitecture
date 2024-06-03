using Application.Common.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR(configuration =>
                {
                    configuration.RegisterServicesFromAssembly(assembly);
                    configuration.AddBehavior(typeof(IPipelineBehavior<,>) , typeof(Validation<,>));
                });

            services.AddValidatorsFromAssembly(assembly);

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
