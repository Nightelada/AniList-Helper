using AniList_Helper.AniList_Classes.Main_Classes;
using GraphQL.Client;
using GraphQL.Common.Request;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace AniList_Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var aniListRequest = new GraphQLRequest();
            string query = @"query ($id: Int) {
  Media (id: $id, type: ANIME) {
    id
    idMal
    title {
        romaji
        english
        native
        userPreferred
    }
    type
    format
    status
    description
    startDate {
        year
        month
        day
    }
    endDate {
        year
        month
        day
    }
    season
    episodes
    duration
    chapters
    volumes
    countryOfOrigin
    isLicensed
    source
    hashtag
    trailer {
        id
        site
    }
    updatedAt
    coverImage {
        large
        medium
    }
    bannerImage
    genres
    synonyms
    averageScore
    meanScore
    popularity
    trending
    tags {
        id
        name
        description
        category
        rank
        isGeneralSpoiler
        isMediaSpoiler
        isAdult
    }
    isFavourite
    isAdult
    nextAiringEpisode {
        id
        airingAt
        timeUntilAiring
        episode
        mediaId
    }
    externalLinks {
        id
        url
        site
    }
    streamingEpisodes {
        title
        thumbnail
        url
        site
    }
    rankings {
        id
        rank
        type
        format
        year
        season
        allTime
        context
    }
    mediaListEntry {
        id
        userId
        mediaId
        status
        score
        progress
        progressVolumes
        repeat
        priority
        private
        notes
        hiddenFromStatusLists
        customLists
        advancedScores
        startedAt {
            year
            month
            day
        }
        completedAt {
            year
            month
            day
        }
        updatedAt
        createdAt
    }
    stats {
        scoreDistribution {
            score
            amount
        }
        statusDistribution {
            status
            amount
        }
        airingProgression {
            episode
            score
            watching
        }
    }
    siteUrl
    autoCreateForumThread
    modNotes
  }
}";

            var charactersQuery = @"query ($id: Int) {
  Media (id: $id, type: ANIME) {
     characters {
           edges {
               node {
                   id
                   name {
                       first
                       last
                       native
                       alternative
                   }
                   image {
                       large
                       medium
                   }
                   description
                   siteUrl
               }
               id
               role
               voiceActors {
                   id
                   name {
                       first
                       last
                       native
                   }
                   language
                   image {
                       large
                       medium
                   }
                   description
                   isFavourite
                   siteUrl
               }
               favouriteOrder
           }
            nodes {
                   id
                   name {
                       first
                       last
                       native
                       alternative
                   }
                   image {
                       large
                       medium
                   }
                   description
                   siteUrl
               }
           pageInfo {
               total
               perPage
               currentPage
               lastPage
               hasNextPage
           }
        }
    }
}";

            var staffQuery = @"";
            var studiosQuery = @"";
            

            var variables = new
            {
                id = 21459
            };
            aniListRequest.Query = query;
            aniListRequest.Variables = variables;


            var graphQLClient = new GraphQLClient("https://graphql.anilist.co");
            var graphQLResponse = await graphQLClient.PostAsync(aniListRequest);

            var errors = graphQLResponse.Errors;
            var romanjiTitle = graphQLResponse.Data.Media.title.romaji.Value;

            var test = graphQLResponse.GetDataFieldAs<Media>("Media");

            /*
            var aniListRequest2 = new GraphQLRequest();
            var variables2 = new
            {
                id = 21459
            };
            aniListRequest2.Query = charactersQuery;
            aniListRequest2.Variables = variables2;
            var graphQLClient2 = new GraphQLClient("https://graphql.anilist.co");
            var graphQLResponse2 = await graphQLClient2.PostAsync(aniListRequest2);
            var test2 = graphQLResponse2.Data.Media.characters.nodes;
            var test3 = graphQLResponse2.GetDataFieldAs<Character>("nodes");
            */

            //File.WriteAllText(test.Id + ".json", JsonConvert.SerializeObject(test, Formatting.Indented));

            //txtBlockTest.Text = json;

            // JUser testAnime = new JUser();
            // string asd = JsonOperations.GetJsonResource(url);
            // testAnime = JsonConvert.DeserializeObject<JUser>(asd);
            // File.WriteAllText(testAnime.Username + ".json", JsonConvert.SerializeObject(testAnime, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
