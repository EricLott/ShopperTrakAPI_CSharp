using RestSharp;
using ShopperTrakAPI_CSharp.KPI;
using System;

namespace ShopperTrakAPI_CSharp
{
    public class HourlyPerformanceCall
    {
        public DateTime PerformanceDate { get; set; }
        public string HierarchyID { get; set; }

        public HourlyPerformanceCall(DateTime performanceDate, string hierarchyID)
        {
            this.PerformanceDate = performanceDate;
            this.HierarchyID = hierarchyID;
        }

        public HourlyPerformanceResponse Execute(Credentials ShopperTrackCredentials)
        {
            try
            {
                var client = new RestClient("https://stws.shoppertrak.com/KeyPerformanceIndicators/v1.0/service/hourlyPerformance/" + HierarchyID + "?date=" + PerformanceDate.ToString("yyyyMMdd"));
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "Basic " + ShopperTrackCredentials.authString);

                IRestResponse response = client.Execute(request);

                return response.Content.FromXML<HourlyPerformanceResponse>();
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }
}
