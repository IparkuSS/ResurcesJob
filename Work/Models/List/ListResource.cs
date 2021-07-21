using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Models.List
{
    public class ListResource
    {
        private List<Resource> ResourcesList = new List<Resource>();

        public void ListAddItem(Resource resource)
        {
            if (ResourcesList.Count > 0)
            {

                if (ResourcesList[ResourcesList.Count - 1].ResourceName == ResourcesList.Count)
                {
                    resource.ResourceName = ResourcesList.Count;
                    resource.ResourceName++;
                }
                else resource.ResourceName = ResourcesList.Count;
            }
            else resource.ResourceName = ResourcesList.Count;

            ResourcesList.Add(resource);
        }
        public List<Resource> ListGetItem()
        {
            return ResourcesList.ToList();
        }
        public void ListEditItem(Resource resource, int Index)
        {
            resource.ResourceName = ResourcesList.Count;
            ResourcesList[Index] = resource;
        }
        public Resource ListFaindItem(int Index)
        {
            return ResourcesList[Index];
        }
        public void ListRemoveItem(int Index)
        {
            ResourcesList.RemoveAt(Index);
        }

    }
}
