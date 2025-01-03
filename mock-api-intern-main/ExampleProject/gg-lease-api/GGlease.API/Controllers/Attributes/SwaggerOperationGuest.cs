using Swashbuckle.AspNetCore.Annotations;

namespace GGlease.API.Controllers
{
    public class SwaggerOperationGuestAttribute : SwaggerOperationAttribute
    {
        public SwaggerOperationGuestAttribute(bool captcha = false) : base(null, "Guest" + (false ? " + Captcha" : ""))
        {
        }
    }
}
