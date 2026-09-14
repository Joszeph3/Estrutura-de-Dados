jogos = ["Minecraft", "GTA V", "Valorant"]
print("----------------------------------------------")
print("Lista inicial:", jogos)
print("----------------------------------------------")

# Adicionando multiplos itens na lista
print("----------------------------------------------")
jogos.extend(["Fortnite", "Cod", "The Last of Us", "CS GO"])
print("Após adicionar:", jogos)
print("----------------------------------------------")

# Alterando um item na lista 
print("----------------------------------------------")
jogos[1] = "Red Dead Redemption 2"
print("Após alterar:", jogos)
print("----------------------------------------------")

# Removendo um item na lista 
print("----------------------------------------------")
jogos.remove("Valorant")
print("Após remover:", jogos)
print("----------------------------------------------")

# Dividindo a Lista
primeiro_grupo = jogos[:3]
segundo_grupo = jogos[3:]
print("----------------------------------------------")
print("Primeiro grupo:", primeiro_grupo)
print("Segundo grupo:", segundo_grupo)
print("----------------------------------------------")
