using DateBook.BLL.Abstract;
using DateBook.DAL.Abstract;
using DateBook.DAL.Concrete;
using DateBook.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBook.BLL.Concrete
{
    public class NoteManager : NoteService
    {
        private BaseEntity<Note> _NoteDal;
        public NoteManager(BaseEntity<Note> noteDal)
        {
            _NoteDal = noteDal;
        }

        public void Add(Note entity)
        {
            _NoteDal.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetAll()
        {
            return _NoteDal.GetAll();
        }

        public Note GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Note entity)
        {
            throw new NotImplementedException();
        }
    }
}
