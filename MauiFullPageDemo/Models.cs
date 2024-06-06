using System.Collections.ObjectModel;

namespace MauiDemo
{
    public class Person(string name, int age)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;

        public Brush FavoriteColor { get; } = new SolidColorBrush(new Color(
            100 + Random.Shared.Next() % 100,
            100 + Random.Shared.Next() % 100,
            100 + Random.Shared.Next() % 100));
    }

    public class ViewModel
    {
        public ObservableCollection<Person> Family { get; } = new();
        public ObservableCollection<Person> Students { get; } = new();
        public ObservableCollection<Person> Employees { get; } = new();

        public ViewModel()
        {
            Family.Add(new Person("Family Member 1", 10));
            Family.Add(new Person("Family Member 2", 15));
            Family.Add(new Person("Family Member 3", 20));
            Family.Add(new Person("Family Member 4", 25));
            Family.Add(new Person("Family Member 5", 30));

            Students.Add(new Person("Student 1", 10));
            Students.Add(new Person("Student 2", 15));
            Students.Add(new Person("Student 3", 20));
            Students.Add(new Person("Student 4", 25));
            Students.Add(new Person("Student 5", 30));

            // Leave empty to show empty CollectionView
            // Employees.Add(new Person("Employee 1", 10));
            // Employees.Add(new Person("Employee 2", 15));
            // Employees.Add(new Person("Employee 3", 20));
            // Employees.Add(new Person("Employee 4", 25));
            // Employees.Add(new Person("Employee 5", 30));
        }
    }
}
