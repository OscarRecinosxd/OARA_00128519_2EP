namespace Parcial2
{
    public class Usuario
    {
            public int  iduser { get; set; }
            public string fullname { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public bool usertype { get; set; }

            public Usuario()
            {
                iduser = 0;
                fullname = "";
                username = "";
                password = "";
                usertype = false;
            }
    }
}