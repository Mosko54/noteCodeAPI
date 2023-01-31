﻿using Microsoft.EntityFrameworkCore;
using noteCodeAPI.Models;
using noteCodeAPI.Tools;

namespace noteCodeAPI.Repositories
{
    public class NoteRepository : BaseRepository<Note>
    {
        private
        public NoteRepository(DataDbContext dbContext) : base(dbContext)
        {
        }

        public override bool Delete(Note element)
        {
            _dbContext.Notes.Remove(element);
            return Update();
        }

        public override List<Note> GetAll()
        {
            return _dbContext.Notes.Include(n => n.Tags).ToList();        
        }

        public override Note? GetById(int id)
        {
            return _dbContext.Notes.Include(n => n.Tags).FirstOrDefault(n => n.Id == id);
        }

        public List<Note> GetAllByUserId(int userId)
        {
            return _dbContext.Notes.Include(n => n.Tags).Include(n => n.User).Where(n => n.User.Id == userId).ToList();
        }

        public override bool Save(Note element)
        {
            _dbContext.Notes.Add(element);
            return Update();
        }
    }
}