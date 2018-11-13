using Caliburn.Micro.Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Learning.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _firstName = "";
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            this.People.Add(new PersonModel() { FirstName = "123", LastName = "456" });
            this.People.Add(new PersonModel() { FirstName = "234", LastName = "678" });
            this.People.Add(new PersonModel() { FirstName = "345", LastName = "789" });
            ActivateItem(new NewChildViewModel());
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public BindableCollection<PersonModel> People
        {
            get
            {
                return _people;
            }
            set
            {
                _people = value;
            }
        }

        public PersonModel SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearName(string firstName, string lastName)
        {
            return !string.IsNullOrWhiteSpace(firstName) || !string.IsNullOrWhiteSpace(lastName);
        }

        public void ClearName(string firstName, string lastName)
        {
            this.FirstName = "";
            this.LastName = "";
        }

        public void LoadPageOne(string firstName,string lastName)
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo(string firstName, string lastName)
        {
            ActivateItem(new SecoundChildViewModel());
        }
    }
}
