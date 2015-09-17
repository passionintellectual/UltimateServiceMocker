using GridModule.View;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;
using System.Collections.ObjectModel;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.Infrastructure.Business;
using UltimateServiceMocker.Infrastructure.Business.HttpCaptureEvents;
using UltimateServiceMocker.Infrastructure.Domain;

namespace GridModule.ViewModel
{
     
   public class GridViewModel: ViewModelBase,  IGridViewModel
    {
       public int countu { get; set; }
       IEventAggregator _eventAggregator;
       public DelegateCommand cmd { get; set; }
        public GridViewModel(IGridUC view , IEventAggregator eventAggregator) : base(view)
        {

            _eventAggregator = eventAggregator;
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

        
    }
}
