using System.Collections.Generic;
using System.Runtime.Serialization;

namespace YTS.Common.Contacts
{
    [DataContract(Name = "Movie")]
    public class Movie
    {
        [DataMember(Name = "id")]
        public int ID { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "imdb_code")]
        public string IMDB_Code { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "title_english")]
        public string Title_English { get; set; }

        [DataMember(Name = "title_long")]
        public string Title_Long { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "year")]
        public int Year { get; set; }

        [DataMember(Name = "rating")]
        public double Rating { get; set; }

        [DataMember(Name = "runtime")]
        public int Runtime { get; set; }

        [DataMember(Name = "genres")]
        public List<string> Genres { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        [DataMember(Name = "description_full")]
        public string Description_full { get; set; }

        [DataMember(Name = "synopsis")]
        public string Synopsis { get; set; }

        [DataMember(Name = "yt_trailer_code")]
        public string Trailer_Code { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "mpa_rating")]
        public string MPA_rating { get; set; }

        [DataMember(Name = "background_image")]
        public string Background_image { get; set; }

        [DataMember(Name = "background_image_original")]
        public string Background_image_original { get; set; }

        [DataMember(Name = "small_cover_image")]
        public string Small_cover_image { get; set; }

        [DataMember(Name = "medium_cover_image")]
        public string Medium_cover_image { get; set; }

        [DataMember(Name = "large_cover_image")]
        public string Large_cover_image { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "torrents")]
        public List<Torrent> Torrents { get; set; }

        [DataMember(Name = "date_uploaded")]
        public string Date_Uploaded { get; set; }

        [DataMember(Name = "date_uploaded_unix")]
        public int Date_Uploaded_Unix { get; set; }
    }
}
