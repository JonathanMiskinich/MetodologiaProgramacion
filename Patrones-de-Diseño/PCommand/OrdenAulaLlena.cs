using Clases.Aulas;

namespace PCommand
{
    public class OrdenAulaLlena : OrdenEnAula1
    {
        private Aula _aula;
        public OrdenAulaLlena(Aula aula)
        {
            _aula = aula;
        }
        public void Ejecutar()
        {
            this._aula.ClaseLista();
        }
    }
}