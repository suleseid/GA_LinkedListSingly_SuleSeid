namespace System.Collections.Generic
{
    public class LinkedListNode
    {
        public LinkedListNode(object value)
        {
            Value = value;
        }

        public object Value { get; }
        public LinkedListNode Next { get; internal set; }
    }
}