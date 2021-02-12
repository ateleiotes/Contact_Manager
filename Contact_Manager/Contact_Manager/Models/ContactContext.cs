using System;
using Microsoft.EntityFrameworkCore;

namespace Contact_Manager.Models
{
    public class ContactContext : DbContext
    {
        // Constructor that passes a parameter to base parent constructor
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }
        // Accessors and mutators for DbSet of Contacts and Categories with modelBuilder param
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData(

                new Contact
                {
                    ContactId = 1,
                    Firstname = "Bruce",
                    Lastname = "Wayne",
                    Phone = "416-123-6456",
                    Email = "bruce@domain.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                  new Contact
                  {
                      ContactId = 2,
                      Firstname = "Jane",
                      Lastname = "Doe",
                      Phone = "416-345-1237",
                      Email = "janedoe@domain.com",
                      CategoryId = 2,
                      DateAdded = DateTime.Now
                  },
                    new Contact
                    {
                        ContactId = 3,
                        Firstname = "Jane",
                        Lastname = "Wats",
                        Phone = "647-860-1678",
                        Email = "wats@domain.com",
                        CategoryId = 1,
                        DateAdded = DateTime.Now
                    }

             );
        }
    }
}
