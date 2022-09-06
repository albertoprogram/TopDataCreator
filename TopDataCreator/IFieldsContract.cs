using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDataCreator
{
    public interface IFieldsContract
    {
        void FieldSetings(Tuple<int, string, string> fieldSetting);
    }
}
