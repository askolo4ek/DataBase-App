using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data;
using System.Collections.ObjectModel;

namespace SchedulingBase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connection connection;
        private ObservableCollection<SubroutineEntry> subroutines;
        private ObservableCollection<SubroutineEntry> Subroutines
        {
            get { return subroutines; }
            set { subroutines = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            connection.Connect(HostBox.Text, DbNameBox.Text, UsernameBox.Text, PasswordBox.Password);
            if (connection.connected)
            {
                ConnectButton.IsEnabled = false;
                DisConnectButton.IsEnabled = true;

                Subroutines = new ObservableCollection<SubroutineEntry>();

                try
                {
                    DataTable subs = connection.SendRequest("select routine_name, routine_type from information_schema.routines where routine_schema not in ('pg_catalog', 'information_schema') order by routine_name;");
                    Subroutines = new ObservableCollection<SubroutineEntry>();
                    for (int i = 0; i < subs.Rows.Count; i++)
                    {
                        Subroutines.Add(new SubroutineEntry(subs.Rows[i].Field<string>(0), subs.Rows[i].Field<string>(1)));

                        DataTable args = connection.SendRequest("select p.data_type, p.parameter_name from information_schema.routines r left join information_schema.parameters p on r.specific_schema = p.specific_schema and r.specific_name = p.specific_name where r.routine_schema not in ('pg_catalog', 'information_schema') AND p.parameter_mode = 'IN' AND r.routine_name = \'" + Subroutines[i].Name + "\' order by p.ordinal_position;");
                        for (int j = 0; j < args.Rows.Count; j++)
                        {
                            Subroutines[i].Arguments.Add(new ArgumentEntry(args.Rows[j].Field<string>(0), args.Rows[j].Field<string>(1)));
                        }
                    }
                    subsBox.ItemsSource = Subroutines;
                }
                catch (Exception ee)
                {
                    // TODO: Убрать ненужный try-catch
                    Console.WriteLine(ee.Message);
                }
            }
        }

        private void DisConnectButton_Click(object sender, RoutedEventArgs e)
        {
            connection.Disconnect();
            if (!connection.connected)
            {
                ConnectButton.IsEnabled = true;
                DisConnectButton.IsEnabled = false;
            }
        }

        private void subsBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ExecutorWindow window = new ExecutorWindow(((SubroutineEntry)((ListBox)sender).SelectedItem).Type, ((SubroutineEntry)((ListBox)sender).SelectedItem).Name);
            window.ArgIC.ItemsSource = ((SubroutineEntry)((ListBox)sender).SelectedItem).Arguments;
            window.Title = ((SubroutineEntry)((ListBox)sender).SelectedItem).Name;
            window.Show();
        }

        private void ProjectTableButton_Click(object sender, RoutedEventArgs e)
        {
            OutputWindow window = new OutputWindow();
            window.dgrid.ItemsSource = connection.SendRequest("SELECT * FROM Project ORDER BY ID").DefaultView;
            window.Title = "Table Project";
            window.Show();
        }

        private void WorkDayTableButton_Click(object sender, RoutedEventArgs e)
        {
            OutputWindow window = new OutputWindow();
            window.dgrid.ItemsSource = connection.SendRequest("SELECT * FROM WorkDay ORDER BY ID").DefaultView;
            window.Title = "Table WorkDay";
            window.Show();
        }

        private void TaskTableButton_Click(object sender, RoutedEventArgs e)
        {
            OutputWindow window = new OutputWindow();
            window.dgrid.ItemsSource = connection.SendRequest("SELECT * FROM Task ORDER BY ID").DefaultView;
            window.Title = "Table Task";
            window.Show();
        }

        private void ManagerTableButton_Click(object sender, RoutedEventArgs e)
        {
            OutputWindow window = new OutputWindow();
            window.dgrid.ItemsSource = connection.SendRequest("SELECT * FROM Manager ORDER BY ID").DefaultView;
            window.Title = "Table Manager";
            window.Show();
        }

        private void WorkerTableButton_Click(object sender, RoutedEventArgs e)
        {
            OutputWindow window = new OutputWindow();
            window.dgrid.ItemsSource = connection.SendRequest("SELECT * FROM Worker ORDER BY ID").DefaultView;
            window.Title = "Table Worker";
            window.Show();
        }

        private void DepartmentTableButton_Click(object sender, RoutedEventArgs e)
        {
            OutputWindow window = new OutputWindow();
            window.dgrid.ItemsSource = connection.SendRequest("SELECT * FROM Department ORDER BY ID").DefaultView;
            window.Title = "Table Department";
            window.Show();
        }
    }
}
