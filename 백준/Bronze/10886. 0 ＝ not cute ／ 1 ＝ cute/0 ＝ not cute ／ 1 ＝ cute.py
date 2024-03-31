end = int(input())
yes = 0
no = 0
if end % 2 == 1 :
    for _ in range(end):
        x = int(input())
        if x == 0 :
            no += 1
        else :
            yes += 1
    if yes > no : print("Junhee is cute!")
    else : print("Junhee is not cute!")