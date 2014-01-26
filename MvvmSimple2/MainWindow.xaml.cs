using System.Windows;

namespace MvvmSimple2
{
    public partial class MainWindow : Window
    {
        private EditView _editView;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            this._editView = new EditView();
        }

        public EditView EditView { get { return this._editView; } }
    }
}
