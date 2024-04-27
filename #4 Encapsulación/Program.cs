using System;

class CuentaBancaria
{
    
    private string nombreTitular;
    private string numeroCuenta;
    private double saldo;

    public CuentaBancaria(string nombreTitular, string numeroCuenta)
    {
        this.nombreTitular = nombreTitular;
        this.numeroCuenta = numeroCuenta;
        this.saldo = 0; 
    }

    public string ObtenerNombreTitular()
    {
        return nombreTitular;
    }
 
    public string ObtenerNumeroCuenta()
    {
        return numeroCuenta;
    }

    public double ObtenerSaldo()
    {
        return saldo;
    }
 
    public void Depositar(double monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine("Se han depositado {0:C2} en la cuenta {1}", monto, numeroCuenta);
        }
        else
        {
            Console.WriteLine("Error: El monto a depositar debe ser mayor a 0");
        }
    }

    public void Retirar(double monto)
    {
        if (monto > 0 && saldo >= monto)
        {
            saldo -= monto;
            Console.WriteLine("Se han retirado {0:C2} de la cuenta {1}", monto, numeroCuenta);
        }
        else
        {
            Console.WriteLine("Error: El monto a retirar es mayor al saldo disponible");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        CuentaBancaria cuenta1 = new CuentaBancaria("Juan Pérez", "20242025");

        cuenta1.Depositar(1000);

        
        Console.WriteLine("Saldo actual: {0:C2}", cuenta1.ObtenerSaldo());

        
        cuenta1.Retirar(500);

        
        Console.WriteLine("Saldo final: {0:C2}", cuenta1.ObtenerSaldo());
    }
}

