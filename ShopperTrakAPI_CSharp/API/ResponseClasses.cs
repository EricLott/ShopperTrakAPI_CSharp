using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ShopperTrakAPI_CSharp
{
    [XmlRoot(ElementName = "date")]
    public class Date
    {
        [XmlElement(ElementName = "traffic")]
        public Traffic Traffic { get; set; }
        [XmlElement(ElementName = "conversion")]
        public decimal Conversion { get; set; }
        [XmlElement(ElementName = "star")]
        public string Star { get; set; }
        [XmlElement(ElementName = "sales")]
        public decimal Sales { get; set; }
        [XmlElement(ElementName = "salesPerShopper")]
        public decimal SalesPerShopper { get; set; }
        [XmlElement(ElementName = "avgTransactionSize")]
        public decimal AvgTransactionSize { get; set; }
        [XmlAttribute(AttributeName = "endDate")]
        public string EndDateRaw { get; set; }
        [XmlAttribute(AttributeName = "startDate")]
        public string StartDateRaw { get; set; }
        public DateTime StartDate
        {
            get
            {
                if (StartDateRaw != null)
                {
                    return DateTime.ParseExact(StartDateRaw, "yyyyMMdd", null);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                StartDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                if (EndDateRaw != null)
                {
                    return DateTime.ParseExact(EndDateRaw, "yyyyMMdd", null);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                EndDate = value;
            }
        }
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
        public decimal Total { get; set; }
        [XmlAttribute(AttributeName = "startTime")]
        public string StartTimeRaw { get; set; }
        public DateTime StartTime
        {
            get
            {
                if (StartTimeRaw != null)
                {
                    return DateTime.ParseExact(StartTimeRaw, "HHmmss", null);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                StartTime = value;
            }
        }
    }

    [XmlRoot(ElementName = "hierarchy")]
    public class Hierarchy
    {
        [XmlElement(ElementName = "hierarchyName")]
        public string HierarchyName { get; set; }
        [XmlElement(ElementName = "hierarchyNode")]
        public List<HierarchyNode> HierarchyNode { get; set; }
        [XmlAttribute(AttributeName = "shopperTrakID")]
        public long ShopperTrakID { get; set; }
    }

    [XmlRoot(ElementName = "hierarchyNode")]
    public class HierarchyNode
    {
        [XmlElement(ElementName = "customerID")]
        public long CustomerID { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "parentID")]
        public long ParentID { get; set; }
        [XmlAttribute(AttributeName = "shopperTrakID")]
        public long ShopperTrakID { get; set; }
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
        public decimal Conversion { get; set; }
        [XmlElement(ElementName = "star")]
        public string Star { get; set; }
        [XmlElement(ElementName = "sales")]
        public decimal Sales { get; set; }
        [XmlElement(ElementName = "salesPerShopper")]
        public decimal SalesPerShopper { get; set; }
        [XmlElement(ElementName = "avgTransactionSize")]
        public decimal AvgTransactionSize { get; set; }
        [XmlAttribute(AttributeName = "startDateTime")]
        public string StartDateTimeRaw
        { get; set; }
        public DateTime StartDateTime
        {
            get
            {
                if (StartDateTimeRaw != null)
                {
                    return DateTime.ParseExact(StartDateTimeRaw, "yyyyMMddHHmmss", null);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                StartDateTime = value;
            }
        }
    }

    [XmlRoot(ElementName = "period")]
    public class Period
    {
        [XmlAttribute(AttributeName = "startDate")]
        public string StartDateRaw { get; set; }
        [XmlAttribute(AttributeName = "endDate")]
        public string EndDateRaw { get; set; }
        public DateTime StartDate
        {
            get
            {
                if (StartDateRaw != null)
                {
                    return DateTime.ParseExact(StartDateRaw, "yyyyMMdd", null);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                StartDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                if (EndDateRaw != null)
                {
                    return DateTime.ParseExact(EndDateRaw, "yyyyMMdd", null);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                EndDate = value;
            }
        }
    }

    [XmlRoot(ElementName = "total")]
    public class Total
    {
        [XmlElement(ElementName = "traffic")]
        public Traffic Traffic { get; set; }
        [XmlElement(ElementName = "conversion")]
        public decimal Conversion { get; set; }
        [XmlElement(ElementName = "star")]
        public string Star { get; set; }
        [XmlElement(ElementName = "sales")]
        public decimal Sales { get; set; }
        [XmlElement(ElementName = "salesPerShopper")]
        public decimal SalesPerShopper { get; set; }
        [XmlElement(ElementName = "avgTransactionSize")]
        public decimal AvgTransactionSize { get; set; }
    }

    [XmlRoot(ElementName = "traffic")]
    public class Traffic
    {
        [XmlAttribute(AttributeName = "exits")]
        public long Exits { get; set; }
        [XmlAttribute(AttributeName = "enters")]
        public long Enters { get; set; }
    }
}
