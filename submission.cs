using System;
using System.Xml.Schema;
using System.Xml;
using Newtonsoft.Json;
using System.IO;



/**
 * This template file is created for ASU CSE445 Distributed SW Dev Assignment 4.
 * Please do not modify or delete any existing class/variable/method names. However, you can add more variables and functions.
 * Uploading this file directly will not pass the autograder's compilation check, resulting in a grade of 0.
 * **/


namespace ConsoleApp1
{


    public class Program
    {
                                public static string xmlURL = "https://bluemoon012905.github.io/CSE445_assignment_4/Hotels.xml";
                                public static string xmlErrorURL = "https://bluemoon012905.github.io/CSE445_assignment_4/HotelsErrors.xml";
                                public static string xsdURL = "https://bluemoon012905.github.io/CSE445_assignment_4/Hotels.xsd";
                        
                                public static void Main(string[] args)
                                {
                                    string result = Verification(xmlURL, xsdURL);
                                    Console.WriteLine(result);
                        
                        
                                    result = Verification(xmlErrorURL, xsdURL);
                                    Console.WriteLine(result);
                        
                        
                                    result = Xml2Json(xmlURL);
                                    Console.WriteLine(result);
                                }                // Q2.1
                /// <summary>
                /// Verifies an XML file against an XSD schema.
                /// </summary>
                /// <param name="xmlUrl">The URL or local path of the XML file.</param>
                /// <param name="xsdUrl">The URL or local path of the XSD schema file.</param>
                /// <returns>"No Error" if validation is successful, otherwise returns the error message.</returns>
                public static string Verification(string xmlUrl, string xsdUrl)
                {
                    try
                    {
                        XmlReaderSettings settings = new XmlReaderSettings();
                        settings.Schemas.Add(null, xsdUrl);
                        settings.ValidationType = ValidationType.Schema;
                        XmlReader reader = XmlReader.Create(xmlUrl, settings);
                        while (reader.Read()) ;
                        return "No Error";
                    }
                    catch (XmlSchemaValidationException ex)
                    {
                        return ex.Message;
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
        
                /// <summary>
                /// Converts an XML file to a JSON string.
                /// </summary>
                /// <param name="xmlUrl">The URL or local path of the XML file.</param>
                /// <returns>A JSON string representation of the XML file, or an error message if conversion fails.</returns>
                public static string Xml2Json(string xmlUrl)
                {
                    try
                    {
                        string xml = File.ReadAllText(xmlUrl);
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(xml);
                        string jsonText = JsonConvert.SerializeXmlNode(doc);
                        return jsonText;
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
        
                }    }

}
