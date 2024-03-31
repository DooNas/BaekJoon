count = int(input())
for _ in range(count):
    sumY, sumK = 0,0
    for _ in range(9):
        sy, sk = map(int, input().split())
        sumY += sy
        sumK += sk
    if sumY > sumK : print('Yonsei')
    elif sumY == sumK : print('Draw')
    else : print('Korea')