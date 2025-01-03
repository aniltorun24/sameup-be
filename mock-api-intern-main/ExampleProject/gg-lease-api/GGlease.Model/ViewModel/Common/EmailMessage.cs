namespace GGlease.Model.ViewModel
{
    public record EmailMessage(IEnumerable<EmailAddress> To, string Subject, string Body);
}
