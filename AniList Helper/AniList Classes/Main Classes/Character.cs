using AniList_Helper.AniList_Classes.Helper_Classes;

namespace AniList_Helper.AniList_Classes.Main_Classes
{
    public class Character
    {
        public int Id { get; set; }
        public CharacterName Name { get; set; }
        public CharacterImage Image { get; set; }
        public string Description { get; set; }
        public bool IsFavorite { get; set; }
        public string SiteUrl { get; set; }
    }
}
