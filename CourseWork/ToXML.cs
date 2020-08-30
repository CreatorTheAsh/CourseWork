using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace Course_work
{
	class XMLLogWriter
	{
		//Errors
		private XMLLogWriter() { }
		public static void XMLCreateRoot()
        {
			if (!(File.Exists(@"C:\Users\Aleksandr\Desktop\Logs\Logs.xml") && File.Exists(@"C:\Users\Aleksandr\Desktop\Logs\Errors.xml")))
			{
				XDocument xdocLog = new XDocument();
				XElement RootLog = new XElement("root");
				xdocLog.Add(RootLog);
				xdocLog.Save(@"C:\Users\Aleksandr\Desktop\Logs\Logs.xml");
				XDocument xdocErr = new XDocument();
				XElement RootErr = new XElement("root");
				xdocErr.Add(RootErr);
				xdocErr.Save(@"C:\Users\Aleksandr\Desktop\Logs\Errors.xml");
			}

		}
		public static void XMLWriteLog(string elType, List<string> atrsEventName)
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load(@"C:\Users\Aleksandr\Desktop\Logs\Logs.xml");
			elType = elType.Replace(' ', '_');
			XmlElement currentElement = xDoc.CreateElement(elType);
			foreach (string atr in atrsEventName)
            {
				//string temp  = String.Concat(atr.Where(c => !Char.IsWhiteSpace(c)));
				string temp = atr.Replace(' ', '_');
				temp = temp.Replace(':', '-');
				string[] atrParts = temp.Split("=");
				XmlAttribute xmlAttribute = xDoc.CreateAttribute(atrParts[0]);
				XmlText xmlText = xDoc.CreateTextNode(atrParts[1]);
				xmlAttribute.AppendChild(xmlText);
				currentElement.Attributes.Append(xmlAttribute);
			}
			XmlElement xRoot = xDoc.DocumentElement;
			xRoot.AppendChild(currentElement);
			xDoc.Save(@"C:\Users\Aleksandr\Desktop\Logs\Logs.xml");
		}
		public static void XMLWriteError(string elType, List<string> atrsEventName)
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load(@"C:\Users\Aleksandr\Desktop\Logs\Errors.xml");
			elType = elType.Replace(' ', '_');
			XmlElement currentElement = xDoc.CreateElement(elType);
			foreach (string atr in atrsEventName)
			{
				//string temp = String.Concat(atr.Where(c => !Char.IsWhiteSpace(c)));
				string temp = atr.Replace(' ', '_');
				temp = temp.Replace(':', '-');
				string[] atrParts = temp.Split("=");
				XmlAttribute xmlAttribute = xDoc.CreateAttribute(atrParts[0]);
				XmlText xmlText = xDoc.CreateTextNode(atrParts[1]);
				xmlAttribute.AppendChild(xmlText);
				currentElement.Attributes.Append(xmlAttribute);
			}
			XmlElement xRoot = xDoc.DocumentElement;
			xRoot.AppendChild(currentElement);
			xDoc.Save(@"C:\Users\Aleksandr\Desktop\Logs\Errors.xml");
		}
	}
}
