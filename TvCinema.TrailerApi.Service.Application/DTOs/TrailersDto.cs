namespace TvCinema.TrailerApi.Service.Application.DTOs
{
    public class TrailersDto
    {
        public Guid Id { get; set; }
        public string? VideoId { get; set; }
        public string? VideoTitle { get; set; }
        public string? VideoDescription { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? UploadDate { get; set; }
        public string? Link { get; set; }
        public string? LinkEmbed { get; set; }
        public string? Ytvideo { get; set; }
        public string? ImdbId { get; set; }
    }
}
