using GQLWebApi.Models;

namespace GQLWebApi.GraphQL.Platforms
{
    public class PlatformType: ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            //descriptor.Field(x => x.Commands)
            //    .IsProjected(true);

            base.Configure(descriptor);
        }
    }
}
