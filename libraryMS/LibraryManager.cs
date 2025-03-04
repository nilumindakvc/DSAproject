using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMS
{
    public static class LibraryManager
    {
        public static  DynamicArray<Book> BooksStore = new DynamicArray<Book>();
        public static  DynamicArray<Member> MemberStore = new DynamicArray<Member>();
        public static  CircularQueue WaiterList = new CircularQueue(50);
      

        public static void InitializeBooks()
        {

            BooksStore.Add(new Book(101, "ISBN101", "Linear Algebra", "Smith", "Mathematics", 15));
            BooksStore.Add(new Book(102, "ISBN102", "Differential Equations", "Johnson", "Mathematics", 2));
            BooksStore.Add(new Book(103, "ISBN103", "Quantum Mechanics", "Williams", "Physics", 8));
            BooksStore.Add(new Book(104, "ISBN104", "Organic Chemistry", "Brown", "Chemistry", 20));
            BooksStore.Add(new Book(105, "ISBN105", "Microeconomics", "Jones", "Economics", 18));
            BooksStore.Add(new Book(106, "ISBN106", "Macroeconomics", "Garcia", "Economics", 10));
            BooksStore.Add(new Book(107, "ISBN107", "Artificial Intelligence", "Martinez", "Computer Science", 25));
            BooksStore.Add(new Book(108, "ISBN108", "Data Structures", "Davis", "Computer Science", 30));
            BooksStore.Add(new Book(109, "ISBN109", "Calculus", "Rodriguez", "Mathematics", 14));
            BooksStore.Add(new Book(110, "ISBN110", "Statistics", "Martinez", "Mathematics", 22));

            BooksStore.Add(new Book(111, "ISBN111", "Fluid Dynamics", "Hernandez", "Physics", 9));
            BooksStore.Add(new Book(112, "ISBN112", "Thermodynamics", "Lopez", "Physics", 11));
            BooksStore.Add(new Book(113, "ISBN113", "Electromagnetism", "Gonzalez", "Physics", 10));
            BooksStore.Add(new Book(114, "ISBN114", "Biochemistry", "Wilson", "Biology", 12));
            BooksStore.Add(new Book(115, "ISBN115", "Genetics", "Anderson", "Biology", 14));
            BooksStore.Add(new Book(116, "ISBN116", "Botany", "Thomas", "Biology", 10));
            BooksStore.Add(new Book(117, "ISBN117", "Zoology", "Taylor", "Biology", 8));
            BooksStore.Add(new Book(118, "ISBN118", "Neuroscience", "Moore", "Biology", 6));
            BooksStore.Add(new Book(119, "ISBN119", "Machine Learning", "Jackson", "Computer Science", 28));
            BooksStore.Add(new Book(120, "ISBN120", "Neural Networks", "Lee", "Computer Science", 24));

            BooksStore.Add(new Book(121, "ISBN121", "Cryptography", "Perez", "Computer Science", 22));
            BooksStore.Add(new Book(122, "ISBN122", "Computer Vision", "White", "Computer Science", 20));
            BooksStore.Add(new Book(123, "ISBN123", "Database Systems", "Harris", "Computer Science", 27));
            BooksStore.Add(new Book(124, "ISBN124", "Software Engineering", "Clark", "Computer Science", 18));
            BooksStore.Add(new Book(125, "ISBN125", "Operating Systems", "Lewis", "Computer Science", 30));
            BooksStore.Add(new Book(126, "ISBN126", "Algorithms", "Robinson", "Computer Science", 32));
            BooksStore.Add(new Book(127, "ISBN127", "Computer Networks", "Walker", "Computer Science", 25));
            BooksStore.Add(new Book(128, "ISBN128", "Compiler Design", "Young", "Computer Science", 12));
            BooksStore.Add(new Book(129, "ISBN129", "Human-Computer Interaction", "Allen", "Computer Science", 15));
            BooksStore.Add(new Book(130, "ISBN130", "Distributed Systems", "King", "Computer Science", 13));

            BooksStore.Add(new Book(131, "ISBN131", "Software Testing", "Scott", "Computer Science", 17));
            BooksStore.Add(new Book(132, "ISBN132", "Web Development", "Green", "Computer Science", 28));
            BooksStore.Add(new Book(133, "ISBN133", "Artificial Neural Networks", "Baker", "Computer Science", 14));
            BooksStore.Add(new Book(134, "ISBN134", "Parallel Computing", "Adams", "Computer Science", 11));
            BooksStore.Add(new Book(135, "ISBN135", "Data Mining", "Nelson", "Computer Science", 22));
            BooksStore.Add(new Book(136, "ISBN136", "Big Data Analytics", "Carter", "Computer Science", 24));
            BooksStore.Add(new Book(137, "ISBN137", "Natural Language Processing", "Mitchell", "Computer Science", 20));
            BooksStore.Add(new Book(138, "ISBN138", "Pattern Recognition", "Perez", "Computer Science", 16));
            BooksStore.Add(new Book(139, "ISBN139", "Reinforcement Learning", "Roberts", "Computer Science", 19));
            BooksStore.Add(new Book(140, "ISBN140", "Augmented Reality", "Turner", "Computer Science", 10));

            BooksStore.Add(new Book(141, "ISBN141", "Virtual Reality", "Phillips", "Computer Science", 12));
            BooksStore.Add(new Book(142, "ISBN142", "Cloud Computing", "Campbell", "Computer Science", 25));
            BooksStore.Add(new Book(143, "ISBN143", "Internet of Things", "Parker", "Computer Science", 30));
            BooksStore.Add(new Book(144, "ISBN144", "Quantum Computing", "Evans", "Computer Science", 28));
            BooksStore.Add(new Book(145, "ISBN145", "Blockchain Technology", "Edwards", "Computer Science", 18));
            BooksStore.Add(new Book(146, "ISBN146", "Cyber Security", "Collins", "Computer Science", 22));
            BooksStore.Add(new Book(147, "ISBN147", "Ethical Hacking", "Stewart", "Computer Science", 17));
            BooksStore.Add(new Book(148, "ISBN148", "DevOps", "Sanchez", "Computer Science", 29));
            BooksStore.Add(new Book(149, "ISBN149", "Agile Development", "Morris", "Computer Science", 15));
            BooksStore.Add(new Book(150, "ISBN150", "Software Architecture", "Rogers", "Computer Science", 10));

            BooksStore.Add(new Book(151, "ISBN151", "Project Management", "Reed", "Business", 14));
            BooksStore.Add(new Book(152, "ISBN152", "Entrepreneurship", "Cook", "Business", 20));
            BooksStore.Add(new Book(153, "ISBN153", "Marketing Strategies", "Morgan", "Business", 12));
            BooksStore.Add(new Book(154, "ISBN154", "Financial Accounting", "Bell", "Business", 16));
            BooksStore.Add(new Book(155, "ISBN155", "Corporate Finance", "Murphy", "Business", 18));
            BooksStore.Add(new Book(156, "ISBN156", "Investment Analysis", "Bailey", "Business", 11));
            BooksStore.Add(new Book(157, "ISBN157", "Human Resource Management", "Rivera", "Business", 13));
            BooksStore.Add(new Book(158, "ISBN158", "Operations Management", "Cooper", "Business", 15));
            BooksStore.Add(new Book(159, "ISBN159", "Strategic Management", "Richardson", "Business", 10));
            BooksStore.Add(new Book(160, "ISBN160", "Supply Chain Management", "Cox", "Business", 19));

            BooksStore.Add(new Book(161, "ISBN161", "Organizational Behavior", "Howard", "Business", 8));
            BooksStore.Add(new Book(162, "ISBN162", "Leadership Principles", "Ward", "Business", 14));
            BooksStore.Add(new Book(163, "ISBN163", "Consumer Behavior", "Torres", "Business", 18));
            BooksStore.Add(new Book(164, "ISBN164", "Digital Marketing", "Peterson", "Business", 22));
            BooksStore.Add(new Book(165, "ISBN165", "E-Commerce", "Gray", "Business", 25));
            BooksStore.Add(new Book(166, "ISBN166", "Risk Management", "Ramirez", "Business", 15));
            BooksStore.Add(new Book(167, "ISBN167", "Corporate Governance", "James", "Business", 13));
            BooksStore.Add(new Book(168, "ISBN168", "International Business", "Watson", "Business", 17));
            BooksStore.Add(new Book(169, "ISBN169", "Business Ethics", "Brooks", "Business", 12));
            BooksStore.Add(new Book(170, "ISBN170", "Innovation Management", "Kelly", "Business", 18));

            BooksStore.Add(new Book(171, "ISBN171", "Principles of Microbiology", "Sanders", "Biology", 20));
            BooksStore.Add(new Book(172, "ISBN172", "Environmental Science", "Price", "Science", 22));
            BooksStore.Add(new Book(173, "ISBN173", "Earth Science", "Bennett", "Science", 14));
            BooksStore.Add(new Book(174, "ISBN174", "Astrophysics", "Wood", "Physics", 10));
            BooksStore.Add(new Book(175, "ISBN175", "Geology", "Barnes", "Science", 12));

        }


        public static void InitializeMembers()
        {
            Random rand = new Random();

            DateTime RandomDate()
            {
                DateTime start = new DateTime(2020, 1, 1); 
                int range = (DateTime.Today - start).Days;
                return start.AddDays(rand.Next(range)).AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60));
            }

            MemberStore.Add(new Member("ME101", "Nimal", "nimal@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME102", "Sunil", "sunil@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME103", "Amara", "amara@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME104", "Kamal", "kamal@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME105", "Saman", "saman@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME106", "Nimali", "nimali@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME107", "Ruwan", "ruwan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME108", "Chandana", "chandana@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME109", "Indika", "indika@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME110", "Sanjeewa", "sanjeewa@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME111", "Lalith", "lalith@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME112", "Dinesh", "dinesh@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME113", "Nuwan", "nuwan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME114", "Tharindu", "tharindu@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME115", "Harsha", "harsha@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME116", "Gayan", "gayan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME117", "Anura", "anura@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME118", "Sarath", "sarath@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME119", "Ranjith", "ranjith@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME120", "Kushan", "kushan@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME121", "Prasanna", "prasanna@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME122", "Mahesh", "mahesh@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME123", "Jayani", "jayani@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME124", "Sameera", "sameera@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME125", "Dilshan", "dilshan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME126", "Nadeeka", "nadeeka@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME127", "Hasitha", "hasitha@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME128", "Anjali", "anjali@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME129", "Buddhika", "buddhika@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME130", "Chathurika", "chathurika@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME131", "Dulani", "dulani@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME132", "Fazal", "fazal@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME133", "Gayathri", "gayathri@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME134", "Heshan", "heshan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME135", "Isuru", "isuru@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME136", "Janaka", "janaka@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME137", "Kavindu", "kavindu@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME138", "Lasith", "lasith@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME139", "Madhavi", "madhavi@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME140", "Nirosha", "nirosha@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME141", "Oshini", "oshini@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME142", "Pradeep", "pradeep@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME143", "Rashmi", "rashmi@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME144", "Shanika", "shanika@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME145", "Taniya", "taniya@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME146", "Udara", "udara@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME147", "Vimukthi", "vimukthi@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME148", "Waruna", "waruna@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME149", "Yohan", "yohan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME150", "Zain", "zain@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME151", "Ashan", "ashan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME152", "Bhagya", "bhagya@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME153", "Chamara", "chamara@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME154", "Dilan", "dilan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME155", "Eranga", "eranga@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME156", "Farzan", "farzan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME157", "Gehan", "gehan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME158", "Hiruni", "hiruni@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME159", "Imalsha", "imalsha@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME160", "Jeewantha", "jeewantha@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME161", "Kavishka", "kavishka@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME162", "Lakshan", "lakshan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME163", "Madhushan", "madhushan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME164", "Nadun", "nadun@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME165", "Pasan", "pasan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME166", "Ravindu", "ravindu@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME167", "Sanduni", "sanduni@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME168", "Thilini", "thilini@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME169", "Udani", "udani@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME170", "Vinuja", "vinuja@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME171", "Avishka", "avishka@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME172", "Bimal", "bimal@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME173", "Chathura", "chathura@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME174", "Dimuthu", "dimuthu@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME175", "Eshan", "eshan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME176", "Fahim", "fahim@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME177", "Gehan", "gehan@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME178", "Harini", "harini@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME179", "Iresh", "iresh@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME180", "Jeewan", "jeewan@gmail.com", RandomDate()));

            MemberStore.Add(new Member("ME181", "Kasuni", "kasuni@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME182", "Lahiru", "lahiru@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME183", "Malith", "malith@gmail.com", RandomDate()));
            MemberStore.Add(new Member("ME184", "Nadeesh", "nadeesh@gmail.com", RandomDate()));
          

        }

        public static void InitializeWaiters()
        {
            WaiterList.EnQueue(new BookWaiter("ME7890","Fluid Mechanics",DateTime.Now.AddDays(-5)));
            WaiterList.EnQueue(new BookWaiter("ME2021", "Data Structures and Algorithms", DateTime.Now.AddDays(-4)));
            WaiterList.EnQueue(new BookWaiter("ME3050", "Circuit Analysis", DateTime.Now.AddDays(-3)));
            WaiterList.EnQueue(new BookWaiter("ME4100", "Business Analytics", DateTime.Now.AddDays(-2)));
            WaiterList.EnQueue(new BookWaiter("ME5100", "Environmental Engineering", DateTime.Now.AddDays(-1)));

        }
    }
}
