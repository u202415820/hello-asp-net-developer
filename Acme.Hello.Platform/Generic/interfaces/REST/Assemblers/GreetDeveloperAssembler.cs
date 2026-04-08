using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.interfaces.REST.Assemblers;

/// <summary>
/// Assembler class to convert a Developer entity into a GreetDeveloperResponse
/// </summary>
public class GreetDeveloperAssembler
{
    /// <summary>
    /// Converts a Developer entity into a GreetDeveloperResponse.
    /// Returns an anonymous greeting if the developer is null or has empty names.
    /// </summary>
    /// <param name="entity">The Developer entity to convert</param>
    /// <returns>A GreetDeveloperResponse containing the greeting message</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if(entity is null || entity.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET developer!");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(), $"Congrats {entity.GetFullName()}! You are an ASP.NET Developer!");
    }

}