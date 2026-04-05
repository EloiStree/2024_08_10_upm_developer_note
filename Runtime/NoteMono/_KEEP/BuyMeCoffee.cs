namespace Eloi.Note
{
    public class BuyMeCoffee : LinkNoteMono
    {
        private void Reset()
        {
            m_link = new NoteLink.NamedLink("Buy me a coffee", "https://buymeacoffee.com/USERNAME");
        }

    }
    
}