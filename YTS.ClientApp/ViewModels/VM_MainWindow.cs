using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace YTS.ClientApp.ViewModels
{
    using YTS.ClientApp.Base;

    public class VM_MainWindow : ViewModel, IDisposable
    {
        private const string requestUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36";
        private const string requestContentType = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
        private const string baseUrl = "https://yts.am/api/v2/list_movies.json";

        private CancellationTokenSource cancelTokenSource;

        public VM_MainWindow()
        {
            cancelTokenSource = new CancellationTokenSource();
        }

        private async Task<string> ResponceAsync()
        {
            Uri requestUri = null;
            WebRequest request = null;
            WebResponse response = null;
            Stream responseStream = null;
            StreamReader responseReader = null;

            string responseString = string.Empty;

            try
            {
                requestUri = new Uri(baseUrl);
                request = WebRequest.CreateDefault(requestUri);

                request.Credentials = CredentialCache.DefaultCredentials;
                request.ContentType = requestContentType;
                ((HttpWebRequest)request).UserAgent = requestUserAgent;

                response = await request.GetResponseAsync();
                responseStream = response.GetResponseStream();
                responseReader = new StreamReader(responseStream);
                responseString = await responseReader.ReadToEndAsync();
            }
            catch
            {

            }
            finally
            {
                if (responseReader != null)
                {
                    responseReader.Dispose();
                    responseReader = null;
                }

                if (responseStream != null)
                {
                    responseStream.Dispose();
                    responseStream = null;
                }

                if (response != null)
                {
                    response.Dispose();
                    response = null;
                }

                if (request != null)
                {
                    request = null;
                }
            }

            return responseString;
        }
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
