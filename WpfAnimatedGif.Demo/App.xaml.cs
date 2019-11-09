using System.Windows;

namespace WpfAnimatedGif.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            TP = new TP();
            TP.Show();
        }

        public TP TP { get; set; }
    }
}
