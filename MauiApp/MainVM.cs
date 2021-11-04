using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp5
{
    public class MainViewModel : PropertyNotifier
    {
        public string Text => "Customers";
        //public string Text2 => "Managers";

        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public IList<Person> People => this.people;

        public MainViewModel()
        {
            this.People.Add(new Person()
            {
                Name = "Bob Bobson",
                Age = 32,
            });

            this.People.Add(new Person()
            {
                Name = "Jill Jillian",
                Age = 42,
            });
        }

        private int count = 0;
        public int Count
        {
            get => this.count;
            set => this.SetProperty(ref this.count, value);
        }

        public ICommand AddPersonCommand => new DelegateCommand(this.AddPerson);

        private void AddPerson()
        {
            this.People.Add(new Person()
            {
                Name = "New Person",
                Age = App.Random.Next(20, 40)
            });
        }

        //public ICommand AddPerson2Command => new DelegateCommand(this.AddPerson2);

        //private void AddPerson2()
        //{
        //    this.People.Add(new Person()
        //    {
        //        Name = "New Person 2",
        //        Age = System.Random.Shared.Next(40, 60)
        //    });
        //}

        public ICommand AddCountCommand => new DelegateCommand(this.AddCount);

        private void AddCount()
        {
            this.Count += 1;
        }

        //public ICommand AddCount2Command => new DelegateCommand(this.AddCount2);
        //
        //private void AddCount2()
        //{
        //    this.Count += 2;
        //}

        public ICommand ClearCommand => new DelegateCommand(p =>
        {
            this.People.Clear();
        });
    }
}
