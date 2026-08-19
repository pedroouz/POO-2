using System.Xml;
using System.Xml.Serialization;

public class Program
{
    [XmlRoot("alunos")]
    public class Alunos
    {
        [XmlElement("aluno")]
       public List<Aluno> alunos { get; set; }
    }
    public class Aluno
    {
        public string nome {  get; set; }

        public string curso { get; set; }

    }
    static void Main()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Alunos));
        using (StreamReader reader = new StreamReader("alunos.xml"))
        {
            Alunos lista = (Alunos)serializer.Deserialize(reader);

            foreach(var aluno in lista.alunos)
            {
                Console.WriteLine(aluno.nome);
                Console.WriteLine(aluno.curso);
            }
        }
    }
}