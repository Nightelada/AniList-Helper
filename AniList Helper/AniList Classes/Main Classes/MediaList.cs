using AniList_Helper.AniList_Classes.Enums;
using AniList_Helper.AniList_Classes.Helper_Classes;

namespace AniList_Helper.AniList_Classes.Main_Classes
{
    public class MediaList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }
        public MediaListStatus Status { get; set; }
        public float Score { get; set; }
        public int Progress { get; set; }
        public int ProgressVolumes { get; set; }
        public int Repeat { get; set; }
        public int Priority { get; set; }
        public bool Private { get; set; }
        public string Notes { get; set; }
        public bool HiddenFromStatusLists { get; set; }
        public string CustomLists { get; set; } // JSON
        public string AdvancedScores { get; set; } //JSON
        public FuzzyDate StartedAt { get; set; }
        public FuzzyDate CompletedAt { get; set; }
        public int UpdatedAt { get; set; }
        public int CreatedAt { get; set; }
    }
}
