using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrmiJo.Model
{
    public class TitleData
    {
        public string Id { get; set; }
        public string Title { set; get; }
        public string OriginalTitle { get; set; }
        public string FullTitle { set; get; }
        public string Year { set; get; }
        public string ReleaseDate { set; get; }
        public string RuntimeMins { set; get; }
        public string RuntimeStr { set; get; }
        public string Plot { set; get; } 
        public string PlotLocal { set; get; }
        public bool PlotLocalIsRtl { set; get; }
        public string Awards { set; get; }
        public string Image { get; set; }
        public string Type { set; get; }
        public string Directors { set; get; }
        public List<StarShort> DirectorList { get; set; }
        public string Writers { set; get; }
        public List<StarShort> WriterList { get; set; }
        public string Stars { set; get; }
        public List<StarShort> StarList { get; set; }
        public List<ActorShort> ActorList { get; set; }
        public FullCastData FullCast { get; set; }
        public string Genres { set; get; }
        public List<KeyValueItem> GenreList { get; set; }
        public string Companies { get; set; }
        public List<CompanyShort> CompanyList { get; set; }
        public string Countries { set; get; }
        public List<KeyValueItem> CountryList { set; get; }
        public string Languages { set; get; }
        public List<KeyValueItem> LanguageList { set; get; }
        public string ContentRating { get; set; }
        public string IMDbRating { get; set; }
        public string IMDbRatingVotes { get; set; }
        public string MetacriticRating { set; get; }
        public RatingData Ratings { set; get; }
        public BoxOfficeShort BoxOffice { get; set; }
        public string Tagline { get; set; }
        public string Keywords { get; set; }
        public List<string> KeywordList { get; set; }
        public List<SimilarShort> Similars { get; set; }
        public TvSeriesInfo TvSeriesInfo { get; set; }
        public TvEpisodeInfo TvEpisodeInfo { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class PosterDataItem
    {
        public string Id { get; set; }
        public string Link { get; set; }
        public double AspectRatio { get; set; }
        public string Language { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class TvSeriesInfo
    {
        public string YearEnd { set; get; }
        public string Creators { set; get; }
        public List<StarShort> CreatorList { get; set; }
        public List<string> Seasons { get; set; }
    }

    public class TvEpisodeInfo
    {
        public string SeriesId { get; set; }
        public string SeriesTitle { get; set; }
        public string SeriesFullTitle { get; set; }
        public string SeriesYear { get; set; }
        public string SeriesYearEnd { get; set; }

        public string SeasonNumber { get; set; }
        public string EpisodeNumber { get; set; }

        public string PreviousEpisodeId { get; set; }
        public string NextEpisodeId { get; set; }
    }

    public class SimilarShort
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string IMDbRating { get; set; }
    }

    public class StarShort
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class BoxOfficeShort
    {
        public string Budget { get; set; }
        public string OpeningWeekendUSA { get; set; }
        public string GrossUSA { get; set; }
        public string CumulativeWorldwideGross { get; set; }
    }

    public class CompanyShort
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class KeyValueItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class ActorShort
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string asCharacter { get; set; }
    }

    public class CastShort
    {
        public string Job { get; set; }
        public List<CastShortItem> Items { get; set; }
    }
    public class CastShortItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class FullCastData
    {
        public string ImDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public CastShort Directors { get; set; }
        public CastShort Writers { get; set; }
        public ActorShort Actors { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RatingData
    {
        public string ImDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string ImDb { get; set; }
        public string Metacritic { get; set; }
        public string TheMovieDb { get; set; }
        public string RottenTomatoes { get; set; }
        public string FilmAffinity { get; set; }
        public string ErrorMessage { get; set; }

    }

}

