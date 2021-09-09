using System.Collections.Generic;
using System.Windows.Input;

namespace WinUWP
{
    public class MainWindowVM : PropertyNotifier
    {
        public string Text => "Customers";
        //public string Text2 => "Managers";

        private ObservableCollection<Person> people = new ObservableCollection<Person>();
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
                Age = App.Random.Next(20, 40)
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
