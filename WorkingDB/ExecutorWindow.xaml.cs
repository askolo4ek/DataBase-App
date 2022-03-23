using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;

namespace SchedulingBase
{
    /// <summary>
    /// Логика взаимодействия для ExecutorWindow.xaml
    /// </summary>
    public partial class ExecutorWindow : Window
    {
        string type;
        string name;
        public ExecutorWindow(string Type, string Name)
        {
            InitializeComponent();
            type = Type;
            name = Name;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {   
            string query = (type == "PROCEDURE" ? "CALL " : "SELECT * FROM ") + name + "(";
            if (ArgIC.Items.Count > 0)
            {
                try
                {
                    if (((ArgumentEntry)ArgIC.Items[0]).Text.Count() == 0)
                        query += "NULL";
                    else
                        query += '\'' + ((ArgumentEntry)ArgIC.Items[0]).Text + '\'';
                } catch (Exception)
                {
                    query += "NULL";
                }
            }
            for (int i = 1; i < ArgIC.Items.Count; i++)
            {
                try {
                    if (((ArgumentEntry)ArgIC.Items[i]).Text.Count() == 0)
                        query += ", NULL";
                    else
                        query += ", \'" + ((ArgumentEntry)ArgIC.Items[i]).Text + '\'';
                    }
                catch (Exception)
                {
                    query += ", NULL";
                }
            }
            query += ")";

            DataTable table = Connection.Instance.SendRequest(query);

            OutputWindow window = new OutputWindow();
            window.dgrid.ItemsSource = table.DefaultView;
            window.Title = name + " result";
            window.Show();
        }
    }
}
