
using libraryMS;

class Program
{
    static void Main(string[] args)
    {
        LibraryManager.InitializeBooks();                //initialize some books at the strat ,to the LibraryManager.BooksStore dynamic array

        LibraryManager.InitializeMembers();              //initialize some members at the start,to the LibraryManager.MemberStroe dynamic array

        LibraryManager.InitializeWaiters();

        DynamicArray<OutgoneBook> OutgoneBooks = new DynamicArray<OutgoneBook>();   //dyanamic array to store outgonebooks details



      

        Service.GetMainMenu();

        

        string Continuity = "y";

        while (Continuity == "y")
        {
            Console.Write("\n>> ");
            string Operation_selected = Console.ReadLine();
            Console.WriteLine();

            switch (Operation_selected)
            {
                case "add -book":
                    Book? NewBook = Service.CreateBook();         //adding books further from the console
                    LibraryManager.BooksStore.Add(NewBook);
                    break;
                case "add -mem":
                    Member member = Service.CreateMember();     //adding members further from the console
                    LibraryManager.MemberStore.Add(member);
                    break;
                case "read -mem":
                    Console.Write("\nenter member id: ");
                    string member_id= Console.ReadLine();
                    Console.WriteLine();
                    Service.ReadMember(LibraryManager.MemberStore, member_id);
                    break;
                case "bor":
                    Service.BorrowBook(LibraryManager.BooksStore,OutgoneBooks);
                    break;
                case "ret":
                    Console.Write("Member ID: ");
                    Service.ReturnBook(OutgoneBooks,Console.ReadLine());
                    break;
                case "out":
                    Service.ReadOutgoneBooks(OutgoneBooks);
                    break;
                case "out-sort":
                    Service.SortOutgoneBooksByDate(OutgoneBooks);
                    break;
                case "mem-sort-name":
                    Service.SortMembersByName(LibraryManager.MemberStore);  // Sort the member list
                    break;
                case "mem-sort-regday":
                    Service.SortMembersbyRegday(LibraryManager.MemberStore);
                    break;
                case "mem-all":
                    Service.ReadAllMembers(LibraryManager.MemberStore);
                    break;
                case "wlist":
                    Service.GetWaitersList();
                    break;
                case "wl-clear-top":
                    Service.ClearTopWlist();
                    break;
                case "exit":
                    break;
                case "help":
                    Service.GetMainMenu();
                    break;
                default:
                    Console.WriteLine("you have not give proper input");
                    break;

            }

            if(Operation_selected == "exit")
            {
                break;
            }
            Continuity = "y";
        }

    }
}