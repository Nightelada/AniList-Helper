using AniList_Helper.AniList_Classes.Main_Classes;
using GraphQL.Client;
using GraphQL.Common.Request;
using Newtonsoft.Json;
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

            //File.WriteAllText(test.Id + ".json", JsonConvert.SerializeObject(test, Formatting.Indented));

            //txtBlockTest.Text = json;

            // JUser testAnime = new JUser();
            // string asd = JsonOperations.GetJsonResource(url);
            // testAnime = JsonConvert.DeserializeObject<JUser>(asd);
            // File.WriteAllText(testAnime.Username + ".json", JsonConvert.SerializeObject(testAnime, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
