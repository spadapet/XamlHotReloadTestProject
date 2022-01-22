using WpfTools;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WpfNet6
{
    public class MainWindowVM : PropertyNotifier
    {
        public string Text => "Customers";
        //public string Text2 => "Managers";

        private readonly ObservableCollection<Person> people = new();
        public IList<Person> People => this.people;

        public MainWindowVM()
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

        public ICommand AddCommand => new DelegateCommand(this.Add);

        private void Add()
        {
            this.People.Add(new Person()
            {
                Name = "New Person",
                Age = System.Random.Shared.Next(20, 40)
            });
        }

        //public ICommand AddCommand2 => new DelegateCommand(this.Add2);

        //private void Add2()
        //{
        //    this.People.Add(new Person()
        //    {
        //        Name = "New Person 2",
        //        Age = System.Random.Shared.Next(40, 60)
        //    });
        //}

        public ICommand ClearCommand => new DelegateCommand(p =>
        {
            this.People.Clear();
        });
    }
}
