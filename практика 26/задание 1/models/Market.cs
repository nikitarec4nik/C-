using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1.models
{
    public class Market
    {
        public string NameT { get; set; }
        public string ExDate { get; set; }
        public int Cost { get; set; }
        public override string ToString()
        {
            return new StringBuilder().AppendLine($"Название товара: {NameT}")
                .AppendLine($"\tСрок годности до: {ExDate}")
                .AppendLine($"Цена: {Cost}").ToString();
        }
    }
}
