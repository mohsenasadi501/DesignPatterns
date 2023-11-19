using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    internal interface IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> parameters);
    }
}
