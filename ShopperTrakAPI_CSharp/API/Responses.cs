using System.Xml.Serialization;
using System.Collections.Generic;

namespace ShopperTrakAPI_CSharp
{
    [XmlRoot(ElementName = "kpis")]
    public class BasicKPIsResponse
    {
        [XmlElement(ElementName = "period")]
        public Period Period { get; set; }
        [XmlElement(ElementName = "hierarchyNode")]
        public HierarchyNode HierarchyNode { get; set; }
    }

    [XmlRoot(ElementName = "kpis")]
    public class HourlyPerformanceResponse
    {
        [XmlElement(ElementName = "hierarchyNode")]
        public HierarchyNode HierarchyNode { get; set; }
    }

    [XmlRoot(ElementName = "hierarchies")]
    public class HierarchyResponse
    {
        [XmlElement(ElementName = "hierarchy")]
        public Hierarchy Hierarchy { get; set; }
    }

    [XmlRoot(ElementName = "kpis")]
    public class PowerHoursResponse
    {
        [XmlElement(ElementName = "period")]
        public Period Period { get; set; }
        [XmlElement(ElementName = "hierarchyNode")]
        public HierarchyNode HierarchyNode { get; set; }
    }
}
