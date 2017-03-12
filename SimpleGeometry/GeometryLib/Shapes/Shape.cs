using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Абстрактный класс формы
    /// </summary>
    
    public interface IPrintable
    {
        string Print();
    }

    public abstract class Shape: IPrintable
    {
        public abstract double area();

        public abstract string Print();
    }
}
