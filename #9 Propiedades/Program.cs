using _9.Propiedades;

Persona persona1 = new Persona("Armando Salguero", 18, "Jutiapa");

Console.WriteLine("Nombre de la persona 1: " + persona1.Nombre); 
persona1.Nombre = "Brayan Lopez"; 

Console.WriteLine("Edad de la persona 1: " + persona1.Edad); 
persona1.Edad = 25; 

Console.WriteLine("Ciudad de la persona 1: " + persona1.Ciudad); 
persona1.Ciudad = "Atescatempa"; 

persona1.ImprimirInformacion(); 

