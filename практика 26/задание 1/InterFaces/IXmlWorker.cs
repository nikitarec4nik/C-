using задание_1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1.InterFaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Market parking);
        void Delete(string mark);
        Market FindBy(string mark);
        List<Market> GetAll();
    }
}
