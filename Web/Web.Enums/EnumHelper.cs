using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace eDrago.Enums
{
    public static class EnumHelper
    {
        public static string GetDescription(Enum en)
        {
            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());

            if (memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }

        public static int? GetKey<T>(Enum en)
        {
            int? key = null;
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                if (e.ToString() == en.ToString())
                {
                    key = (int)e;
                }
            }

            return key;
        }

        public static List<KeyValuePair<string, int>> GetEnumList<T>()
        {
            var list = new List<KeyValuePair<string, int>>();
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                list.Add(new KeyValuePair<string, int>(GetDescription((Enum)e), (int)e));
            }
            return list;
        }

        public static List<KeyValuePair<string, string>> GetEnumListValueDescription<T>()
        {
            var list = new List<KeyValuePair<string, string>>();
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                list.Add(new KeyValuePair<string, string>(e.ToString(), GetDescription((Enum)e)));
            }
            return list;
        }
    }

}