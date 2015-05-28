namespace Mud.Helpers
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

        public string Name { get { return _value; } set { _value = value; } }
        string _value;
    }
}