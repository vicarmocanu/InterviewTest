using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewModel.Model
{
    class SalePerson
    {
        private int id;
        private string lastName;
        private string firstName;
        private string userName;
        private string pass;
        private string email;
        private int phoneNo;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int PhoneNo
        {
            get
            {
                return phoneNo;
            }

            set
            {
                phoneNo = value;
            }


        }
        public SalePerson() { }
    }
}
