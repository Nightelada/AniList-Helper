using System.Collections.Generic;

namespace AniList_Helper.AniList_Classes.Helper_Classes
{
    public class MediaStats
    {
        public List<ScoreDistribution> ScoreDistribution { get; set; }
        public List<StatusDistribution> StatusDistribution { get; set; }
        public List<AiringProgression> AiringProgression { get; set; }
    }
}
