using Prism.Ioc;
using ReactiveUIXamarin.Core.IServices.Contacts;
using ReactiveUIXamarin.Core.Services.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIXamarin.Infrastructure.DI
{
    public class ServiceDIBindings
    {
        public void Configure(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IContactService, ContactService>();
            //containerRegistry.RegisterSingleton<IPatientService, PatientService>();
            //containerRegistry.RegisterSingleton<ICaireServices, CaireServices>();
        }
    }
}
