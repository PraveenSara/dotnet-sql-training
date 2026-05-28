using MVC_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace MVC_Assignment.Repository
{
    public class ConcreteRepo<T> : IContactRepository<T> where T : class
    {
        ContactContext db;
        DbSet<T> dbset;

        private ContactContext _context = new ContactContext();

        public ConcreteRepo()
        {
            db = new ContactContext();
            dbset = db.Set<T>();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await _context.Contacts.ToListAsync();
        }
        public async Task CreateAsync(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(long id)
        {
            var contact = await _context.Contacts.FindAsync(id);

            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
            }
        }
    }
}