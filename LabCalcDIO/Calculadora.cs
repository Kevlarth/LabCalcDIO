using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalcDIO
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = [];
        }

        public int Somar(int val1, int val2)
        {
            _historico.Insert(0, $"Resltado Soma: {val1 + val2}");
            return val1 + val2;
        }

        public int Subtrair(int val1, int val2)
        {
            _historico.Insert(0, $"Resltado Subtração: {val1 - val2}");
            return val1 - val2;
        }

        public int Multiplicar(int val1, int val2)
        {
            _historico.Insert(0, $"Resltado Multiplicação: {val1 * val2}");
            return val1 * val2;
        }

        public int Dividir(int val1, int val2)
        {
            _historico.Insert(0, $"Resltado Divisão: {val1 / val2}");
            return val1 / val2;
        }

        public List<string> Historico()
        {
            int capacidadeHistorico = 3;
            _historico.RemoveRange(capacidadeHistorico, _historico.Count - capacidadeHistorico);
            return _historico;
        }
    }
}
