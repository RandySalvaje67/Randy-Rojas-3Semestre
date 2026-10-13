//Or --> And --> And
Console.WriteLine((false || false) && false && false); // False
Console.WriteLine((true || false) && true && false);   // False
Console.WriteLine((true || false) && false && true);   // False
Console.WriteLine((true || true) && true && true);     // True

Console.WriteLine();

//And --> Not --> Or
Console.WriteLine((false && false) || !false); // True
Console.WriteLine((true && false) || !true);   // False
Console.WriteLine((false && true) || !false);  // True
Console.WriteLine((true && true) || !true);    // True
