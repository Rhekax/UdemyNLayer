using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UdemyNLayer.Core.Entitiy_Model_;

namespace UdemyNLayer.Core.Entitiy_Model_
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Products>();
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
