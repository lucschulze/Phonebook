using Phone_book.Views;
using Prism.Mvvm;
using Prism.Regions;
using Unity;

namespace Phone_book.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private IUnityContainer _container { get; set; }
        private IRegionManager _regionManager { get; set; }

    public MainWindowViewModel(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Home));


        }
    }
}
