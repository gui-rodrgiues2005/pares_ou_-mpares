float numeros;

while(true){ 

Console.Write("...........Pares ou Ímpares ?.........\n\n\n");
Console.Write("Digite qualquer número:");
numeros = int.Parse(Console.ReadLine());

if(numeros % 2 == 0) {
    Console.Write("Este número é PAR\n\n"); 
} else {
    Console.Write("Este número é IMPAR\n\n");
}



Console.Write("Digite 'Sair' para ecerrar ou 'Enter' para continuar:");
string opcao = Console.ReadLine();
if(opcao.ToLower() == "Sair")
{
    break;    
}
}