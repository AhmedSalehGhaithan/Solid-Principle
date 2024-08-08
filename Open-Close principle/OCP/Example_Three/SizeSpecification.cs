using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Example_Three
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly double _size;
        public SizeSpecification(double size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Size == _size;
        }
    }
}
