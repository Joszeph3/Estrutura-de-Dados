nota1 = 8.5
nota2 = 7.0
nota3 = 9.5

media = (nota1 + nota2 + nota3) / 3

print("Nota 1:", nota1)
print("Nota 2:", nota2)
print("Nota 3:", nota3)
print("Média: {:.2f}".format(media))

if media >= 7:
    print("Aluno aprovado.")
else:
    print("Aluno reprovado.")
