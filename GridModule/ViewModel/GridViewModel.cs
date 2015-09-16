using GridModule.View;
using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.Infrastructure.Business;
using UltimateServiceMocker.Infrastructure.Business.HttpCaptureEvents;
using UltimateServiceMocker.Infrastructure.Domain;

namespace GridModule.ViewModel
{
     
   public class GridViewModel:   IGridViewModel
    {
       IHttpCallsProvider _provider;
       public int countu { get; set; }
       IEventAggregator _eventAggregator;
        public GridViewModel(IGridUC view , IEventAggregator eventAggregator)
        {
            this.View = view;
            View.ViewModel = this;
            _eventAggregator = eventAggregator;
            countu = 10;
            this.HttpCalls = new ObservableCollection<IHttpCall>();

            _eventAggregator.GetEvent<AfterSessionCompleteEvent>().Subscribe(AfterSessionComplete, ThreadOption.UIThread);
        }

        private void AfterSessionComplete(IHttpCall call)
        {
            httpCalls.Add(new HttpCall()
            {
                FullUrl = call.FullUrl
            });
        }
          ObservableCollection<IHttpCall> httpCalls;
        public ObservableCollection<IHttpCall> HttpCalls
        {
            get
            {
                return httpCalls;
            }
            set
            {
                httpCalls = value;
            }
          

        }

       // public IEnumerable<IHttpCall> getHttpCalls()
       // {
            
       //    return _provider.getHttpCalls();
       //}
       // public void populateHttpCalls()
       // {
       //     HttpCalls = getHttpCalls();
       // }
        public IView  View
        {
            get;
            set;
        }
    }
}
