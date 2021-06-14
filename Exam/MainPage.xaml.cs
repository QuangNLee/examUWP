using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Windows.ApplicationModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Exam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public class Employee
		{
            public string Name { get; set; }
            public string Role { get; set; }
            public int Birthyear { get; set; }
		}
        public MainPage()
        {
            this.InitializeComponent();
        }

		private void Read_File_Click(object sender, RoutedEventArgs e)
        {
            Employee employee1 = JsonConvert.DeserializeObject<Employee>(File.ReadAllText(@"F:\FPT\2nd\Sem 3\WFP\Exam\employee_list.json"));

            using (StreamReader file = File.OpenText(@"F:\FPT\2nd\Sem 3\WFP\Exam\employee_list.json"))
			{
                JsonSerializer serializer = new JsonSerializer();
                Employee employee2 = (Employee)serializer.Deserialize(file, typeof(Employee));
			}
		}
	}
}
