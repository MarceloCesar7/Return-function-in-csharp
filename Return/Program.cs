string funcao(int n)
{
    if (n > 0 && n % 2 == 0)
        return "POSITIVO E PAR";
    if (n > 0 && n % 2 == 1)
        return "POSITIVO E IMPAR";
    if (n < 0 && n % 2 == 0)
        return "NEGATIVO E PAR";
    else
        return "NEGATIVO E IMPAR";

}

Console.WriteLine(funcao(-10));

