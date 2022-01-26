using Models.Enum;

#nullable disable

namespace Models.Entities
{
    public partial class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public AlbumType AlbumType { get; set; }
        public int Stock { get; set; }

    }
}