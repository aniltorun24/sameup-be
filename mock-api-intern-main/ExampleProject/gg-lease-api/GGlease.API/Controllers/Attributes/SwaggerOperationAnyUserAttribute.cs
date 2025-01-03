using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers
{
    public class SwaggerOperationAnyUserAttribute : SwaggerOperationAttribute
    {
        public SwaggerOperationAnyUserAttribute() : base(null, "Any authenticated user")
        {
        }
    }
}
