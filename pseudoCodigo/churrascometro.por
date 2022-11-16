programa
{
	
	
	funcao inicio()
	{
		real mediaCarne, totalCarne, precoCarne, precoTotal, valorPorPessoa
		inteiro qtdePessoas
		escreva("Insira a quantidade de carne que uma pessoa consome em média.\n") 
		leia(mediaCarne)
		escreva("Insira a quantidade de pessoas.\n")
		leia(qtdePessoas)
		escreva("Digite o valor do kg da carne.\n")
		leia(precoCarne)
		totalCarne = mediaCarne * qtdePessoas
		precoTotal = totalCarne * precoCarne
		valorPorPessoa = precoTotal / qtdePessoas
		escreva("A quantidade de carne necessaria será de " + totalCarne + "kgs" +"\n")	
		escreva("O valor total será de R$" + precoTotal + " reais" + "\n")		
		escreva("O valor por pessoa será de R$" + valorPorPessoa + " reais")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 708; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {mediaCarne, 7, 7, 10};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */