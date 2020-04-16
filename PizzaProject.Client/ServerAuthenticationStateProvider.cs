using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazingPizza.Client
{
    public class ServerAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var claim = new Claim(ClaimTypes.Name, "Fake user");
            var identity = new ClaimsIdentity(new[] { claim }, "serverauth");
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
    }
}