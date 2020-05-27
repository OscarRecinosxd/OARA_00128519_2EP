namespace Parcial2
{
    public class NegocioDAO
    {
        public int idbusiness { get; set; }
        public string  name  { get; set; }
        public string description { get; set; }

        public NegocioDAO()
        {
            idbusiness = 0;
            name = "";
            description = "";
        }
    }
}