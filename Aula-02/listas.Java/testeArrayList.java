import java.util.ArrayList;

public class testeArrayList {
 public static void main(String[] args) {
    
    ArrayList<String> nomes = new ArrayList<>(); 
    nomes.add("João"); 
    nomes.add("Maria");
    nomes.add("Pedro"); 
    
  System.out.println("Lista original: " + nomes);


     nomes.add("Paulo");
 
     System.out.println("Lista pós acrescimo: " + nomes);


     nomes.remove("Pedro");

     System.out.println("Lista pós acrescimo: " + nomes);
     
     nomes.set(0, "Ana");

     System.out.print("Lista pós alteração: " + nomes);

 /*
 Nesse exemplo utilizei a função ArrayList, tal opção permite alterar o array durante o código.

 Optei pelos seguintes testes:
 
 Adicionar: adicionei o nome Paulo
 Remover: removi o nome pedro
 Alterar: alterei o nome que se encontra no indice [0] (João) por Ana

 Evidente que existem outros tipos de alteração como "clear", porém optei por registrar esses..
 */
 }
}