﻿using System.ComponentModel.DataAnnotations.Schema;

namespace noteCodeAPI.Models
{
    [Table("codetag")]
    public class Codetag
    {
        private int id;
        private string? name;
        private List<NotesTags> notes;

        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("name")]
        public string? Name { get => name; set => name = value ?? throw new ArgumentNullException(nameof(value)); }

        public List<NotesTags> Notes { get => notes; set => notes = value; }
    }
}