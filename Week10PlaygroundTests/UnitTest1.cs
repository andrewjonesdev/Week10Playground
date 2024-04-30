using AutoFixture;
using AutoFixture.NUnit3;
using Bogus;

using Moq;
using Week10Playground;

namespace Week10PlaygroundTests
{
    [TestFixture]
    [Category("Unit Tests")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [AutoData]
        public void Test1(IFixture fixture)
        {
            var faker = new Faker();
            // faker
            //Mock ExtendedFightLogicMethod
            PirateCrew crew1 = new PirateCrew(faker.Random.Word(), faker.Random.Number(), new List<Pirate>());
            PirateCrew crew2 = new PirateCrew(faker.Random.Word(), faker.Random.Number(), new List<Pirate>());
            Pirate pirate1 = new Pirate(faker.Random.Word(), crew1, [Haki.Armament, Haki.Conquerers, Haki.Observation], new Tuple<string, string>("Gomu Gomu No Mi", "Paramecia"), faker.Random.Number());
            crew1.Members.Add(pirate1);
            Pirate pirate2 = new Pirate(faker.Random.Word(), crew2, [Haki.Armament, Haki.Conquerers, Haki.Observation], new Tuple<string, string>("Gomu Gomu No Mi", "Paramecia"), faker.Random.Number());
            crew2.Members.Add(pirate2);
            while (pirate1.Bounty <=  pirate2.Bounty) 
            {
                pirate1.Bounty = faker.Random.Number();
            }
            var result = pirate1.FightPirate(pirate2);
            Assert.That(($"{pirate1.Name} Defeated {pirate2.Name} !"), Is.EqualTo(result));
        }
    }
}