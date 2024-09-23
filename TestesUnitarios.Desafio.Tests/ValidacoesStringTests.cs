namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Corrigindo as variáveis "texto" e "resultadoEsperado"

        // Arrange
        var texto = "Matrix"; // Texto correto para o teste
        var resultadoEsperado = 6; // Quantidade de caracteres correta

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Corrigindo a chamada do método para "ContemPalavra"
        // Act
        var resultado = _validacoes.ContemPalavra(texto, textoProcurado);

        // Corrigindo o Assert.True com base no retorno do método
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemPalavra(texto, textoProcurado);

        // Corrigindo o Assert.False com base no retorno do método
        Assert.False(resultado);
    }

    [Fact] // Corrigindo a anotação [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Corrigindo a variável "textoProcurado" na seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado"; // Palavra correta

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}

