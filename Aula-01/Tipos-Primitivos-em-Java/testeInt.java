import java.util.Scanner;

public class testeInt {
 public static void main(String[] args) {
 
 Scanner sc = new Scanner(System.in);  

 int baseTriangulo = 0;
 int alturaTriangulo = 0;
 
     System.out.println("---------------------------------------------------------");
     System.out.println("Digite o valor da base do seu triangulo (em centímetros)");
     System.out.println("---------------------------------------------------------");

     baseTriangulo = sc.nextInt();

     System.out.println("-----------------------------------------------------------");
     System.out.println("Digite o valor da altura do seu triangulo (em centímetros)");
     System.out.println("-----------------------------------------------------------");
    
     alturaTriangulo = sc.nextInt();

 int areaTriangulo = (baseTriangulo*alturaTriangulo)/2;

     System.out.println("------------------------------------------------");
     System.out.println("A área do seu triangulo é: " + areaTriangulo + " cm²");
     System.out.println("------------------------------------------------");

 sc.close();
 }
}
