//Desenvolva um jogo de adivinhação onde o programa gera um número aleatório entre 1 e 100, e o usuário tenta adivinhar. Use um laço while para continuar pedindo palpites até que o usuário acerte.
Random random = new Random();

int num_aleatorio = random.Next(0,100);
int numero = 0;
int contador = 0;

Console.WriteLine("Bem-vindo ao jogo da advinhação, onde o objetivo é acertar um número entre 0 e 100!!!\n");

while (true)
{
Console.WriteLine("Digite o seu palpite: ");
numero = Convert.ToInt32(Console.ReadLine());
    
        if (numero > num_aleatorio){
            Console.WriteLine("O número da sorteado é MENOR que o que voce escolheu!");
            contador++;

        } else if (numero < num_aleatorio) {
            Console.WriteLine("O número da sorteado é MAIOR que o que voce escolheu!");
             contador++;
        } else {
            Console.WriteLine($"Parabéns, voce acertou o numero sorteado em {contador} tentavia(as)");
            break;
        }
}
Console.WriteLine("Muito obrigado por jogar!!!");
