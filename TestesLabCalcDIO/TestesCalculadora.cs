using LabCalcDIO;

namespace TestesLabCalcDIO
{
    public class TestesCalculadora

    {
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculado = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(12, 2, 10)]
        [InlineData(51, 11, 40)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculado = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(7, 7, 49)]
        [InlineData(4, 3, 12)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculado = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Theory]
        [InlineData(36, 2, 18)]
        [InlineData(9, 3, 3)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new();

            int resultadoCalculado = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculado);
        }

        [Fact]
        public void TestarDividirPorZero()
        {
            Calculadora calc = new();

            Assert.Throws<DivideByZeroException>
                (
                    () => calc.Dividir(32, 0)
                );
        }

        [Fact]
        public void TestarHistorico()
        { 
            Calculadora calc = new();

            calc.Somar(8, 2);
            calc.Subtrair(7, 5);
            calc.Multiplicar(6, 7);
            calc.Dividir(81, 9);


            var lista = calc.Historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}