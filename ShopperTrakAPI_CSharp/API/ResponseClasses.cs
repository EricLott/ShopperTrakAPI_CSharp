using System.Xml.Serialization;
using System.Collections.Generic;

namespace ShopperTrakAPI_CSharp
{
    [XmlRoot(ElementName = "date")]
    public class Date
    {
        [XmlElement(ElementName = "traffic")]
        public Traffic Traffic { get; set; }
        [XmlElement(ElementName = "conversion")]
        public string Conversion { get; set; }
        [XmlElement(ElementName = "star")]
        public string Star { get; set; }
        [XmlElement(ElementName = "sales")]
        public string Sales { get; set; }
        [XmlElement(ElementName = "salesPerShopper")]
        public string SalesPerShopper { get; set; }
        [XmlElement(ElementName = "avgTransactionSize")]
        public string AvgTransactionSize { get; set; }
        [XmlAttribute(AttributeName = "endDate")]
        public string EndDate { get; set; }
        [XmlAttribute(AttributeName = "startDate")]
        public string StartDate { get; set; }
    }

    [XmlRoot(ElementName = "hour")]
    public class Day
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

    [XmlRoot(ElementName = "hierarchy")]
    public class Hierarchy
    {
        [XmlElement(ElementName = "hierarchyName")]
        public string HierarchyName { get; set; }
        [XmlElement(ElementName = "hierarchyNode")]
        public List<HierarchyNode> HierarchyNode { get; set; }
        [XmlAttribute(AttributeName = "shopperTrakID")]
        public string ShopperTrakID { get; set; }
    }

    [XmlRoot(ElementName = "hierarchyNode")]
    public class HierarchyNode
    {
        [XmlElement(ElementName = "customerID")]
        public string CustomerID { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "parentID")]
        public string ParentID { get; set; }
        [XmlAttribute(AttributeName = "shopperTrakID")]
        public string ShopperTrakID { get; set; }
        [XmlElement(ElementName = "hour")]
        public List<Hour> Hour { get; set; }
        [XmlElement(ElementName = "total")]
        public Total Total { get; set; }
    }

    [XmlRoot(ElementName = "hour")]
    public class Hour
    {
        [XmlElement(ElementName = "traffic")]
        public Traffic Traffic { get; set; }
        [XmlElement(ElementName = "conversion")]
        public string Conversion { get; set; }
        [XmlElement(ElementName = "star")]
        public string Star { get; set; }
        [XmlElement(ElementName = "sales")]
        public string Sales { get; set; }
        [XmlElement(ElementName = "salesPerShopper")]
        public string SalesPerShopper { get; set; }
        [XmlElement(ElementName = "avgTransactionSize")]
        public string AvgTransactionSize { get; set; }
        [XmlAttribute(AttributeName = "startDateTime")]
        public string StartDateTime { get; set; }
    }

    [XmlRoot(ElementName = "period")]
    public class Period
    {
        [XmlAttribute(AttributeName = "startDate")]
        public string StartDate { get; set; }
        [XmlAttribute(AttributeName = "endDate")]
        public string EndDate { get; set; }
    }

    [XmlRoot(ElementName = "total")]
    public class Total
    {
        [XmlElement(ElementName = "traffic")]
        public Traffic Traffic { get; set; }
        [XmlElement(ElementName = "conversion")]
        public string Conversion { get; set; }
        [XmlElement(ElementName = "star")]
        public string Star { get; set; }
        [XmlElement(ElementName = "sales")]
        public string Sales { get; set; }
        [XmlElement(ElementName = "salesPerShopper")]
        public string SalesPerShopper { get; set; }
        [XmlElement(ElementName = "avgTransactionSize")]
        public string AvgTransactionSize { get; set; }
    }

    [XmlRoot(ElementName = "traffic")]
    public class Traffic
    {
        [XmlAttribute(AttributeName = "exits")]
        public string Exits { get; set; }
        [XmlAttribute(AttributeName = "enters")]
        public string Enters { get; set; }
    }
}
