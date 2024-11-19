namespace Phone_Book_Application
{
    public class PhoneBookList<T> where T : PhoneBookModel
    {
        // Properties
        public PhoneBookNode<T>? Head {get; private set;}

        public PhoneBookNode<T>? Tail {get; private set;}

        public int Count {get; set;} = 0;

        #region Constructor
        public PhoneBookList(PhoneBookNode<T>? entry=null)
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        #endregion

        #region Adding an Entry
        public void AddAnEntry(T entry)
        {
            //Create a new node when the method is called.
            var newNode = new PhoneBookNode<T>(entry);
            if (Head == null)
            {
                Head = newNode;
            }
            
            else
            {
                var current = Head;
                while (current.Next is not null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Prev = current;
            }
            Count++;
            Sorting();

            // current = newNode;
        }
        #endregion

        #region Viewing all the entries
        public IEnumerable<T> ViewAllEntry() 
        {
            if (Count == 0 || Head is null)
            {
                yield break;
            }

            var start = Head;
            while (start is not null)
            {
                //Returns the value of the nodes
                yield return start.Value;
                var next = start.Next;
                start = next;
            }
        }
        #endregion

        #region Upating an Entry
        // public bool UpdateAnEntry(int index ,string name, double newphonenumber, string newaddress)
        // {
        //     if (Count <= index || index < 0)
        //     {
        //         throw new IndexOutOfRangeException("Index is out of range.");
        //     }


        //     var current = Head;
        //     var indexnode = 0;
        //     // index++;
        //     while (current is not null)
        //     {
        //         if (indexnode == index)
        //         {
        //             if (name)
        //             {
        //                 current.Value.Name = name;
        //             }

        //             // if (newphonenumber.HasValue)
        //             // {
        //             //     current.Value.PhoneNumber = newphonenumber;
        //             // }

        //             if (newphonenumber)
        //             {
        //                 current.Value.PhoneNumber = newphonenumber;
        //             }

        //             if (newaddress)
        //             {
        //                 current.Value.Address = newaddress;
        //             }
        //             return true;
        //         }

        //         current = current.Next;
        //         indexnode++;
        //     }
        //     return false;
        public bool UpdateName(int index, string newname)
        {
            if (Count <= index || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            var current = Head;
            var currentPosition = 0;
            while (current is not null)
            {
                if (currentPosition == index)
                {
                    if (newname is not null)
                    {
                        current.Value.Name = newname;
                        System.Console.WriteLine(current.Value);
                    }
                    return true;
                }
                current = current.Next;
                currentPosition++;
            }
            return false;
        }

        public bool UpdatePhonenumber(int index, string newphonenumber)
        {
            if (Count <= index || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            var current = Head;
            var currentPosition = 0;
            while (current is not null)
            {
                if (currentPosition == index)
                {
                    if (newphonenumber != null)
                    {
                        current.Value.PhoneNumber = newphonenumber;
                        System.Console.WriteLine(current.Value);
                    }
                    return true;
                }
                current = current.Next;
                currentPosition++;
            }
            return false;
        }

        public bool UpdateAddress(int index, string newAddress)
        {
           if (Count <= index || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            } 
            var current = Head;
            var currentPosition = 0;
            while (current is not null)
            {
                if (currentPosition == index)
                {
                    current.Value.Address = newAddress;
                    System.Console.WriteLine(current.Value);
                    return true;
                }
                current = current.Next;
                currentPosition++;
            }
            return false;
        }



        
        #endregion

        #region Search For an Entry
        public T? SearchAnEntry(string name)
        {
            if (Count == 0)
            {
                return default;
            }

            var start = Head;
            while (start is not null)
            {
                System.Console.WriteLine($"Checking: {start.Value.Name}");
                if (string.Equals(start.Value.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("Entry found");
                    System.Console.WriteLine(start.Value);
                    return start.Value;
                }
                start = start.Next;
            }
            System.Console.WriteLine("Entry not found");
            return default;
        }

        public T? SearchNumber(string phonenumber)
        {
            if (Count == 0)
            {
                return default;
            }

            var start = Head;
            while (start is not null)
            {
                System.Console.WriteLine($"Checking: {start.Value.PhoneNumber}");
                if (String.Equals(start.Value.PhoneNumber, phonenumber))
                {
                    System.Console.WriteLine("Entry Found!");
                    System.Console.WriteLine(start.Value);
                    return start.Value;
                }
                start = start.Next;
            }
            System.Console.WriteLine("Entry not found");
            return default;
        }

        public T? SearchAddress(string address)
        {
            if (Count == 0)
            {
                return default;
            }

            var start = Head;
            while (start is not null)
            {
                System.Console.WriteLine($"Checking: {start.Value.Address}");
                if (String.Equals(start.Value.Address, address,StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("Entry Found!");
                    System.Console.WriteLine(start.Value);
                    return start.Value;
                }
                start = start.Next;
            }
            System.Console.WriteLine("Entry not found");
            return default;
        }
        #endregion


        #region Delete an Entry
        public void DeleteAnEntry(int index)
        {
            if (index<0)
            {
                throw new IndexOutOfRangeException();
            }

            var currentPosition = 0;
            var currentNode = Head;
            while (currentNode is not null)
            {
                if (currentPosition == index)
                {
                    if (currentNode == Head)
                    {
                        Head = Head.Next;
                    }

                    if (currentNode==Tail)
                    {
                        Tail.Prev.Next = Tail;
                    }

                    else
                    {
                        currentNode.Prev.Next = currentNode.Next;
                        currentNode.Next.Prev = currentNode.Prev;
                    }
                    Count--;
                    System.Console.WriteLine("Delete Successfull");
                    break;
                }
                currentNode = currentNode.Next;
                currentPosition++;
            }
            
        }
        #endregion

        #region Sorting

        public void Sorting()
        {
            if (Count<=1)
            {
                return;
            }

            var current = Head;
            while (current.Next is not null)
            {
                //The Compare method is used to compare two string and returns a integer.
                var compair = String.Compare(current.Value.ToString(), current.Next.Value.ToString(), true);
                if (compair > 0)
                {
                    var temp = current.Value;
                    current.Value = current.Next.Value;
                    current.Next.Value = temp;
                }
                current = current.Next;
            }
        }
        #endregion

    }
}