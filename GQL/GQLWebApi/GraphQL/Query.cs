using GQLWebApi.Data;
using GQLWebApi.Models;

namespace GQLWebApi.GraphQL
{
    public class Query
    {
        //[UseProjection]
        public IQueryable<Platform>  GetPlatforms([Service] AppDbContext? appDbContext)
        {
            return appDbContext
                .Platforms;
        }
    }

    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(x => x.GetPlatforms(default)).UseProjection();
        }
    }
}
