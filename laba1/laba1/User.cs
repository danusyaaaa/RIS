using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace laba1
{
    [Serializable]
    [XmlRoot(ElementName = "user")]
    public class User
    {
        [XmlElement(ElementName = "login")]
        public string Login { get; set; }
        [XmlElement(ElementName = "password")]
        public string Password { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
    }

    [Serializable]
    [XmlRoot(ElementName = "users")]
    public class Users
    {
        [XmlElement(ElementName = "user")]
        public List<User> User { get; set; }
    }
}
