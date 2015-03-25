using System;
using System.Collections.Generic;
using System.IO;

namespace Mas.Mp1
{
    public class ObjectExtension
    {
        public static Dictionary<Type, List<object>> ExtentDictionary { get; private set; }

        public ObjectExtension()
        {
            if (ExtentDictionary == null)
            {
                CreateExtentDictionary();
            }
            var self = this;
            var selfType = self.GetType();

            List<object> classExtentList;
            if (ExtentDictionary.ContainsKey(selfType))
            {
                classExtentList = ExtentDictionary[selfType];
            }
            else
            {             
                classExtentList = new List<object>();
                ExtentDictionary.Add(selfType, classExtentList);
            }

            classExtentList.Add(self);

            Console.WriteLine("Current object type: {0}", selfType);
        }

        public static void CreateExtentDictionary()
        {
            if (ExtentDictionary == null)
            {
                ExtentDictionary = new Dictionary<Type, List<object>>();
            }
        }

        /// <summary>
        ///     Creates a class extent dictionary from the provided stream.
        /// </summary>
        /// <param name="extentDictionary"></param>
        public static void CreateExtentDictionary(Dictionary<Type, List<Object>> extentDictionary )
        {
            if (ExtentDictionary == null)
            {
                ExtentDictionary = extentDictionary;
            }
        }

    }
}