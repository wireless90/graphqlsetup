using GQLWebApi.Models;

namespace GQLWebApi.GraphQL.Commands
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            /* How to change field name */
            descriptor
                .Field(x => x.CommandLine)
                .Name("CmdLine");

            base.Configure(descriptor);
        }
    }
}
