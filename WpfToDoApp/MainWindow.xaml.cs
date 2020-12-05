using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfToDoApp.Models;

namespace WpfToDoApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<ToDoModel> _toDoDataList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _toDoDataList = new BindingList<ToDoModel>()
            {
                new ToDoModel() { Text = "test" },
                new ToDoModel() { Text = "some string" },
                new ToDoModel() { Text = "task 3", IsDone = true }
            };

            ToDoList.ItemsSource = _toDoDataList;

            _toDoDataList.ListChanged += _toDoDataList_ListChanged;
        }

        private void _toDoDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || 
                e.ListChangedType == ListChangedType.ItemDeleted ||
                e.ListChangedType == ListChangedType.ItemChanged)
            {

            }

            //switch (e.ListChangedType)
            //{
            //    case ListChangedType.Reset:
            //        break;
            //    case ListChangedType.ItemAdded:
            //        break;
            //    case ListChangedType.ItemDeleted:
            //        break;
            //    case ListChangedType.ItemMoved:
            //        break;
            //    case ListChangedType.ItemChanged:
            //        break;
            //    case ListChangedType.PropertyDescriptorAdded:
            //        break;
            //    case ListChangedType.PropertyDescriptorDeleted:
            //        break;
            //    case ListChangedType.PropertyDescriptorChanged:
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
