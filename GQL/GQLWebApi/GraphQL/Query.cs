using GQLWebApi.Data;
using GQLWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GQLWebApi.GraphQL
{
    public class Query
    {

        public IQueryable<Platform>  GetPlatforms([Service] AppDbContext appDbContext)
        {
            return appDbContext
                .Platforms
                .Include(x => x.Commands);
        }
    }
}
