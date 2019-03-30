using AniList_Helper.AniList_Classes.Enums;
using AniList_Helper.AniList_Classes.Helper_Classes;

namespace AniList_Helper.AniList_Classes.Main_Classes
{
    class PublicStaff
    {
        public int Id { get; set; }
        public StaffName Name { get; set; }
        public StaffLanguage Language { get; set; }
        public StaffImage Image { get; set; }
        public string Description { get; set; }
        public bool IsFavorite { get; set; }
        public string SiteUrl { get; set; }
    }
}
