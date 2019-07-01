using Phone_book.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace Phone_book.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        private IUnityContainer _container { get; set; }
        private IRegionManager _regionManager { get; set; }
        public HomeViewModel(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("BaseNavbar", typeof(BaseNavbar));
            _regionManager.RegisterViewWithRegion("BaseSidebar", typeof(BaseSidebar));
            _regionManager.RegisterViewWithRegion("ListUsers", typeof(ListUsers));
        }

    }
}
