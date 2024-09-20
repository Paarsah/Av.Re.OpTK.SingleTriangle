using Avalonia.Controls;
using Avalonia.Threading;
using System.Threading.Tasks;

namespace Mag3DView.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StartOpenGlWindow();
        }

        private void StartOpenGlWindow()
        {
            // Use Avalonia's Dispatcher to ensure the OpenTK window runs on the main thread
            Dispatcher.UIThread.InvokeAsync(() =>
            {
                var glWindow = new OpenGlWindow();
                glWindow.Run();
            });
        }
    }
}
