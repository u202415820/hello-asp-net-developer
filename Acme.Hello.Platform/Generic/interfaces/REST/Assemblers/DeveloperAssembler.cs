using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.interfaces.REST.Assemblers;
/// <summary>
/// Assembler class to convert a GreetDeveloperRequest into a Developer entity.
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a GreetDeveloperRequest into a Developer entity.
    /// </summary>
    /// <param name="request">The GreetDeveloperRequest to convert</param>
    /// <returns>A Developer entity if the request is valid</returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request is null 
            || string.IsNullOrWhiteSpace(request.FirstName) 
            || string.IsNullOrWhiteSpace(request.LastName))
            return null;
        return new Developer(request.FirstName, request.LastName);
    }
}