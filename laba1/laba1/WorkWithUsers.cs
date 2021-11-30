using System.IO;
using System.Xml.Serialization;

namespace laba1
{
    public static class WorkWithUsers
    {
        private static string path = "D:/study/7 сем/РИС/мои лабы/laba1/laba1/Users.xml";

        public static Users ReadXml()
        {

            var ser = new XmlSerializer(typeof(Users));
            Users users;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                users = (Users)ser.Deserialize(fs);
            }
            return users;
        }

        public static void WriteToXml(User user)
        {
            Users users = ReadXml();
            users.User.Add(user);
            XmlSerializer writer = new XmlSerializer(typeof(Users));

            FileStream file = File.OpenWrite(path);

            writer.Serialize(file, users);
            file.Close();
        }

        public static void saveFlatToTxt(Flat flat, string userName)
        {
            string path = ("D:/study/7 сем/РИС/мои лабы/laba1/laba1/savedFlats_" + userName + ".txt");
            using (StreamWriter w = File.AppendText(path))
            {
                w.WriteLine("Квартира: " + flat.Name + " Рерион: " + flat.Region + " Количество комнат: " + flat.NumberRooms + " Цена: " + flat.Price);
            }

            WorkWithFlat.countViewsAdd(flat);

            Menu.user(userName);
        }
    }
}
