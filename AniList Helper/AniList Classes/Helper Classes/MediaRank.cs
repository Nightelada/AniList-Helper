using AniList_Helper.AniList_Classes.Enums;

namespace AniList_Helper.AniList_Classes.Helper_Classes
{
    public class MediaRank
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public MediaRankType Type { get; set; }
        public MediaFormat Format { get; set; }
        public int? Year { get; set; }
        public MediaSeason? Season { get; set; }
        public bool? AllTime { get; set; }
        public string Context { get; set; }
    }
}
