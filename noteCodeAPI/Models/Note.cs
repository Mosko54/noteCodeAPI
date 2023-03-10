using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace noteCodeAPI.Models
{
    [Table("note")]
    public class Note
    {
        private int id;
        private string? title;
        private string? description;
        //private string? image;
        private List<CodeSnippet>? codes;
        private List<NotesTags>? codetags;
        private UserApp? user;

        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("title")]
        public string? Title { get => title; set => title = value; }

        [Column("description")]
        public string? Description { get => description; set => description = value; }

        //[Column("image")]
        //public string? Image { get => image; set => image = value; }

        public List<NotesTags>? Codetags { get => codetags; set => codetags = value; }

        public List<CodeSnippet>? Codes { get => codes; set => codes = value; }

        [JsonIgnore]
        [ForeignKey("UserId")]
        public UserApp? User { get => user; set => user = value; }
       
        [Column("user_id")]
        public int? UserId { get; set; }

        public Note()
        {
            Codetags = new();
            Codes = new();
        }
    }
}
