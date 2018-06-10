using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using HomeLibrary.Models;
namespace HomeLibrary.Models
{
    public static class BooksToXML
    {

        public static void Serialize(Library lib)
        {
            var serializer = new XmlSerializer(typeof(List<Book>));
            var writer = XmlWriter.Create("library.xml");
            serializer.Serialize(writer, lib.Books);
            writer.Close();
        }

        public static void Deserialize(Library lib)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Book>));
                var reader = XmlReader.Create("library.xml");
                var result = (List<Book>)(serializer.Deserialize(reader));
                lib.Books.Clear();
                lib.Books.AddRange(result);
                reader.Close();
            }
            catch(Exception)
            {

            }
        }
    }
}
