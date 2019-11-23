from random import randrange

for c in list("ThouHazZeKey"):
    r = randrange(33, 126)
    d = ord(c)-r
    print("charList.Add((char)((int)\'" + str(chr(r)) + "\'+"+str(d)+"));")