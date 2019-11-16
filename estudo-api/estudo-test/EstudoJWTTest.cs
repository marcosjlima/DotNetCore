using Bogus;
using FluentAssertions;
using System;
using Xunit;
using estudo_jwt;

namespace estudo_test
{
    public class EstudoJWTTest
    {
        /*
        Dados Fake com Bogus
            var pessoas = new Faker<Pessoa>("pt_BR")
                .RuleFor(c => c.Id, f => f.Random.Guid())
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                .RuleFor(c => c.DataNascimento, f => f.Date.Past(15))
                .Generate(3);
         */
        estudo_jwt.EstudoJWT jwt;

        public EstudoJWTTest()
        {
           jwt = new estudo_jwt.EstudoJWT();
        }

        [Theory]
        [InlineData("marcos.lima")]
        [InlineData("jessica")]
        public void CreateTokenTest(string userName)
        {
            Assert.NotEmpty(jwt.CreateToken(userName));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        public void CreateTokenTestFailed(string userName)
        {
            Assert.Empty(jwt.CreateToken(userName));
        }

        [Theory]
        [InlineData("user")]
        [InlineData("fulano")]
        public void CreateTokenTestOK(string userName)
        {
            jwt.CreateToken(userName).Should().NotBeNullOrEmpty();
        }
    }
}
