
using System.Xml.Serialization;

namespace Hangman
{
    public class User
    {
        public string name { get; set; }
        public int score { get; set; }


        public void serializer(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>)); // Creating XmlSerializer object for User

            List<User> userList;


            try
            {
                using (TextReader reader = new StreamReader(path)) // Reading records file
                {
                    userList = (List<User>)serializer.Deserialize(reader);
                }
            }
            catch (FileNotFoundException) // In this case files does not exist, so I create new List
            {

                userList = new List<User>();
            }


            for (int i = 0; i < userList.Count(); i++)
            {
                // In this case, current user has record but he/she did not break it this time,so no adding.
                if (userList[i].name == name && userList[i].score >= score)
                {
                    break;
                }

                // Checking if current user has history in this game, if yes, then updating accordingly
                if (userList[i].name == name && userList[i].score < score)
                {
                    userList.Remove(userList[i]);
                    userList.Add(this);
                    break;
                }

                // In this case, current user is new in records and I add him/her
                if (i == userList.Count() - 1)
                {
                    userList.Add(this);
                    break;
                }
            }

            // in this case, there are no records and current user is the first one.
            if (userList.Count() == 0)
            {
                userList.Add(this);
            }

            // sorting a list
            userList = (from item in userList
                        orderby item.score descending
                        select item).ThenBy(item => item.name).ToList();

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, userList);
            }
        }

        public override string ToString()
        {
            return $"Name: {name} | Score: {score}";
        }
    }
}
