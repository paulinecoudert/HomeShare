using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Models
{
    public class ContactModel
    {
        private string _nom, _email, _telephone, _information;

        [Required]
        [MaxLength(50)]
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }
        [Required]
        [MaxLength(323)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        [Required]
        [MaxLength(12)]
        public string Telephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
            }
        }
        [Required]
        [MaxLength(150)]
        public string Information
        {
            get
            {
                return _information;
            }

            set
            {
                _information = value;
            }
        }
    }
}
