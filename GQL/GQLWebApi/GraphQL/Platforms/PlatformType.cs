using GQLWebApi.Models;

namespace GQLWebApi.GraphQL.Platforms
{
    public class PlatformType: ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            //Can turn off projection
            //descriptor.Field(x => x.Commands)
            //    .IsProjected(false);

            ///Apply custom type
            ///<see cref="LicenseKeyType"/>
            descriptor.Field(x => x.LicenseKey)
                .Type<LicenseKeyType>();

            base.Configure(descriptor);
        }
    }
}
