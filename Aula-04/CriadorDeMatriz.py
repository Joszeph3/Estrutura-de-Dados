matriz = []

for linha in range(3):
    linhaAtual = []

    for coluna in range(2):
      Escolha = int(input(f"Digite o valor [{linha}][{coluna}]"))
      linhaAtual.append(Escolha)

    matriz.append(linhaAtual)

print('\nMatriz 3X2:')

for i in matriz:
   print(i)

maior = matriz[0][0]

for linha in matriz:
   for coluna in linha:

      if coluna > maior:
         maior = coluna

print("\n O maior número da matriz é:", maior)