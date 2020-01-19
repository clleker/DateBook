using DateBook.DAL.Abstract;
using DateBook.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBook.DAL.Concrete
{
    public class NoteDal : BaseEntity<Note>
    {

        public void Add(Note entity)
        {
            using (DateBookDbEntities db = new DateBookDbEntities())
            {
                db.sp_InsertNote(entity.Tittle, entity.Description, entity.FinishDate, entity.PaymentAmount);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Note> GetAll()
        {
            using (DateBookDbEntities db = new DateBookDbEntities())
            {
                List<Note> notes = new List<Note>();
                foreach (var item in db.sp_SelectNotes().ToList())
                {
                    notes.Add(new Note
                    {
                        Description = item.Description,
                        FinishDate = item.FinishDate,
                        Tittle = item.Tittle,
                        PaymentAmount = item.PaymentAmount,
                        Status = item.Status,
                        Deleted = item.Deleted,
                    });
                }
                return notes;

            }
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
