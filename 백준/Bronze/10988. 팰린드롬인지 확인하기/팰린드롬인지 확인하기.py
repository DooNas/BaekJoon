word = input()
palind = list(word)
palind.reverse()
palind = ''.join(palind)
if word == palind:
    print(1)
else:
    print(0)