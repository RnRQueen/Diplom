using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Core
{
    public abstract class SiteDataProviderBase
    {
        protected abstract string ConnectionString { get; }
        private HtmlDocument document;
        public void GetData(SearchFilter filter)
        {
            document = GetDataCore(ConnectionString, filter);
            var str = GetAdvertising(document);
        }

        protected abstract HtmlDocument GetDataCore(string connectionString, SearchFilter filter);

        protected abstract string[] GetAdvertising(HtmlDocument doc);
    }
}
