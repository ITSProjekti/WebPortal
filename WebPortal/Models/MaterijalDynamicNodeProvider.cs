using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider;

namespace WebPortal.Models
{
    public class MaterijalDynamicNodeProvider : DynamicNodeProviderBase
    {
        MaterijalContext context = new MaterijalContext();
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            List<DynamicNode> returnList = new List<DynamicNode>();

            foreach (MaterijalModel materijal in context.materijali)
            {
                DynamicNode newNode = new DynamicNode();
                newNode.Title = materijal.materijalNaziv;
                newNode.ParentKey = "SviMaterijali";
                newNode.RouteValues.Add("id", materijal.materijalId);
                returnList.Add(newNode);
            }

            return returnList;
        }
    }
}