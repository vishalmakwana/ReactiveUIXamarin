using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIXamarin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        [Reactive] public string UserName { get; set; } 
        public MainPageViewModel()
        {
            UserName = "Vishal Makwan";
        }
    }
}
