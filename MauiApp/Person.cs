namespace MauiApp5
{
    public class Person : PropertyNotifier
    {
        private string name = string.Empty;
        public string Name
        {
            get => this.name;
            set => this.SetProperty(ref this.name, value);
        }

        private int age;
        public int Age
        {
            get => this.age;
            set => this.SetProperty(ref this.age, value);
        }

        //private int money = System.Random.Shared.Next(10, 1000);
        //public int Money
        //{
        //    get => this.money;
        //    set => this.SetProperty(ref this.money, value);
        //}
    }
}
