using GraphQLServer.GraphQLTypes.Extensions;
using GraphQLServer.Models;

namespace GraphQLServer.GraphQLTypes
{
    public class Mutation
    {
        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [ScopedService] ApplicationDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }

        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> DeleteSpeakerAsync(
            int id,
            [ScopedService] ApplicationDbContext context)
        {
            var speaker = await context.Speakers.FindAsync(id);
            if (speaker == null)
            {
                return new AddSpeakerPayload(
                    new UserError("Speaker not found", "SPEAKER_NOT_FOUND"));
            }

            context.Speakers.Remove(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }
    }
}
