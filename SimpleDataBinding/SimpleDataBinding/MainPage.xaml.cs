using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleDataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var person = new Person("Devlin", "0920 545 4005", "devlin@xamarin.com");
            BindingContext = person;
            InitializeComponent();
        }

        private class Person
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public Person(string name, string phone, string email)
            {
                Name = name;
                Phone = phone;
                Email = email;
            }
        }
    }
}