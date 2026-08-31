import java.util.Scanner;
public class teste_boolean {
public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
  
    System.out.println("Digite sua idade");
    int idade = sc.nextInt();
    
    boolean verificaIdade = idade >= 18;

    if(verificaIdade){
        
    System.out.println("Você é maior de idade!");

     }else {
        System.out.println("Você é menor de idade!");

     }

     sc.close();
}
}
