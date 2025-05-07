using System;
/*
E1P – ELABORE UM PROGRAMA NO QUAL REALIZA O CÁLCULO DE DOIS VALORES,
UTILIZANDO AS QUATRO OPERAÇÕES BÁSICAS DA MATEMÁTICA, ESCOLHIDA PELO USUÁRIO.
*/
 
class MainClass {
  public static void Main (string[] args) {
    double n1, n2, tt;
    char op; 
    bool erro = false; 
    string msgerro = ""; 
    tt = 0; 
    Console.WriteLine ("Digite o 1º Valor"); 
    n1 = double.Parse(Console.ReadLine());
 
    Console.WriteLine ("Digite o 2º Valor"); 
    n2 = double.Parse(Console.ReadLine());
 
    Console.WriteLine ("Digite:\n+ para adição\n- para subtração\n* para multiplicação\n/ para divisão ");
    // op = Console.ReadLine() ;
    op = char.Parse(Console.ReadLine());
 
    switch (op) {
      case '+' :
         Console.WriteLine("adição"); 
         tt = n1 + n2 ; 
         break;
      case '-': 
         Console.WriteLine("subtração"); 
         tt = n1 - n2 ; 
         break;
      case '*' :
         Console.WriteLine("multiplicação"); 
         tt = n1 * n2 ; 
         break;
      case '/': 
         Console.WriteLine("divisão"); 
         if(n2 != 0 ){
          tt = n1 / n2 ; 
         }
         else
         {
           msgerro = "Não dividirás por ZERO!"; 
         }
         break;
      default: 
         msgerro = "Op(era)ção Inválida!"; 
         break;
    }
 
    if(msgerro=="")  //(erro == false) //  (!erro){   // 
    {
      Console.WriteLine( "{0} {1} {2} = {3}", n1,  op, n2 , tt);
    }
    else
    {
      Console.WriteLine("ERRO!!\n\n{0}", msgerro);
    }
  }
}
