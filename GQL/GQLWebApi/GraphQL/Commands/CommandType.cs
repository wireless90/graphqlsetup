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
                .Name("cmdLine");

            /* Add a new field which is not in model at all */
            descriptor
                .Field("haveArgument")
                .Type<BooleanType>()
                .Resolve(context =>
                {
                    Command command = context.Parent<Command>();

                    if (command.CommandLine == null)
                        return false;

                    return command.CommandLine?
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Count() > 1;

                });
            base.Configure(descriptor);
        }
    }
}
