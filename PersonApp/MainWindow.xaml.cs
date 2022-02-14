using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using PersonApp.Models;

namespace PersonApp
{
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("HELLLLOOO");
            people.Add(new Person { FirstName = "John", LastName = "Doe" });
            people.Add(new Person { FirstName = "Joe", LastName = "Smith" });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm" });
            peopleComboBox.ItemsSource = people;
        }
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameTxtBx.Text} {lastNameTxtBx.Text}");
        }

        private void PeopleComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = peopleComboBox.SelectedIndex;
            firstNameTxtBx.Text = people[index].FirstName;
            lastNameTxtBx.Text = people[index].LastName;
        }
    }
}