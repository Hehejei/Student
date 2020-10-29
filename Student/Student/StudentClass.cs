using Microsoft.EntityFrameworkCore;
using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Student.Controllers
{
    public class StudentClass
    {
        private readonly AppDbContext ctx; 
        public Guid ChangeStudent(Models.Student entity)
        {
            if (entity.Id == default)
                ctx.Entry(entity).State = EntityState.Added;
            else
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
            return entity.Id;
        }

        public void RemoveStudent(Models.Student en)
        {
            ctx.studentss.Remove(en);
            ctx.SaveChanges();
        }

        public StudentClass(AppDbContext context)
        {
            ctx = context;
        }

        public IQueryable<Models.Student> GetStudents()
        {
            return ctx.studentss.OrderBy(x => x.Name);
        }

        public Models.Student GetStudentById(Guid id)
        {
            return ctx.studentss.Single(x => x.Id == id);
        }
  
    }
}
