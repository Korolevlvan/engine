using engine;

namespace engine.MAUI
{
    public partial class MainPage : ContentPage
    {
        private readonly MyApplication evergineApplication;

        public MainPage()
        {
            InitializeComponent();
            this.evergineApplication = new MyApplication();
            this.evergineView.Application = this.evergineApplication;
        }
    }
}