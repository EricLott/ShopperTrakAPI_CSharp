﻿using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace ShopperTrakAPI_CSharp.KPI
{
    [XmlRoot(ElementName = "traffic")]
    public class Traffic
    {
        [XmlAttribute(AttributeName = "enters")]
        public string Enters { get; set; }
        [XmlAttribute(AttributeName = "exits")]
        public string Exits { get; set; }
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
        public string StartDateTimeRaw { get; set; }
        [XmlIgnore]
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
        [XmlElement(ElementName = "hour")]
        public List<Hour> Hour { get; set; }
        [XmlElement(ElementName = "total")]
        public Total Total { get; set; }
        [XmlAttribute(AttributeName = "shopperTrakID")]
        public string ShopperTrakID { get; set; }
    }

    [XmlRoot(ElementName = "kpis")]
    public class HourlyPerformanceResponse
    {
        [XmlElement(ElementName = "hierarchyNode")]
        public HierarchyNode HierarchyNode { get; set; }
    }

}
