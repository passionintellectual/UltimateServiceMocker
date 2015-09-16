using System.Collections.Generic;
using UltimateServiceMocker.Infrastructure.Business;
using UltimateServiceMocker.Infrastructure.Domain;
using Fiddler;
namespace UltimateServiceMocker.Business
{
    public class HttpCallsProvider :IDataProvider, IHttpCallsProvider
    {
        IEnumerable<IHttpCall> httpCalls;
        public IEnumerable<IHttpCall> HttpCalls
        {
            get
            {
                if (httpCalls == null)
                {
                    httpCalls = new List<IHttpCall>();
                }
                return httpCalls;
            }
            set
            {
                httpCalls = value;
            }
        }
        public HttpCallsProvider ()
	    {
            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Startup(8080, true, true, true);

	    }
        
        private void FiddlerApplication_AfterSessionComplete(Session oSession)
        {
            if (HttpCalls == null)
            {
                HttpCalls = new List<IHttpCall>();
            }
            IHttpCall call = new HttpCall
            {
                FullUrl = oSession.fullUrl
            };
            ((List<IHttpCall>)HttpCalls).Add(call);
        }
        public IEnumerable<IHttpCall> getHttpCalls()
        {
            

             return HttpCalls;
        }
    }   
}
