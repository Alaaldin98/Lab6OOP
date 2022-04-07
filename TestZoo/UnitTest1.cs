using System;
using Xunit;
using Zoo;

namespace TestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreatePolarBearWithIHuntInterface()
        {
            PolarBear Branson = new PolarBear("Branson the Polar Bear", "Male");
            Assert.False(Branson.CatchPrey());
        }

        [Fact]
        public void TestBarnOwlHasIFlyInterface()
        {
            BarnOwl Otah = new BarnOwl("Otah the Barn Owl", "Female");
        }

        [Fact]
        public void TestCanCreateTigerWithInheritanceAndInterface()
        {
            //Arrange
            //Act
            Tiger Tiaga = new Tiger("Tiaga the Tiger", "Female");
            //Assert
            Assert.Contains("Carnivore", Tiaga.Prey);
        }

        [Fact]
        public void TestIHuntCatchPreyCorrectlyOverwritten()
        {
            BaldEagle Glory = new BaldEagle("Glory the Bald Eagle", "Female");
            Assert.False(Glory.CatchPrey());
        }

        [Fact]
        public void TestBoaConstrictorIsAnimal()
        {
            BoaConstrictor Balthazar = new BoaConstrictor("Balthazar the Boa Constrictor", "Male");
            Assert.True(Balthazar is Animal);
        }
    }
}
