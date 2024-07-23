namespace CollectionViewPerformanceMaui
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new AppShell();


            //to find resources for test photos
            foreach (string currentResource in System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames()) {
                System.Diagnostics.Debug.WriteLine(currentResource);
            }

        }
    }
}
