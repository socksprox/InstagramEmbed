namespace InstagramEmbedForDiscord.Models.Entities
{
    public class Post
    {
        public int ID { get; set; }
        public string RawUrl { get; set; } = string.Empty;
        public string InstagramID { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<SnapSaveEntry> SnapSaveEntries { get; set; } = [];

    }

    public class SnapSaveEntry
    {
        public int ID { get; set; }
        public int Order { get; set; }
        public string MediaUrl { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public MediaType MediaType { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

    public enum MediaType
    {
        None,
        Video,
        Image,
    }
}
