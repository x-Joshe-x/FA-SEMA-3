sumap = sumai = 0

while True :
    num = int(input("Ingrese un numero positivo o 0 para salir: "))

    if (num < 0):
        print("Incorrecto. Intente nuevamente!\n ")
        continue
    if (num == 0): break
    elif num%2==0: sumap+=num
    else: sumai+=num

    print("\n\nSuma de Pares: ", sumap)
    print("\n\nSuma de impares: ", sumai)