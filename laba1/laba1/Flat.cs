using System.Collections.Generic;
using System.Xml.Serialization;

namespace laba1
{
    [XmlRoot(ElementName = "Flat")]
    public class Flat
    {
        [XmlElement(ElementName = "Code")]
        private string _code;
        public string Code
        {
            get => _code;
            set => _code = value;
        }

        [XmlElement(ElementName = "Name")]
        public string _name;
        public string Name { get => _name; set => _name = value; }

        [XmlElement(ElementName = "Region")]
        private string _region;
        public string Region { get => _region; set => _region = value; }

        [XmlElement(ElementName = "NumberRooms")]
        private int _numberRooms;
        public int NumberRooms { get => _numberRooms; set => _numberRooms = value; }

        [XmlElement(ElementName = "CountViews")]
        private int _countViews;
        public int CountViews { get => _countViews; set => _countViews = value; }

        [XmlElement(ElementName = "Price")]
        private string _price;
        public string Price { get => _price; set => _price = value; }

        [XmlAttribute(AttributeName = "isBooked")]
        private string _isBooked;
        public string IsBooked { get => _isBooked; set => _isBooked = value; }
    }

    [XmlRoot(ElementName = "Flats")]
    public class Flats
    {
        [XmlElement(ElementName = "Flat")]
        public List<Flat> Flat { get; set; }
    }
}
