using System;
using IMPLCLASS;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        Figure quadrateOne = new Figure();
        Figure quadrateTwo = new Figure();
        Figure quadrateThree = new Figure();

        Figure circleeOne = new Figure();
        Figure circleeTwo = new Figure();
        Figure circleeThree = new Figure();

        Figure triangleOne = new Figure();
        Figure triangleTwo = new Figure();
        Figure triangleThree = new Figure();

        Group Quadrates = new Group();
        Group Circlees = new Group();
        Group Triangles = new Group();

        Group GroupFigures = new Group();

        Quadrates.Add(quadrateOne);
        Quadrates.Add(quadrateTwo);
        Quadrates.Add(quadrateThree);

        Circlees.Add(circleeOne);
        Circlees.Add(circleeTwo);
        Circlees.Add(circleeThree);

        Triangles.Add(triangleOne);
        Triangles.Add(triangleTwo);
        Triangles.Add(triangleThree);

        GroupFigures.Add(Quadrates);
        GroupFigures.Add(Circlees);

        client.ClientCode(GroupFigures);
        client.ClientCode2(GroupFigures, Triangles);

        Quadrates.CalcMeasure();
        Console.WriteLine("\nСумма площадей квадратов: " + Quadrates.GetSumAreas());

        Circlees.CalcMeasure();
        Console.WriteLine("Сумма площадей окружностей: " + Circlees.GetSumAreas());

        Triangles.CalcMeasure();
        Console.WriteLine("Сумма площадей треугольников: " + Triangles.GetSumAreas());


    }
}