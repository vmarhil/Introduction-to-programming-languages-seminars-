﻿// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.Clear();
 
bool x = true; 
bool y = false; 
 
bool x1 = true; 
bool y1 = true; 
 
bool x2 = false; 
bool y2 = true; 
 
bool x3 = false; 
bool y3 = false; 
 
if ((!(x||y) == (!x&&!y)) 
&&(!(x1||y1) == (!x&&!y)) 
&&(!(x2||y2) == (!x2&&!y2)) 
&&(!(x3||y3) == (!x3&&!y3))) 
Console.WriteLine("утверждение истина"); 
else 
Console.WriteLine("утверждение ложь");