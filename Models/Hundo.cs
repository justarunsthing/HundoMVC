namespace HundoMVC.Models
{
    public class Hundo
    {
        public int StartValue { get; set; }
        public int EndValue { get; set; }
        public List<string> Results { get; set; } = [];
        public List<string> Classes { get; set; } = [];
    }
}