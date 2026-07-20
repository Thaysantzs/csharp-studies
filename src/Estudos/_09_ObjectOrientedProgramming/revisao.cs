using System;
namespace OurCompany.LearnCoding.OOP;


public class RevisaoApp
{
    public static void Main(string[] args)
    {
        Veiculo carro = new Veiculo();

        carro[4] = 200;
        Console.WriteLine($"Velocidade: {carro[4]}");
    }
}


public class Veiculo
{
    private int[] Velmax = new int[5]{80, 100, 120, 140, 160};

    public int this[int i]
    {
        get
        {
            return Velmax[i];
        }

        set
        {
            if(value < 0)
            {
                Velmax[i] = 0;
            }else if(value > 300)
            {
                Velmax[i] = 300;
            }
            else
            {
                Velmax[i] = value;
            }
        }
    }

    public Veiculo()
    {
        
    }
}