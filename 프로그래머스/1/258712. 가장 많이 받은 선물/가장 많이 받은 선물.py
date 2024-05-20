def solution(friends, gifts):
    g_record = {}   # 딕셔너리 선언
    for fri_set in friends:
        g_record[fri_set] = [0, {}] # [선물지수, 선물을 주고 받은 딕셔너리]
        for fri_input in friends:
            if fri_set != fri_input:
                g_record[fri_set][1][fri_input] = 0 # 선물을 주고 받은 딕셔너리 리스트 추가
    
    for gift in gifts:
        A,B = gift.split()
        g_record[A][0] += 1 # 준 선물
        g_record[A][1][B] += 1 # B에게 준 선물
        g_record[B][0] -= 1 # 받은 선물
        g_record[B][1][A] -= 1 # A에게 받은 선물
    answer = [0] * len(friends) # 배열 선언
    
    for key, values in g_record.items():
        owner = friends.index(key)
        giftpower = values[0]
        for taker, count in values[1].items():
            if count > 0 : # 준 선물량이 많다
                answer[owner] += 1
            elif count == 0 : # 준 선물량과 받은 선물량이 동일
                if giftpower > g_record[taker][0] : #선물지수 차이
                    answer[owner] += 1
    
    return max(answer)