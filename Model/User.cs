using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_book.Model
{
    public class User : BindableBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private long _contact;
        public long Contact
        {
            get { return _contact; }
            set { SetProperty(ref _contact, value); }
        }

        private List<User> _phonebook;
        public List<User> Phonebook
        {
            get { return _phonebook; }
            set { SetProperty(ref _phonebook, value); }
        }
    }
}
