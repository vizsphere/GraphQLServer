https://github.com/ChilliCream/graphql-workshop



1) Update Database Connection String  in GraphQLAppSettings.cs 

2) Opne Package Manager Console and run update-database to run initial script 


-----------------------

Query

-----------------------

// Get Speakers 
 query  getSpeakers {
    speakers {
      bio,
      name,
      id
    }
 }

 // Get Speakers name

 query GetSpeakerNames {
  speakers {
    name
  }
}


-----------------------

Mutation

-----------------------

mutation AddSpeaker {
  addSpeaker(input: {
    name: "tester"
    bio: "good at unit test"
    webSite: "http://unittest.test" }) {
    speaker {
      id
    }
  }
}
