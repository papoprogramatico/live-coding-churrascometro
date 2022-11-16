namespace churrascometro
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaCarne, totalCarne, precoCarne, precoTotal, valorPorPessoa;

            int qtdePessoas;

            Console.WriteLine("Insira a quantidade de carne que uma pessoa consome em média.");
            mediaCarne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de pessoas.");
            qtdePessoas = Convert.ToInt32(Console.ReadLine());

            if (qtdePessoas <= 0){
                Console.WriteLine("Insira a quantidade de carne que uma pessoa consome em média.\n");

                qtdePessoas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o valor do kg da carne.\n");

                precoCarne = Convert.ToDouble(Console.ReadLine());

                totalCarne = mediaCarne * qtdePessoas;
                precoTotal = totalCarne * precoCarne;
                valorPorPessoa = precoTotal / qtdePessoas;

                Console.WriteLine("A quantidade de carne necessaria será de " + totalCarne + "kgs" +"\n");

                Console.WriteLine("O valor total será de R$" + precoTotal + " reais" + "\n");

                Console.WriteLine("O valor por pessoa será de R$" + valorPorPessoa.ToString("F") + " reais");
            } else {
                Console.WriteLine("Digite o valor do kg da carne.\n");

                precoCarne = Convert.ToDouble(Console.ReadLine());

                totalCarne = mediaCarne * qtdePessoas;
                precoTotal = totalCarne * precoCarne;
                valorPorPessoa = precoTotal / qtdePessoas;

                
                Console.WriteLine(mediaCarne);
                Console.WriteLine(qtdePessoas);
                Console.WriteLine(precoCarne);
                Console.WriteLine(totalCarne);
                Console.WriteLine(precoTotal);
                Console.WriteLine(valorPorPessoa);

                Console.WriteLine("A quantidade de carne necessaria será de " + totalCarne + "kgs" +"\n");

                Console.WriteLine("O valor total será de R$" + precoTotal + " reais" + "\n");

                Console.WriteLine("O valor por pessoa será de R$" + valorPorPessoa.ToString("F") + " reais");
            
        }
    }
}

