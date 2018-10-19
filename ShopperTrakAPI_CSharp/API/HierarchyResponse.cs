using System.Xml.Serialization;
using System.Collections.Generic;

namespace ShopperTrakAPI_CSharp.Hierarchy
{
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
}