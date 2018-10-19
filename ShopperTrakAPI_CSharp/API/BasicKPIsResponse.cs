using System.Collections.Generic;
using System.Xml.Serialization;

namespace ShopperTrakAPI_CSharp.BasicKPIs
{
    [XmlRoot(ElementName = "period")]
    public class Period
    {
        [XmlAttribute(AttributeName = "startDate")]
        public string StartDate { get; set; }
        [XmlAttribute(AttributeName = "endDate")]
        public string EndDate { get; set; }
    }

    [XmlRoot(ElementName = "traffic")]
    public class Traffic
    {
        [XmlAttribute(AttributeName = "exits")]
        public string Exits { get; set; }
        [XmlAttribute(AttributeName = "enters")]
        public string Enters { get; set; }
    }

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

    [XmlRoot(ElementName = "hierarchyNode")]
    public class HierarchyNode
    {
        [XmlElement(ElementName = "customerID")]
        public string CustomerID { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "date")]
        public List<Date> Date { get; set; }
        [XmlElement(ElementName = "total")]
        public Total Total { get; set; }
        [XmlAttribute(AttributeName = "shopperTrakID")]
        public string ShopperTrakID { get; set; }
    }
}
