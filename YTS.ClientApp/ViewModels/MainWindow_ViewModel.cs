using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;

namespace YTS.ClientApp.ViewModels
{
    using Base;
    using Contracts;

    public class MainWindow_ViewModel : IViewModel
    {
        private const string requestUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36";
        private const string requestContentType = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
        private const string baseUrl = "https://yts.am/api/v2/list_movies.json";

        private CancellationTokenSource cancelTokenSource;

        public MainWindow_ViewModel()
        {
            cancelTokenSource = new CancellationTokenSource();
        }

        private async Task<RootInfo> ResponceAsync(IRequest request)
        {
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;
            Stream httpResponseStream = null;
            RootInfo rootInfo = null;

            var jsonSerializer = new DataContractJsonSerializer(typeof(RootInfo));

            try
            {
                httpRequest = WebRequest.CreateHttp(request.BuildRequestUri());
                httpRequest.Credentials = CredentialCache.DefaultCredentials;
                httpRequest.ContentType = requestContentType;
                httpRequest.UserAgent = requestUserAgent;

                httpResponse = await httpRequest.GetResponseAsync() as HttpWebResponse;
                httpResponseStream = httpResponse.GetResponseStream();

                rootInfo = jsonSerializer.ReadObject(httpResponseStream) as RootInfo;
            }
            finally
            {
                jsonSerializer = null;

                httpResponseStream.Dispose();
                httpResponseStream = null;

                httpResponse.Dispose();
                httpResponse = null;

                request = null;
            }

            return rootInfo;
        }

        #region INotifyPropertyChanged Support

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (cancelTokenSource != null)
                    {
                        cancelTokenSource.Dispose();
                        cancelTokenSource = null;
                    }
                }

                disposedValue = true;
            }
        }

        public void Dispose() => Dispose(true);
        #endregion
    }
}
