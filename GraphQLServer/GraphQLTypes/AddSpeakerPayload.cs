using GraphQLServer.Models;

namespace GraphQLServer.GraphQLTypes
{
    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }

        public Speaker Speaker { get; }
    }
}
