namespace AppMvcBasica.Models
{
    public abstract class Entidade
    {
        protected Entidade()
        {
            id = Guid.NewGuid();
        }

        public Guid id { get; set; }
    }
}
