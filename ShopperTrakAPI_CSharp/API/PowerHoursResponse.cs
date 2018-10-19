using System.Collections.Generic;
using System.Xml.Serialization;

namespace ShopperTrakAPI_CSharp.PowerHours
{
    [XmlRoot(ElementName = "period")]
    public class Period
    {
        [XmlAttribute(AttributeName = "startDate")]
        public string StartDate { get; set; }
        [XmlAttribute(AttributeName = "endDate")]
        public string EndDate { get; set; }
    }

    [XmlRoot(ElementName = "hour")]
    public class Hour
    {
        [XmlElement(ElementName = "sunday")]
        public string Sunday { get; set; }
        [XmlElement(ElementName = "monday")]
        public string Monday { get; set; }
        [XmlElement(ElementName = "tuesday")]
        public string Tuesday { get; set; }
        [XmlElement(ElementName = "wednesday")]
        public string Wednesday { get; set; }
        [XmlElement(ElementName = "thursday")]
        public string Thursday { get; set; }
        [XmlElement(ElementName = "friday")]
        public string Friday { get; set; }
        [XmlElement(ElementName = "saturday")]
        public string Saturday { get; set; }
        [XmlElement(ElementName = "total")]
        public string Total { get; set; }
        [XmlAttribute(AttributeName = "startTime")]
        public string StartTime { get; set; }
    }

    [XmlRoot(ElementName = "total")]
    public class Total
    {
        [XmlElement(ElementName = "sunday")]
        public string Sunday { get; set; }
        [XmlElement(ElementName = "monday")]
        public string Monday { get; set; }
        [XmlElement(ElementName = "tuesday")]
        public string Tuesday { get; set; }
        [XmlElement(ElementName = "wednesday")]
        public string Wednesday { get; set; }
        [XmlElement(ElementName = "thursday")]
        public string Thursday { get; set; }
        [XmlElement(ElementName = "friday")]
        public string Friday { get; set; }
        [XmlElement(ElementName = "saturday")]
        public string Saturday { get; set; }
        [XmlElement(ElementName = "all")]
        public string All { get; set; }
    }

    [XmlRoot(ElementName = "hierarchyNode")]
    public class HierarchyNode
    {
        [XmlElement(ElementName = "customerID")]
        public string CustomerID { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hour")]
        public List<Hour> Hour { get; set; }
        [XmlElement(ElementName = "total")]
        public Total Total { get; set; }
        [XmlAttribute(AttributeName = "shopperTrakID")]
        public string ShopperTrakID { get; set; }
    }
}
