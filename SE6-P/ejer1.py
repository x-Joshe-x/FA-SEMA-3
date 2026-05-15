num = int(input("Ingrese un numero: "))
while (num <= 0):
    num = int(input("Numero invalido. Ingrese un numero: "))

i = 1
print ()
while i<=12:
    print(f"{num} x {i} =  {num*i}")
    i+=1