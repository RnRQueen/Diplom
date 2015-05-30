using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using HtmlAgilityPack;

namespace CianLib
{
    public class CianDataProvider : SiteDataProviderBase
    {
        protected override string ConnectionString
        {
            get { return @"http://www.cian.ru/cat.php?deal_type=1&obl_id=1&city[0]=1"; }
        }

        private string filtredString;
        private HtmlWeb web = new HtmlWeb();
        protected override HtmlDocument GetDataCore(string connectionString, SearchFilter filter)
        {
            filter = new SearchFilter();
            filter.RoomType |= RoomType.Bed;
            var filterstring = new StringBuilder();
            filterstring.Append(connectionString);
            
            if (filter.CheckRoomType(RoomType.Bed))
            {
                filterstring.Append("&room10=1");
            }
            if (filter.CheckRoomType(RoomType.Room))
            {
                filterstring.Append("&room0=1");
            }
            if (filter.CheckRoomType(RoomType.Studio))
            {
                filterstring.Append("&room9=1");
            }
            if (filter.IsNumberedRooms && filter.NumberOfRooms.Any(x=>x > 0))
            {
                foreach (var numberOfRoom in filter.NumberOfRooms)
                {
                    if (numberOfRoom < 6 && numberOfRoom > 0)
                    {
                        filterstring.Append(string.Format("&room{0}=1",numberOfRoom));
                    }
                }
            }
            filtredString = filterstring.ToString();
            HtmlDocument doc = web.Load(filtredString);
            return doc;
        }

        protected override string[] GetAdvertising(HtmlDocument doc)
        {
            List<string> metro = new List<string>();
            var numberOfItems = int.Parse(doc.DocumentNode.SelectSingleNode("//span[@class='objects_list_title_site_selected']").InnerText);
            var pages = (int)Math.Ceiling(((double)numberOfItems) / 50);
            for (int i = 1; i <= pages; i++ )
            {
                var newQuery = string.Format("{0}&p={1}", filtredString, i);
                doc = web.Load(newQuery);
                var itemrows = doc.DocumentNode.SelectNodes("//tr[@class='offer_container objects_item cleared ']");
                foreach (var row in itemrows)
                {
                    var m =
                        row.SelectSingleNode(".//div[@class='objects_item_metro']")
                            .ChildNodes.FirstOrDefault(x => x.Name == "a");
                    if (m != null)
                    {
                        metro.Add(m.InnerText);
                    }
                }
            }
            return metro.ToArray();
        }
    }
}
