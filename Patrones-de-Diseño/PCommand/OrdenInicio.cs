using Clases.Aulas;

namespace PCommand
{
    public class OrdenInicio : OrdenEnAula1
    {
        private Aula _aula;
        public OrdenInicio(Aula aula)
        {
            _aula = aula;
        }

        public void Ejecutar()
        {
            this._aula.Comenzar();
        }
    }
}