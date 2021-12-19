using GQLWebApi.Models;

namespace GQLWebApi.GraphQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor
                .Field(x => x.CommandLine)
                .Name("CmdLine");

            base.Configure(descriptor);
        }
    }
}
