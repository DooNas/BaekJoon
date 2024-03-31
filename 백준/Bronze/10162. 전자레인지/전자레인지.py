t = int(input())
# A = 300, B = 60, C = 10
A,B,C = 0,0,0
check = True
if t // 300 != 0:
    A = t // 300
    t = t % 300
if t // 60 != 0:
    B = t // 60
    t = t % 60
if t % 10 == 0:
    C = t // 10
else:
    check = False
if check :
    print(f"{A} {B} {C}")
else : print(-1)