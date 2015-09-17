﻿using Fiddler;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure.Business;
using UltimateServiceMocker.Infrastructure.Business.HttpCaptureEvents;
using UltimateServiceMocker.Infrastructure.Domain;

namespace FiddlerCoreModule
{
    public class HttpCallsProvider:IHttpCallsProvider
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
        IEventAggregator _eventAggregator;
        public HttpCallsProvider(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

        }
        public void StartCapture()
        {
            //FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            //FiddlerApplication.Startup(0, Fiddler.FiddlerCoreStartupFlags.Default);
        }
        public void StopCapture()
        {
            //FiddlerApplication.Shutdown();
        }

        private void FiddlerApplication_AfterSessionComplete(Session oSession)
        {
            
            IHttpCall call = new HttpCall
            {
                FullUrl = oSession.fullUrl
            };

            _eventAggregator.GetEvent<AfterSessionCompleteEvent>().Publish(call);
        }
        public IEnumerable<IHttpCall> getHttpCalls()
        {


            return HttpCalls;
        }
    }
}