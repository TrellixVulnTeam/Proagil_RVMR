namespace ProAgil.Dominio
{
    public class PalestranteEvento
    {
        public int PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }

           public int EventoId { get; set; }

        public Evento Eventos { get; }
    }
}