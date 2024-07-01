using TODO.Domain.Services;

namespace TODO.Application
{
    public class Class1
    {
        private readonly IEmailService emailService;

        public Class1(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void AddTODO() {

            ///....
            emailService.SendEmail("fabian@gmail.com");
        }
    }
}
