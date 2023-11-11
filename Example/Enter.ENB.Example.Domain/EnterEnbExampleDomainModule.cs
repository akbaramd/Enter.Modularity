
using Enter.ENB.Domain;
using Enter.ENB.Modularity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Enter.ENB.Example.Domain;

[DependsOnModules(typeof(EnterEnbDddDomainModule))]
public class EnterEnbExampleDomainModule : EntModule 
{
    public override void ConfigureServices(IServiceCollection services)
    {
        
    }

    public override void Initialize(IApplicationBuilder services)
    {
    }
}