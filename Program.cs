Console.WriteLine("Msotre o Seu mg/Dl");

string  sla2 = Console.ReadLine()!;
int valor = Convert.ToInt32(sla2);

if(valor < 92){
    Console.WriteLine("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}
else if(valor >-92 && valor < 126){
    Console.WriteLine("Compatível com Diabetes Gestacional");
}
else{
    Console.WriteLine("Diabetes Mellitus na Gravidez");
}

Console.ResetColor();