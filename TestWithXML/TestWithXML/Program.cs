using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestWithXML
{
    class Program
    {
        static void Main(string[] args)
        {

            using (XmlWriter writer = XmlWriter.Create("testXmlFile.xml"))
            {

                writer.WriteStartDocument();

                writer.WriteStartElement("book");

                
                writer.WriteAttributeString("name", "the Foundation");

                

                writer.WriteElementString("price", "19.95");

                // Write the close tag for the root element.
                writer.WriteEndElement();

                writer.WriteEndDocument();
            }

            using (XmlReader reader = XmlReader.Create("testXmlFile.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.HasAttributes)
                        {
                            Console.WriteLine("start element with Attributes: " + reader.Name);
                            Console.WriteLine("\t attribute: " + reader.GetAttribute(0));

                        }
                        else
                        {
                            if(!reader.IsEmptyElement)
                            {
                                Console.WriteLine("start element without Attributes: " + reader.Name);

                                if(reader.Name.Equals("price"))
                                {
                                    reader.Read();
                                    Console.WriteLine("\t value: " + reader.Value);
                                }
                            }


                        }
                    }

                    
                }
            }

            Console.WriteLine("done");
                Console.Read();

        }
    }
}
