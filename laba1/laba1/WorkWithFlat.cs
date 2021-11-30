using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace laba1
{
    public static class WorkWithFlat
    {
        private const string pathToFlatsXml = "D:/study/7 сем/РИС/мои лабы/laba1/laba1/Flats.xml";

        public static readonly XDocument xmlDoc = XDocument.Load(pathToFlatsXml);

        public static void removeFlat(Flat flat)
        {
            xmlDoc.Element("Flats").Elements("Flat").Where(c => c.Element("Code").Value == flat.Code).Remove();
            xmlDoc.Save(pathToFlatsXml);
        }

        public static List<Flat> getFlatList()
        {
            var flats = new List<Flat>();

            var flatsListFromXml = xmlDoc.Element("Flats").Elements("Flat").Where(c => c.Attribute("isBooked").Value != "true").ToList();

            foreach (var flat in flatsListFromXml)
            {
                flats.Add(new Flat
                {
                    Code = flat.Element("Code").Value,
                    Name = flat.Element("Name").Value,
                    Region = flat.Element("Region").Value,
                    NumberRooms = int.Parse(flat.Element("NumberRooms").Value),
                    Price = flat.Element("Price").Value,
                    CountViews = int.Parse(flat.Element("CountViews").Value),
                });
            }

            return flats;
        }

        public static void AddFlat(Flat flat)
        {
            xmlDoc.Element("Flats").Add(new XElement("Flat",
                new XAttribute("isBooked", "false"),
                new XElement("Code", flat.Code),
                new XElement("Name", flat.Name),
                new XElement("Region", flat.Region),
                new XElement("NumberRooms", flat.NumberRooms),
                new XElement("Price", flat.Price),
                new XElement("CountViews", "0")));

            xmlDoc.Save(pathToFlatsXml);
        }

        public static List<Flat> sortByRegion()
        {
            var flats = getFlatList();

            return flats.OrderBy(c => c.Region).ToList();
        }

        public static List<Flat> sortByRooms()
        {
            var flats = getFlatList();

            return flats.OrderBy(c => c.NumberRooms).ToList();
        }

        public static List<Flat> sortByViews()
        {
            var flats = getFlatList();

            return flats.OrderByDescending(c => c.CountViews).ToList();
        }

        public static void countViewsAdd(Flat flat)
        {
            foreach (XElement xe in xmlDoc.Element("Flats").Elements("Flat").ToList())
            {
                if (xe.Element("Name").Value == flat.Name)
                {
                    var val = int.Parse(xe.Element("CountViews").Value);
                    xe.Element("CountViews").Value = (++val).ToString();
                }
            }
            xmlDoc.Save(pathToFlatsXml);
        }
    }
}
