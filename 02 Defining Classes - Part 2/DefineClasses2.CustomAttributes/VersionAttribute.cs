namespace DefineClasses2
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    [AttributeUsage(AttributeTargets.Class |
                    AttributeTargets.Struct |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum |
                    AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public string Version
        {
            get
            {
                return this.major.ToString() + "." + this.minor.ToString();
            }
            private set
            {
                var values = value.Split('.').Select(int.Parse).ToArray();
                this.major = values[0];
                this.minor = values[1];
            }
        }

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public static void ClassVersionQuery(Type type)
        {
            Type classType = type;
            VersionAttribute versAttr;

            foreach (Attribute attr in classType.GetCustomAttributes(false))
            {
                versAttr = attr as VersionAttribute;
                if (null != versAttr)
                {
                    Console.OutputEncoding = Encoding.UTF8;
                    Console.WriteLine("Version of class {0}: {1}", classType.Name.ToString(CultureInfo.InvariantCulture),
                                      versAttr.Version);
                }
            }
        }
        public static void MethodsVersionQuery(Type type)
        {
            Type classType = type;
            VersionAttribute versAttr;

            foreach (var member in classType.GetMethods())
            {
                foreach (Attribute attr in member.GetCustomAttributes(false))
                {
                    versAttr = attr as VersionAttribute;
                    if (null != versAttr)
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("Version of method {0} in class {1}: {2}", member.Name, classType.Name,
                                          versAttr.Version);
                    }
                } 
            }
        }
    }
}