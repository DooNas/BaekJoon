from collections import defaultdict

def solution(name, yearning, photo):
    score = defaultdict(int)
    for i in range(len(name)):
        score[name[i]] += yearning[i]
    answer = []
    for matchs in photo:
        total = 0
        for m in matchs:
            total += score[m]
        answer.append(total)
    return answer