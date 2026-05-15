password = " "
user = " "
intentos = 3

user = input("Ingrese el nombre del usuario: ")
password = input("Ingresar nueva contraseña la contraseña: ")

print("----------------------------------")
print("        VALIDAR CONTRASEÑA        ")
print("----------------------------------")

while intentos > 0:
    validar = input("Ingrese el nombre del usuario: ")
    validar = input("Ingresar nueva contraseña la contraseña: ")

    if validar == password and validar == user:
        print("Acceso concedido!")
        break
    else:
        intentos -= 1
        print("Contraseña incorrecta. Intentos restantes ",intentos)
else: print("ACCESO DENEGADO. CERRANDO PROGRAMA.......")