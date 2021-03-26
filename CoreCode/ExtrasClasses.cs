using System;

namespace CoreCode
{
    public class ExtrasClasses
    {
        //Classes para exemplo de fluxo de código sem "valor" de retorno
        public class Employee
        {
            public string Type { get; set; }
        }
        public class registry
        {
            public static bool deleteReference(bool v) => throw new NotImplementedException();
            public static bool deleteReference(string v) => throw new NotImplementedException();
        }

        public class configKeys
        {
            public static bool deleteKey(bool v) => throw new NotImplementedException();
            public static bool deleteKey(string v) => throw new NotImplementedException();
        }

        public class Page
        {
            public Name name { get; set; }
        }

        public class Name
        {
            public string makeKey { get; set; }
        }
    }
}
