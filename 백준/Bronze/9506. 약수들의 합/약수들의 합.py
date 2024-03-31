def get_divisorList(num):
    # 주어진 수의 약수를 찾아 리스트로 반환합니다. 숫자 자신은 제외합니다.
    divisorsList = []
    for t in range(1, int(num ** (1 / 2)) + 1):
        if num % t == 0:
            divisorsList.append(t)
            if t != num // t and t != 1:
                divisorsList.append(num // t)
    divisorsList.sort()
    return divisorsList

while True:
    n = int(input())
    if n == -1:  # 입력 종료 조건
        break
    else:
        divisorsList = get_divisorList(n)  # 약수 리스트 생성
        if n == sum(divisorsList):  # 완전수 판별
            x = ' + '.join(map(str, divisorsList))
            print(f"{n} = {x}")  # 완전수일 경우 출력
        else:
            print(f"{n} is NOT perfect.")  # 완전수가 아닐 경우 출력
