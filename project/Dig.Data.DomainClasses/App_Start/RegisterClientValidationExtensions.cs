using DataAnnotationsExtensions.ClientValidation;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Dig.Data.DomainClasses.App_Start.RegisterClientValidationExtensions), "Start")]
 
namespace Dig.Data.DomainClasses.App_Start {
    public static class RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();            
        }
    }
}