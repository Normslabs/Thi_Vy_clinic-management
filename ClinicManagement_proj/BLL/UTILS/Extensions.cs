using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement_proj.BLL.Utils {
    internal static class Extensions {

        public static ICollection<OutputType> Map<InputType, OutputType>(this ICollection<InputType> input, Func<InputType, OutputType> mappingFunction) {
            ICollection<OutputType> list = new List<OutputType>();
            foreach (InputType item in input) {
                list.Add(mappingFunction(item));
            }
            return list;
        }

    }
}
