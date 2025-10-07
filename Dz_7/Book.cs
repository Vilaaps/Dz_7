//internal class Book
//    {
//        private string title;
//        private string author;
//        private int year;
//        private bool isAvailable;
//        public Book()
//        {
//            this.title = "Мёртвые души";
//            this.author = " Н. В. Гоголя";
//            this.year = 1842;
//            this.isAvailable = true;
//        }
//        public Book(string title, string author = "Неизвестно", int year = 0, bool isAvailable = false)
//        {
//            this.title = title;
//            this.author = author;
//            this.year = year;
//            this.isAvailable = isAvailable;
//        }
//        public void PrintInfo()
//        {
//            string status;
//            if (this.isAvailable)
//                status = "Да";
//            else
//                status = "Нет";

//            Console.WriteLine("название - " + this.title +  ", автор - " + this.author + ", год издания - " + this.year + ", доступна ли для выдачи - " + status);
//        }
//    }