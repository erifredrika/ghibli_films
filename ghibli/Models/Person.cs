namespace ghibli.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Eye_Color { get; set; }
        public string Hair_Color { get; set; }
        public string[] Films { get; set; }
    }

    public static class PersonExtensions
    {
        public static PersonInfo ToPersonInfo(this Person person)
        {
            if (int.TryParse(person.Age, out int age))
            {

            }
            return new PersonInfo
            {
                Age = age,
                Name = person.Name,
                EyeColor = person.Eye_Color,
                Gender = person.Gender,
                HairColor = person.Hair_Color,
                FilmId = person.Films[0].Replace("https://ghibliapi.herokuapp.com/films/", "")
            };
        }
    }
}
