using Flyweight;


namespace FlyweightPatternExample
{
   
    class Program
    {
        private static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();
            var Hero = factory.GetCharacter("Turnish", Types.Warrior, "\\\\iscsi\\profstud\\LesnikovAA\\Downloads\\images (2).jpg");
            Hero.Experience = 20;
            Hero.Level = 30;
            
            var Hero1 = factory.GetCharacter("Gendalf", Types.Healer, "\\\\iscsi\\profstud\\LesnikovAA\\Downloads\\images (3).jpg");
            Hero1.Level = 100;
            Hero1.Experience = 10;

            
            var Hero2 = factory.GetCharacter("Hitman", Types.Mag, "\\\\iscsi\\profstud\\LesnikovAA\\Downloads\\images (4).jpg");
            Hero2.Level = 1;
            Hero2.Experience = 1;

            var Hero3 = factory.GetCharacter("Gendalf", Types.Mag, "\\\\iscsi\\profstud\\LesnikovAA\\Downloads\\images (3).jpg");

            var Hero4 = factory.GetCharacter("Hitman", Types.Mag, "\\\\iscsi\\profstud\\LesnikovAA\\Downloads\\images (3).jpg");
            Hero4.Level = 50;
            Hero4.Experience = 100;


            Hero.Display();
            Hero1.Display();
            Hero2.Display();
            Hero3.Display();

            Console.WriteLine(ReferenceEquals(Hero1, Hero3));
            Console.WriteLine(ReferenceEquals(Hero2, Hero4));
        }
    }
}