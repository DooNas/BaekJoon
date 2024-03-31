bowls = input()
dishlist = list(bowls)
temp = None
answer = 0
for glas in dishlist:
    if temp is None:
        temp = glas
        answer = 10
    else:
        if temp == glas:
            answer += 5
        else:
            answer += 10
        temp = glas

print(answer)