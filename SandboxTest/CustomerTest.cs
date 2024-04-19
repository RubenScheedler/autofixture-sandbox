using AutoFixture;
using AutofixtureSandbox;
using FluentAssertions;

namespace SandboxTest;

public class CustomerTest
{
    private readonly Fixture _fixture = new();

    [Fact]
    public void constructor_initializesName()
    {
        // Act
        Customer customer = new Customer(
            "John", 
            _fixture.Create<DateTime>(), 
            _fixture.CreateMany<Email>().ToList(), 
            _fixture.Create<Address>(), 
            _fixture.Create<String>()
        );
        
        // Assert
        customer.Name.Should().Be("John");
    }
}