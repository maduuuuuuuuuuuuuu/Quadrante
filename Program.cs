double coordenadaX, coordenadaY;
Console.WriteLine("Digite duas coordenadas e descubra em qual quadrante elas estão localizadas!");
Console.WriteLine("Digite a coordenada X");
coordenadaX = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Digite a coordenada Y");
coordenadaY = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("---Quadrante Cartesiano---");
Console.WriteLine($"Coordenada x: {coordenadaX}");
Console.WriteLine($"Coordenada y: {coordenadaY}");


if(coordenadaX < 0 && coordenadaY < 0){
    Console.WriteLine($"O ponto({coordenadaX}, {coordenadaY}) fica no quadrante 3");

}
else if(coordenadaX > 0 && coordenadaY < 0){
    Console.WriteLine($"O ponto({coordenadaX}, {coordenadaY}) fica no quadrante 4");

}
else if(coordenadaX > 0 && coordenadaY > 0){
    Console.WriteLine($"O ponto({coordenadaX}, {coordenadaY}) fica no quadrante 1");
}
else if(coordenadaX < 0 && coordenadaY > 0){
    Console.WriteLine($"O ponto({coordenadaX}, {coordenadaY}) fica no quadrante 2");
}
else{
    Console.WriteLine($"O ponto({coordenadaX}, {coordenadaY}) fica na origem");
}

