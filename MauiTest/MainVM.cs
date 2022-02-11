using System.Collections.ObjectModel;

namespace MauiTest
{
    public class MainVM : PropertyNotifier
    {
        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

        public MainVM()
        {
            this.People.Add(new Person()
            {
                Name = "First Person",
                Age = 32
            });

            this.People.Add(new Person()
            {
                Name = "Second Person",
                Age = 64
            });
        }

        private bool check1 = false;
        public bool Check1
        {
            get => this.check1;
            set => this.SetProperty(ref this.check1, value);
        }

        private bool check2 = true;
        public bool Check2
        {
            get => this.check2;
            set => this.SetProperty(ref this.check2, value);
        }
    }
}
