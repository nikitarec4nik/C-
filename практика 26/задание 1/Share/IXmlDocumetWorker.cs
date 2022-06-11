
using задание_1.InterFaces;
using задание_1.models;
using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.Extensions.Logging;

namespace задание_1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;
        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }

        public void Add(Market tovar)
        {
            var xRoot = _document.DocumentElement;
            XmlElement nametElem = _document.CreateElement("NameT");

            XmlAttribute exdateAttributes = _document.CreateAttribute("ExDate");
            XmlText exdateText = _document.CreateTextNode(tovar.NameT);
            exdateAttributes.AppendChild(exdateText);

            XmlElement exdateElem = _document.CreateElement("year");
            XmlText yearInnerText = _document.CreateTextNode(tovar.ExDate.ToString());
            exdateElem.AppendChild(exdateElem);
            nametElem.AppendChild(exdateElem);

            XmlElement costElem = _document.CreateElement("RentDays");
            XmlText exdateInnerText = _document.CreateTextNode(tovar.Cost.ToString());
            costElem.AppendChild(exdateInnerText);
            nametElem.AppendChild(costElem);

            xRoot.AppendChild(nametElem);
            _document.Save(_xmlFilePath);
        }

        public void Delete(string tovar)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributenamet = xNode.Attributes.GetNamedItem("mark");
                    try
                    {
                        var attributenametText = attributenamet?.InnerText;
                        if (attributenametText.Equals(tovar))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributenamet));
                    }

                }
            }
        }
        public Market FindBy(string tovar)
        {
            Market market = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xmlNode in xRoot)
            {
                market = GetParking(xmlNode);
                if (market.NameT.Equals(tovar))
                {
                    return market;
                }
            }
            return market;
        }

        public List<Market> GetAll()
        {
            List<Market> markett = new List<Market>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                var market = GetParking(node);
                markett.Add(market);
            }
            return markett;
        }

        public void Load(string xmlDocPath)
        {
            _xmlFilePath = xmlDocPath;
            _document.Load(xmlDocPath);
        }
        private Market GetParking(XmlNode node)
        {
            var market = new Market();
            if (node.Attributes.Count > 0)
            {
                var attributenamet = node.Attributes.GetNamedItem("NameT");
                market.NameT = attributenamet?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("ExDate"))
                    {
                        market.ExDate = (childNode.InnerText);
                    }
                    if (childNode.Name.Equals("Cost"))
                    {
                        market.Cost = int.Parse(childNode.InnerText);
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return market;
        }
    }
}
