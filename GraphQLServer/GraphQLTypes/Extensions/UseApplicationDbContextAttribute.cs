using GraphQLServer.Models;
using HotChocolate.Types.Descriptors;
using System.Reflection;

namespace GraphQLServer.GraphQLTypes.Extensions
{
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(
            IDescriptorContext context,
            IObjectFieldDescriptor descriptor,
            MemberInfo member)
        {
            descriptor.UseDbContext<ApplicationDbContext>();
        }
    }
}
