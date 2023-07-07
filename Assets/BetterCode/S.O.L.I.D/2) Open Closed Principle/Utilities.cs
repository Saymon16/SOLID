using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OpenClosedPrinciple_After
{
    public class Utilities
    {
        public static List<T> GetAllClassesInheritingFrom<T>()
        {
            List<T> resultList = new List<T>();
            foreach (Type t in FindDerivedTypes(Assembly.GetExecutingAssembly(), typeof(T)))
            {
                var instance = (T) Activator.CreateInstance(t);
                resultList.Add(instance);
            }

            return resultList;
        }

        private static IEnumerable<Type> FindDerivedTypes(Assembly assembly, Type baseType)
        {
            return assembly.GetTypes().Where(t => t != baseType && baseType.IsAssignableFrom(t));
        }
    }
}