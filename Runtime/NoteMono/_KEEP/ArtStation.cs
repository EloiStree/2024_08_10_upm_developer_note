namespace Eloi.Note
{
    public class ArtStation : LinkNoteMono
    {
        public ArtStation()
        {
        }

        private void Reset()
        {
            m_link = new NoteLink.NamedLink("Art Station", "https://www.artstation.com/USERNAME");
        }

    }

}