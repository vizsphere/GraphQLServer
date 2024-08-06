using GraphQLServer.GraphQLTypes.DataLoader;
using GraphQLServer.GraphQLTypes.Extensions;
using GraphQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLServer.GraphQLTypes
{
    public class Query
    {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
            context.Speakers.ToListAsync();

        public Task<Speaker> GetSpeakerAsync(int id,SpeakerByIdDataLoader dataLoader,
                                                CancellationToken cancellationToken) =>
                                                dataLoader.LoadAsync(id, cancellationToken);

    }

}
