using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_F2016_Assign3_MovieBonanza
{
    public enum Genre
    {
        Unclassified,

        Action,
        Comedy,
        Horror,
        Romantic
    }

    public static class AttributesHelperExtension
    {
        public static string ToDescription(this Enum value)
        {
            var da =
                (DescriptionAttribute[])
                (value.GetType().GetField(value.ToString())).GetCustomAttributes(
                        typeof(DescriptionAttribute),
                        false
                        );

            return (
                da.Length > 0 ?
                da[0].Description : value.ToString()
                );
        }
    }
}
