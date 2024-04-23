/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

public class Veiculo {
    public string Placa { get; set; }
    public int Ano { get; set; }

    public Veiculo(string placa, int ano) {
        Placa = placa;
        Ano = ano;
    }

    public int CalcularIdade() {
        return DateTime.Now.Year - Ano;
    }
}

class AnalisarVeiculo {
    public static void Main(string[] args) {
        Veiculo _v;
        _v = new Veiculo("yhaoo", 2000);
        Console.WriteLine(_v.CalcularIdade());
    }
}
