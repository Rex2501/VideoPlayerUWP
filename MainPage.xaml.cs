using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VideoPlayer {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {

        public MainPage() {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            base.OnNavigatedTo(e);

            mySwapChainPanel.StartRenderLoop();

            Debug.WriteLine("SwapChainPanel RenderLoop started");

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e) {
            mySwapChainPanel.StopRenderLoop();
        }

    }

}
