using System.Xml.Serialization;
using System.Collections.Generic;
using ShopperTrakAPI_CSharp.BasicKPIs;
using ShopperTrakAPI_CSharp.HourlyPerformance;
using ShopperTrakAPI_CSharp.Hierarchy;
using ShopperTrakAPI_CSharp.PowerHours;

namespace ShopperTrakAPI_CSharp
{
    [XmlRoot(ElementName = "kpis")]
    public class BasicKPIsResponse
    {
        [XmlElement(ElementName = "period")]
        public BasicKPIs.Period Period { get; set; }
        [XmlElement(ElementName = "hierarchyNode")]
        public BasicKPIs.HierarchyNode HierarchyNode { get; set; }
    }

    [XmlRoot(ElementName = "kpis")]
    public class HourlyPerformanceResponse
    {
        [XmlElement(ElementName = "hierarchyNode")]
        public HourlyPerformance.HierarchyNode HierarchyNode { get; set; }
    }

    [XmlRoot(ElementName = "hierarchies")]
    public class HierarchyResponse
    {
        [XmlElement(ElementName = "hierarchy")]
        public Hierarchy.Hierarchy Hierarchy { get; set; }
    }

    [XmlRoot(ElementName = "kpis")]
    public class PowerHoursResponse
    {
        [XmlElement(ElementName = "period")]
        public PowerHours.Period Period { get; set; }
        [XmlElement(ElementName = "hierarchyNode")]
        public PowerHours.HierarchyNode HierarchyNode { get; set; }
    }
}
