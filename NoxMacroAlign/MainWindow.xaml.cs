using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WPF.JoshSmith.ServiceProviders.UI;

namespace NoxMacroAlign
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
		ListViewDragDropManager<Macro> dragMgr;
		ObservableCollection<Macro> macroList;

		public MainWindow()
        {
            InitializeComponent();
        }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			macroList = new ObservableCollection<Macro>();
			this.listView.ItemsSource = macroList;

			this.dragMgr = new ListViewDragDropManager<Macro>(this.listView);
			this.dragMgr.ShowDragAdorner = true;
			this.dragMgr.DragAdornerOpacity = 0.7;

			macroList.Add(new Macro("Test1"));
			macroList.Add(new Macro("Test2"));
			macroList.Add(new Macro("Test3"));
		}

	}
}
