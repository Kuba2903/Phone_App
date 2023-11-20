using Phone_App.DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_App.Models
{
    public class ContactsBookModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Number { get; set; }

        public string? Email { get; set; }
        public string? Address { get; set; }
    }

    public static class ContactsMapper
    {
        public static ContactsBookModel EntityToModel(ContactsEntity entity)
        {
            return new ContactsBookModel()
            {
                Id = entity.ID,
                Name = entity.Name,
                Number = entity.Number,
                Email = entity.Email,
                Address = entity.Address
            };
        }

        public static ContactsEntity ModelToEntity(ContactsBookModel model)
        {
            return new ContactsEntity()
            {
                ID = model.Id,
                Name = model.Name,
                Number = model.Number,
                Email = model.Email,
                Address = model.Address
            };
        }
    }
}
