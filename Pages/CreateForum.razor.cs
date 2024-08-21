using Microsoft.AspNetCore.Components;

namespace Intranet.Pages
{
    public partial class CreateForum : ComponentBase
    {
        public string Username { get; set; } = "Ahmad Sanusi";
        public string PostContent { get; set; }

        protected void CreateNewThread()
        {
            // Implementasi logika untuk membuat thread baru.
            Console.WriteLine("Thread baru telah dibuat oleh: " + Username);
            Console.WriteLine("Isi post: " + PostContent);
        }
    }
}
