using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Example_Three
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly string _color;
        public ColorSpecification(string color)
        {
            _color = color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == _color;
        }
    }
}
