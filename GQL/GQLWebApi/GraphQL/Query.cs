using GQLWebApi.Data;
using GQLWebApi.Models;

namespace GQLWebApi.GraphQL
{
    public class Query
    {
        public IQueryable<Platform>  GetPlatforms([ScopedService] AppDbContext appDbContext)
        {
            return appDbContext.Platforms;
        }
    }
}
