using _2.Herencia;

Empleado empleadoGenerico = new Empleado("Armando Salguero", 3200); 
Gerente gerente = new Gerente("Julian Barrera", 3000, 500); 
Vendedor vendedor = new Vendedor("Melanie Reyes", 1500, 1000); 

Console.WriteLine($"Nombre del empleado: {empleadoGenerico.Nombre}");
Console.WriteLine($"Salario neto del empleado: {empleadoGenerico.CalcularSalarioNeto()}");

Console.WriteLine($"Nombre del gerente: {gerente.Nombre}");
Console.WriteLine($"Salario neto del gerente: {gerente.CalcularSalarioNeto()}");

Console.WriteLine($"Nombre del vendedor: {vendedor.Nombre}");
Console.WriteLine($"Salario neto del vendedor: {vendedor.CalcularSalarioNeto()}");
