using System;
using System.Globalization;
using System.Text;

namespace DefineClasses
{
    class GSM
    {   // fields
        private static GSM iPhone4S;
        private double? price = null;
        private string ownerName = string.Empty;
        private string manufacturer;
        private Battery battery;
        private Display display;
        // constructors
        static GSM()
        {
            iPhone4S = new GSM("Apple", "iPhone 4S", 600.00, "Apple Store", new Battery("Apple", 200, 8, BatteryType.LiPol), new Display(3.5, 16000000));
        }
        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }
        public GSM(string manufacturer, string model, double? price)
            : this(manufacturer, model, price, null, new Battery(), new Display())
        {
        }
        public GSM(string manufacturer, string model, string owner)
            : this(manufacturer, model, null, owner, new Battery(), new Display())
        {
        }
        public GSM(string manufacturer, string model, Battery battery)
            : this(manufacturer, model, null, null, battery, new Display())
        {
        }
        public GSM(string manufacturer, string model, Display display)
            : this(manufacturer, model, null, null, new Battery(), display)
        {
        }
        public GSM(string manufacturer, string model, Battery battery, Display display)
            : this(manufacturer, model, null, null, battery, display)
        {
        }
        public GSM(string manufacturer, string model, double? price, string owner)
            : this(manufacturer, model, price, owner, new Battery(), new Display())
        {
        }
        public GSM(string manufacturer, string model, double? price, Battery battery)
            : this(manufacturer, model, price, null, battery, new Display())
        {
        }
        public GSM(string manufacturer, string model, double? price, Display display)
            : this(manufacturer, model, price, null, new Battery(), display)
        {
        }
        public GSM(string manufacturer, string model, double? price, string owner, Battery battery)
            : this(manufacturer, model, price, owner, battery, new Display())
        {
        }
        public GSM(string manufacturer, string model, double? price, string owner, Display display)
            : this(manufacturer, model, price, owner, new Battery(), display)
        {
        }
        public GSM(string manufacturer, string model, double? price, string owner, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.Price = price;
            this.OwnerName = owner;
            this.BatteryInfo = battery;
            this.DisplayInfo = display;
        }
        // properties
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            private set
            {
                foreach (var symbol in value)
                {   // Validate maufacturer name
                    if (!char.IsLetterOrDigit(symbol) && symbol != ' ')
                    {
                        throw new FormatException("Manufacturer name could contain only letters, digits and whitespace!");
                    }
                }

                this.manufacturer = value;
            }
        }
        public string Model { get; private set; }
        public double? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative!");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public Battery BatteryInfo
        {
            get { return battery; }
            private set { this.battery = value; }
        }
        public Display DisplayInfo
        {
            get { return display; }
            private set { this.display = value; }
        }
        public string OwnerName
        {
            get
            {
                return this.ownerName;
            }

            set
            {
                foreach (var symbol in value)
                {   // Validate maufacturer name
                    if (!char.IsLetter(symbol) && symbol != ' ')
                    {
                        throw new FormatException("Owner name could contain only letters and whitespaces!");
                    }
                }
                this.ownerName = value;
            }
        }
        // methods
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("{0,-18} {1}", "Manufacturer:", this.Manufacturer);
            info.AppendLine();
            info.AppendFormat("{0,-18} {1}", "Model:", this.Model);
            info.AppendLine();
            info.AppendFormat("{0,-18:F2} {1}",
                "Price:",
                this.price != null ? ((double)price).ToString("C2", CultureInfo.GetCultureInfo("bg-BG")) : "Not available");
            info.AppendLine();
            info.AppendFormat("{0,-18} {1}",
                "Owner:",
                this.OwnerName != null ? this.OwnerName : "Not Available");
            info.AppendLine();
            info.AppendFormat("{0,-18:F2} {1}",
                "Display size:",
                this.display.Size != null ? this.display.Size.ToString() + "\"" : "Not Available");
            info.AppendLine();
            info.AppendFormat("{0,-18:F2} {1}",
                "Number of colors:",
                this.display.NumberOfColors != null ? this.display.NumberOfColors.ToString() : "Not available");
            info.AppendLine();
            info.AppendFormat("{0,-18:F2} {1}", "Battery type:", this.battery.type);
            info.AppendLine();
            info.AppendFormat("{0,-18:F2} {1}",
                "Battery model:",
                this.battery.Model != null ? this.battery.Model.ToString() : "Not Available");
            info.AppendLine();
            info.AppendFormat("{0,-18:F2} {1}",
                "Standby:",
                this.battery.HoursIdle != null ? this.battery.HoursIdle.ToString() + " hours" : "Not Available");
            info.AppendLine();
            info.AppendFormat("{0,-18:F2} {1}",
                "Talk time:",
                this.battery.HoursTalk != null ? this.battery.HoursTalk.ToString() + " hours" : "Not Available");
            info.AppendLine();
            return info.ToString();
        }
    }
}