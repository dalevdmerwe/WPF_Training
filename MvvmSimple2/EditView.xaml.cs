using System.Windows.Controls;

namespace MvvmSimple2
{
    public partial class EditView : UserControl
    {
        public EditView()
        {
            InitializeComponent();
            DataContext = new EditViewModel();
        }
    }
}
