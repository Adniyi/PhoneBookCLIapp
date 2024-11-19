namespace Phone_Book_Application
{
    public class PhoneBookNode<T> where T : PhoneBookModel
    {
        public T Value {get; set;}

        public PhoneBookNode<T>? Next {get; set;}

        public PhoneBookNode<T>? Prev {get; set;}

        public PhoneBookNode(T value, PhoneBookNode<T>? next = null, PhoneBookNode<T>? prev = null)
        {
            Value = value;
            Next = next;
            Prev = prev;    
        }
    }
}