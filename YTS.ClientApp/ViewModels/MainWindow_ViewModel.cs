using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Windows.Input;

namespace YTS.ClientApp.ViewModels
{
    using Base;
    using Contracts;

    using Models;
    using Requests;

    public class MainWindow_ViewModel : IViewModel
    {
        private const string requestUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36";
        private const string requestContentType = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
        private const string baseUrl = "https://yts.am/api/v2/list_movies.json?sort=date_added&limit=50&page=1";

        private readonly Command testCommand;
        private ObservableCollection<Movie_Model> movieCollection;

        private CancellationTokenSource cancelTokenSource;

        public ICommand TestCommand => testCommand;

        public MainWindow_ViewModel()
        {
            cancelTokenSource = new CancellationTokenSource();
            movieCollection = new ObservableCollection<Movie_Model>();

            testCommand = new Command(async () =>
            {
                var response = await GetResponseAsync(new ListRequest());
                response.Data.Movies.ToArray();
            });
        }

        private async Task<RootInfo> GetResponseAsync(IRequest request)
        {
            HttpWebRequest httpRequest = null;
            WebResponse webResponse = null;
            Stream responseStream = null;

            var serializer = new DataContractJsonSerializer(typeof(RootInfo));
            var result = default(RootInfo);

            try
            {
                httpRequest = WebRequest.CreateHttp(request.BuildRequestUri());
                webResponse = await httpRequest.GetResponseAsync();
                responseStream = webResponse.GetResponseStream();

                result = serializer.ReadObject(responseStream) as RootInfo;
            }
            finally
            {
                responseStream.Dispose();
                responseStream = null;

                webResponse.Dispose();
                webResponse = null;

                serializer = null;
                httpRequest = null;
            }

            return result ?? new RootInfo();
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
