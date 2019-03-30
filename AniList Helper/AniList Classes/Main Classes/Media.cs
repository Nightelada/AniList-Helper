using AniList_Helper.AniList_Classes.Enums;
using AniList_Helper.AniList_Classes.Helper_Classes;
using System.Collections.Generic;

namespace AniList_Helper.AniList_Classes.Main_Classes
{
    public class Media
    {
        public int Id { get; set; }
        public int IdMal { get; set; }
        public MediaTitle Title { get; set; }
        public MediaType Type { get; set; }
        public MediaFormat Format { get; set; }
        public MediaStatus Status { get; set; }
        public string Description { get; set; }
        public FuzzyDate StartDate { get; set; }
        public FuzzyDate EndDate { get; set; }
        public MediaSeason Season { get; set; }
        public int? Episodes { get; set; }
        public int? Duration { get; set; }
        public int? Chapters { get; set; }
        public int? Volumes { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool IsLicensed { get; set; }
        public MediaSource Source { get; set; }
        public string Hashtag { get; set; }
        public MediaTrailer Trailer { get; set; }
        public int UpdatedAt { get; set; }
        public MediaCoverImage CoverImage { get; set; }
        public string BannerImage { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Synonyms { get; set; }
        public int AverageScore { get; set; }
        public int MeanScore { get; set; }
        public int Popularity { get; set; }
        public int Trending { get; set; }
        public List<MediaTag> Tags { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsAdult { get; set; }
        public AiringSchedule NextAiringEpisode { get; set; }
        public List<MediaExtrenalLink> ExternalLinks { get; set; }
        public List<MediaStreamingEpisode> StreamingEpisodes { get; set; }
        public List<MediaRank> Rankings { get; set; }
        public MediaList MediaListEntry { get; set; }
        public MediaStats Stats { get; set; }
        public string SiteUrl { get; set; }
        public bool AutoCreateForumThread { get; set; }
        public string ModNotes { get; set; }
    }
}
