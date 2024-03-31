count = int(input())
for _ in range(count):
    reuslt = input()
    temp = ''
    plus, answer = 1, 0
    for check in reuslt:
        if check == 'X':
            temp = check
            plus = 1
        else:
            if temp == check: plus += 1
            answer += plus
            temp = check
    print(answer)