namespace MudBase.Helpers
{
    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }

        public StringValue()
        {
            _value = "";
        }

        public string MobName { get { return _value; } set { _value = value; } }
        string _value;
    }
}