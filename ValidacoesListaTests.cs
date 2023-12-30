using TestesUnitarios.Desafio.Console.Services;
namespace TestesUnitarios.Desafio.Tests;


public static class ValidacoesLista
{
    public static List<int> RemoverNumerosNegativos(List<int> numeros)
    {
        return numeros.Where(num => num >= 0).ToList();
    }

    public static bool ListaContemDeterminadoNumero(List<int> numeros, int numero)
    {
        return numeros.Contains(numero);
    }

    public static List<int> MultiplicarNumerosLista(List<int> numeros, int multiplicador)
    {
        return numeros.Select(num => num * multiplicador).ToList();
    }

    public static int RetornarMaiorNumeroLista(List<int> numeros)
    {
        return numeros.Max();
    }

    public static int RetornarMenorNumeroLista(List<int> numeros)
    {
        return numeros.Min();
    }
}

public static class ValidacoesString
{
    public static int RetornarQuantidadeCaracteres(string texto)
    {
        return texto.Length;
    }

    public static bool ContemCaractere(string texto, string trecho)
    {
        return texto.Contains(trecho);
    }

    public static bool TextoTerminaCom(string texto, string trecho)
    {
        return texto.EndsWith(trecho);
    }
}

// Projeto do tipo teste, suas classes e métodos

public class ValidacoesListaTests
{
    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 1, -2, 3, -4, 5 };

        // Act
        var resultado = ValidacoesLista.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(new List<int> { 1, 3, 5 }, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 1, 2, 3, 9, 5 };

        // Act
        var resultado = ValidacoesLista.ListaContemDeterminadoNumero(lista, 9);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var lista = new List<int> { 1, 2, 3, 9, 5 };

        // Act
        var resultado = ValidacoesLista.ListaContemDeterminadoNumero(lista, 10);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        var lista = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        var resultado = ValidacoesLista.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 1, 2, 3, 9, 5 };

        // Act
        var resultado = ValidacoesLista.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 1, 2, 3, -8, 5 };

        // Act
        var resultado = ValidacoesLista.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(-8, resultado);
    }
}

public class ValidacoesStringTests
{
    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange
        var texto = "Matrix";

        // Act
        var resultado = ValidacoesString.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";

        // Act
        var resultado = ValidacoesString.ContemCaractere(texto, "qualquer");

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";

        // Act
        var resultado = ValidacoesString.ContemCaractere(texto, "teste");

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "Começo, meio e fim do texto procurado";

        // Act
        var resultado = ValidacoesString.TextoTerminaCom(texto, "procurado");

        // Assert
        Assert.True(resultado);
    }
}
