namespace DefineClasses
{
    class Battery
    {   // constant fields
        public readonly BatteryType type;
        // constructors
        public Battery()
        {
        }
        public Battery(string model)
            : this(model, null, null, BatteryType.Unknown)
        {
        }
        public Battery(BatteryType type)
            : this(null, null, null, type)
        {
        }
        public Battery(string model, BatteryType type)
            : this(model, null, null, type)
        {
        }
        public Battery(string model, ushort? hrsIdle, ushort? hrsTalk)
            : this(model, hrsIdle, hrsTalk, BatteryType.Unknown)
        {
        }
        public Battery(ushort? hrsIdle, ushort? hrsTalk)
            : this(null, hrsIdle, hrsTalk, BatteryType.Unknown)
        {
        }
        public Battery(string model, ushort? hrsIdle, ushort? hrsTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hrsIdle;   // ushort struct validates the input value
            this.HoursTalk = hrsTalk;   // ushort struct validates the input value
            this.type = type;
        }
        // properties
        public string Model { get; private set; }
        public ushort? HoursIdle { get; private set; }
        public ushort? HoursTalk { get; private set; }
    }
}