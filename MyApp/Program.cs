// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese el numero a invertir ");
string numero = Console.ReadLine();
int aux = Convert.ToInt32(numero);

int numeroInvertido = 0;

while (aux > 0){
    numeroInvertido = numeroInvertido*10 + aux%10;
    aux /= 10;   
}

Console.WriteLine("El numero invertido es "+ numeroInvertido);