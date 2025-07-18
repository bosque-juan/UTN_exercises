
using Ej_9_tabla_ingresos;

Supermercados sucursal1 = new Supermercados(300, 400, 500);
Supermercados sucursal2 = new(200, 100, 700);
Supermercados sucursal3 = new Supermercados(5000.78, 200.56, 5000.56);
double[,] CadenaSupermercado = new double[3, 3]
{
    { sucursal1.mes1,sucursal1.mes2,sucursal1.mes3 },
    { sucursal2.mes1,sucursal2.mes2,sucursal2.mes3 },
    { sucursal3.mes1,sucursal3.mes2,sucursal3.mes3}
};

double totalCadenaVenta = 0;
for (int i = 0; i < CadenaSupermercado.GetLength(0); i++)
{
    double totalSucursal = 0;
    for (int j = 0; j < CadenaSupermercado.GetLength(1); j++)
    {
        totalSucursal = totalSucursal + CadenaSupermercado[i, j];
        Console.Write($"{CadenaSupermercado[i, j]}\t");
    }
    Console.WriteLine($"El total vendido por la sucursal{i + 1}, fué de: {totalSucursal}");
    totalCadenaVenta += totalSucursal;
}
Console.WriteLine($"El total vendido por todas las cadenas fué de: {totalCadenaVenta}");
