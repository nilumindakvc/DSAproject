using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace libraryMS
{
    public  static class Service
    {
        public static Book? CreateBook()                  // a function, get inputs through the console,return those with book object
        {
            

            Console.WriteLine("availabe insertable categories \n\nm  -  math\np  -  phy\nc  -  chem\ne  -  econ\ncs -  comSc\nb  -  bio\nbs -  bussi\n");
            Console.Write("add ?(y/n): ");
            if (Console.ReadLine() == "n")
            {
                return null;
            }
            else
            {
                Console.WriteLine();
                Book book = new Book();

                Console.Write("{0,-25} :","Category");
               
                switch (Console.ReadLine())
                {
                    case "m":
                        book.Category = "Mathematics";
                        break;
                    case "p":
                        book.Category = "Physics";
                        break;
                    case "c":
                        book.Category = "Chemistry";
                        break;
                    case "e":
                        book.Category = "Economics";
                        break;
                    case "cs":
                        book.Category = "Computer Science";
                        break;
                    case "b":
                        book.Category = "Biology";
                        break;
                    case "bs":
                        book.Category = "Business";
                        break;
                    default:
                        Console.WriteLine("you have not give proper input");
                        break;
                }


                Console.Write("{0,-25} :","Book Id (XXX-integers)");
                book.BookId = Convert.ToInt32(Console.ReadLine());

                Console.Write("{0,-25} :","Title");
                book.Title = Console.ReadLine();

                Console.Write("{0,-25} :","ISBN (XXXX-integers)");
                book.ISBN = Console.ReadLine();

                Console.Write("{0,-25} :","Author");
                book.Author = Console.ReadLine();



                Console.Write("{0,-25} :","NumofCopies");
                book.Numof_Copies = Convert.ToInt32(Console.ReadLine());

                book.Numof_Borrows = 0;

                return book;
            }

            
        }

        public static Member CreateMember()        //take input from console for new member,return those with member obj
        {
            Member member = new Member();

            Console.Write("{0,-25} :", "User Id (MEXXXX-integers)");
            member.UserId = Console.ReadLine();

            Console.Write("{0,-25} :", "UserName");
            member.UserName = Console.ReadLine();

            Console.Write("{0,-25} :", "Email");
            member.Email = Console.ReadLine();

            return member;
        }

        //this function will automatically call wahen a member take a book,within a another function
        public static OutgoneBook CreateOutgoneBook(string BookName,int BookId,string BorrowerId)
        {
            OutgoneBook Outgone_book = new OutgoneBook();

            Outgone_book.Title = BookName;
            Outgone_book.BookId=BookId;
            Outgone_book.MemberId=BorrowerId;
            Outgone_book.OutGoneDate=DateTime.Now;
           


            return Outgone_book;
        }

        public static void  ReadMember(DynamicArray<Member> MemberStore ,string user_id)
        {
             
            // linear serch is implemented here

            for(int i = 0; i < MemberStore.count; i++)
            {
               Member reading_member = MemberStore.GetObj(i);
               if(reading_member.UserId== user_id)
                {
                    Console.WriteLine("Member Name    : "+reading_member.UserName);
                    Console.WriteLine("Member Email   : "+reading_member.Email);
                    Console.WriteLine("registered Day : "+reading_member.RegisteredDay.ToShortDateString());
                    break;
                }

            }
        }


        public static void BorrowBook( DynamicArray<Book> bookStore,DynamicArray<OutgoneBook> outgoneBooks)
        {
            Console.WriteLine(
                "Available Categories" +
                "\nMathematics         m"+
                "\nPhysics             p"+
                "\nChemistry           c"+
                "\nEconomics           e"+
                "\nComputer Science    cs"+
                "\nBiology             b"+
                "\nBusiness            bs"
            );

            bool MemberIdEntered = false;
            int FurtherBooks = 1;
            string borrower_id = " ";
            int bookid_or_exit = 1;

            do
            {

                Console.Write("enter category: ");
                string user_input = Console.ReadLine();

                string category;

                switch (user_input)
                {
                    case "m":
                        category = "Mathematics";
                        break;
                    case "p":
                        category = "Physics";
                        break;
                    case "c":
                        category = "Chemistry";
                        break;
                    case "e":
                        category = "Economics";
                        break;
                    case "cs":
                        category = "Computer Science";
                        break;
                    case "b":
                        category = "Biology";
                        break;
                    case "bs":
                        category = "Business";
                        break;
                    default:
                        category = "invalid";
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("avilable books\n");

                DynamicArray<Book> BookBucket = new DynamicArray<Book>(); //this dynamic array is for seperating some books from bookstore

                Console.WriteLine("{0,-30}  {1,-10}", "Title", "ID");
                Console.WriteLine();
                for (int i = 0; i < bookStore.count; i++)
                {
                    Book book = bookStore.GetObj(i);
                    if (book.Category == category)                  //linear serch going here
                    {
                        Console.WriteLine("{0,-30} | {1,-10}",book.Title,book.BookId);
                        BookBucket.Add(book);
                    }
                }





                Console.Write("\nenter book id or exit by 0 : ");
                bookid_or_exit = Convert.ToInt32(Console.ReadLine());

                if (bookid_or_exit != 0)
                {

                    for (int i = 0; i < BookBucket.count; i++)
                    {
                        Book book = BookBucket.GetObj(i);
                        if (bookid_or_exit == book.BookId)
                        {
                            if (book.Numof_Copies == 0)
                            {
                                Console.WriteLine("\nNo copies are available");
                                if(borrower_id==" ")
                                {
                                    Console.Write("Enter ID (MExxxx): ");
                                    borrower_id=Console.ReadLine();
                                }
                                Console.WriteLine("you will be added to waiting list");
                                BookWaiter waiter = new BookWaiter(borrower_id, book.Title, DateTime.Now);
                                LibraryManager.WaiterList.EnQueue(waiter);

                                Console.Write("for more books enter 1 or exit by 0: ");
                                FurtherBooks = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                if (MemberIdEntered == false)
                                {
                                    Console.Write("enter your MemberId (MEXXXX): ");
                                    borrower_id = Console.ReadLine();
                                    MemberIdEntered = true;
                                }

                                OutgoneBook outedBook = CreateOutgoneBook(book.Title, book.BookId, borrower_id);
                                outgoneBooks.Add(outedBook);

                                //if there is a same request in the waiter list it will remove from below
                                RemoveMiddleElemetFromQueue(LibraryManager.WaiterList, borrower_id, book.Title);


                                Console.WriteLine("\nBook name :" + book.Title + " is borrowed ");
                                book.Numof_Copies -= 1;
                                Console.WriteLine("remain copies: " + book.Numof_Copies);

                                Console.Write("for more books enter 1 or exit by 0: ");
                                FurtherBooks = Convert.ToInt32(Console.ReadLine());

                            }

                        }

                    }
                }
            } while (FurtherBooks != 0 && bookid_or_exit != 0);
        }
        
        public static void ReturnBook(DynamicArray<OutgoneBook> outedbooks,string memberId)
        {
            int size=outedbooks.count;
            bool taken=false;   

            

            for(int i = 0; i < size; i++)
            {
                if (memberId == outedbooks.GetObj(i).MemberId)
                {
                    taken = true;
                    Console.Write("{0,-30} {1,-20} :", outedbooks.GetObj(i).Title,"submitted(y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        for (int k = 0; k < LibraryManager.BooksStore.count; k++)
                        {
                            if (LibraryManager.BooksStore.GetObj(k).Title == outedbooks.GetObj(i).Title)
                            {
                                LibraryManager.BooksStore.GetObj(k).Numof_Copies++;
                            }
                        }
                        outedbooks.Remove(i);
                      
                        i--;
                        size--;
                    }
                }

            }
            if (taken == false)
            {
                Console.WriteLine("not borrowed any book");
            }


        }

        public static void ReadOutgoneBooks(DynamicArray<OutgoneBook> outsideBooks)
        {
            if (outsideBooks.count == 0)
            {
                Console.WriteLine("no book gone out side");
            }
            else
            {
                Console.WriteLine("{0, -10}  {1 ,-30}  {2,-10}  {3,-35}","BookID","Title","MemberID","OutgoneDate");
                Console.WriteLine();

                for(int i = 0;i < outsideBooks.count; i++)
                {
                    OutgoneBook book = outsideBooks.GetObj(i);
                    Console.WriteLine("{0, -10} | {1 ,-30} | {2,-10} | {3,-35}",book.BookId,book.Title,book.MemberId,book.OutGoneDate);
                }
            }
        }


        public static void SortOutgoneBooksByDate(DynamicArray<OutgoneBook> outgonebooks)
        {
            if(outgonebooks.count == 0)
            {
                Console.WriteLine("no book gone out to sort");
                return;
            }
             
              Console.WriteLine("\noldest  bookout to top --> ofst" +
                                 "\nnewest bookout to top  --> nfst");
              Console.Write("\nenter the order: ");
              string user_input=Console.ReadLine();

            int n = outgonebooks.count;

            if (user_input == "ofst")
            {

                for (int i = 0; i < n - 1; i++)                                 //bubble sort for accending order sorting
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        OutgoneBook book1 = outgonebooks.GetObj(j);
                        OutgoneBook book2 = outgonebooks.GetObj(j + 1);

                        if (book1.OutGoneDate > book2.OutGoneDate)
                        {
                            // Swap two outgonebook objects

                            OutgoneBook temp = new OutgoneBook();

                            temp.BookId = book1.BookId;
                            temp.Title = book1.Title;
                            temp.MemberId = book1.MemberId;
                            temp.OutGoneDate = book1.OutGoneDate;

                            book1.BookId = book2.BookId;
                            book1.Title = book2.Title;
                            book1.MemberId = book2.MemberId;
                            book1.OutGoneDate = book2.OutGoneDate;

                            book2.BookId = temp.BookId;
                            book2.Title = temp.Title;
                            book2.MemberId = temp.MemberId;
                            book2.OutGoneDate = temp.OutGoneDate;

                        }
                    }
                }
                Console.WriteLine("sorted");
            }
            else
            {

                for (int i = 0; i < n - 1; i++)                                 //bubble sort for deccending  order sorting
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        OutgoneBook book1 = outgonebooks.GetObj(j);
                        OutgoneBook book2 = outgonebooks.GetObj(j + 1);

                        if (book1.OutGoneDate < book2.OutGoneDate)
                        {
                            // Swap two outgonebook objects

                            OutgoneBook temp = new OutgoneBook();

                            temp.BookId = book1.BookId;
                            temp.Title = book1.Title;
                            temp.MemberId = book1.MemberId;
                            temp.OutGoneDate = book1.OutGoneDate;

                            book1.BookId = book2.BookId;
                            book1.Title = book2.Title;
                            book1.MemberId = book2.MemberId;
                            book1.OutGoneDate = book2.OutGoneDate;

                            book2.BookId = temp.BookId;
                            book2.Title = temp.Title;
                            book2.MemberId = temp.MemberId;
                            book2.OutGoneDate = temp.OutGoneDate;

                        }
                    }
                }
                Console.WriteLine("sorted");
            }
            
        }



        //Insertion sort deneth
        // Edit Start: Fixed sorting logic to correctly alphabetically sort the members by UserName in a case-insensitive way.
        public static void SortMembersByName(DynamicArray<Member> MemberStore)
        {
            // 1. Create a copy of the members
            Member[] members = new Member[MemberStore.count];
            for (int i = 0; i < MemberStore.count; i++)
            {
                members[i] = MemberStore.GetObj(i);
            }

            // 2. Sort the members array using Insertion Sort
            for (int i = 1; i < members.Length; i++)
            {
                Member key = members[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(members[j].UserName, key.UserName) > 0)
                {
                    members[j + 1] = members[j];
                    j--;
                }

                members[j + 1] = key;
            }

            // 3. Clear and update the MemberStore
            MemberStore.count = 0;
            foreach (var member in members)
            {
                MemberStore.Add(member);
            }

            Console.WriteLine("sorted");

        }

        public static void ReadAllMembers(DynamicArray<Member> MemberStore)
        {
            Console.WriteLine("\nMember List:\n");

            Console.WriteLine("{0,-10}  {1,-20}  {2,-25}", "ID", "Username", "RegisteredOn");
            Console.WriteLine();

           
            for (int i = 0; i < MemberStore.count; i++)
            {
                Member member = LibraryManager.MemberStore.GetObj(i);  // Fetch the sorted member
                Console.WriteLine("{0,-10} | {1,-20} | {2,-25}", member.UserId, member.UserName, member.RegisteredDay);
            }
        }

        public static void GetWaitersList()
        {
            LibraryManager.WaiterList.Display();
        }

        public static void ClearTopWlist()
        {
            LibraryManager.WaiterList.DeQueue();
        }

        public static void SortMembersbyRegday(DynamicArray<Member> MemberStore)  //using selection sort 
        {
            int size = MemberStore.count;

            for (int i = 0; i < size - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (MemberStore.GetObj(j).RegisteredDay > MemberStore.GetObj(min).RegisteredDay)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    Member temp=new Member();

                    temp.UserId = MemberStore.GetObj(i).UserId;
                    temp.UserName = MemberStore.GetObj(i).UserName;
                    temp.Email = MemberStore.GetObj(i).Email;
                    temp.RegisteredDay = MemberStore.GetObj(i).RegisteredDay;

                    MemberStore.GetObj(i).UserId = MemberStore.GetObj(min).UserId;
                    MemberStore.GetObj(i).UserName = MemberStore.GetObj(min).UserName;
                    MemberStore.GetObj(i). Email= MemberStore.GetObj(min).Email;
                    MemberStore.GetObj(i).RegisteredDay = MemberStore.GetObj(min).RegisteredDay;

                    MemberStore.GetObj(min).UserId = temp.UserId;
                    MemberStore.GetObj(min).UserName = temp.UserName;
                    MemberStore.GetObj(min).Email = temp.Email;
                    MemberStore.GetObj(min).RegisteredDay = temp.RegisteredDay;

                    
                }
              
            }
            Console.WriteLine("sorted");
        }

        private static void RemoveMiddleElemetFromQueue(CircularQueue waiterQueue,string waiterID,string booktitle)
        {
            DynamicArray<BookWaiter> TemporyArray=new DynamicArray<BookWaiter>();

            while (waiterQueue.Front != -1)
            {
                TemporyArray.Add(waiterQueue.DeQueueObjReturn());
            }
            int arrayCount=TemporyArray.count;
            for(int i = 0; i < arrayCount; i++)
            {
                if(TemporyArray.GetObj(i).WaiterId==waiterID && TemporyArray.GetObj(i).BookWaitFor == booktitle)
                {
                    TemporyArray.Remove(i);
                    break;
                }
            }
            int arrayNewCount=TemporyArray.count;
            for(int j=0; j < arrayNewCount; j++)
            {
                waiterQueue.EnQueue(TemporyArray.GetObj(j));
            }
            
               

        }

        public static void GetMainMenu()
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine();

            Console.WriteLine(
            
              "Borrow book                ->  bor\n" +
              "Return book                ->  ret\n" +
              "Outgone books              ->  out\n" +
              "Sort Outgone books by date ->  out-sort\n" +
              "Read all members           ->  mem-all\n" +               //update deneth
              "Sort members by name       ->  mem-sort-name\n" +
              "Sort members by regDay     ->  mem-sort-regday\n" +
              "Get waiterList             ->  wlist\n" +
              "Clear top of Wlist         ->  wl-clear-top\n" +
              "Add new book               ->  add-book\n" +
              "Add new member             ->  add-mem\n" +
              "Read member                ->  read-mem\n" +
              "Get main menu              ->  help\n" +
              "Exit the programme         ->  exit"
            );

        }

        //public static void SortMembersbyRegisterdDay()
        //{

        //}

    }
}
