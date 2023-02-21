// Задача 60 

void WriteIndexMatrix (int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
      for (int k = 0; k < matrix3D.GetLength(2); k++)
      {
        Console.Write( $"{matrix3D[i,j,k]}({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
Console.Clear();
int[,,] matrix3D = 
{
    {
        {32, 34},
        {35, 45}    
    },
    {
        {44, 65},
        {12, 36}
    },
    {
        {45, 79},
        {98, 33}
    }
};
WriteIndexMatrix(matrix3D);