using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUIXamarin.Core.IServices.Contacts;
using ReactiveUIXamarin.Infrastructure.Entities.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace ReactiveUIXamarin.ViewModels
{
    public class MainPageViewModel : ReactiveObject
    {
        [Reactive] public string UserName { get; set; }
        [Reactive] public string SearchQuery { get; set; }
      
        [Reactive] public ObservableCollection<ContactDTO> Contacts { get; set; }
        public ObservableAsPropertyHelper<string> _stringResult;

        public string SearchQueryResult => _stringResult.Value;
        public MainPageViewModel(IContactService contactService)
        {
            UserName = "Vishal Makwan";
            SearchQuery = "";
            Contacts = new ObservableCollection<ContactDTO>(contactService.GetContacts());
            this.WhenAnyValue(vm => vm.SearchQuery)
                .Throttle(TimeSpan.FromSeconds(2))
                .Subscribe(query =>
                {
                    var filtercontacts = contactService.GetContacts().Where(c => c.FullName.ToLower().Contains(query)).ToList() ?? new List<ContactDTO>();

                    Contacts = new ObservableCollection<ContactDTO>(filtercontacts);
                });
            this.WhenAnyValue(vm => vm.Contacts)
                .Select(contacts =>
                {
                    if (Contacts.Count == contactService.GetContacts().ToList().Count)
                        return "No Filter Applied";
                    else
                        return $"{Contacts.Count} have been found in result '{SearchQuery}'";
                }).ToProperty(this, vm => vm.SearchQueryResult, out _stringResult);
        }
    }
}
