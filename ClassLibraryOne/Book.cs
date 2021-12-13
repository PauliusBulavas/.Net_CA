using System;

namespace ClassLibraryOne
{
    public struct Book
    {
        //prop tab tab
        //public int MyProperty { get; set; }
        public int TestProperty { get; private set; }

        private string _name;
        private string _id;


        //public _name {get; set;} taspats kas apacioje parasyta
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                CreateLocalId();
            }
        }

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                CreateLocalId();
            }
        }
        //taspats kas virsuje t
        public string LocalId { get; private set; } //siaip public bet galima nustatyti private, naudosime sia sintaxe visada //jei reikia metoda ikisti reikia construct

        public Book(string name, string id)
        {
            _name = name;
            _id = id;
            LocalId = string.Empty;
            CreateLocalId();
        }

        private void CreateLocalId()
        {
            LocalId = string.Format("{0}_{1},", Name, Id);
        }


    }
}
