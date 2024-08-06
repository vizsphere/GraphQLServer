namespace GraphQLServer.GraphQLTypes
{
    public record AddSpeakerInput(
        string Name,
        string? Bio,
        string? WebSite);
}
