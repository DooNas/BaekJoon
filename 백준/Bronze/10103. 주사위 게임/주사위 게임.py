count = int(input())
sa,sb = 100,100
for _ in range(count):
    ra,rb = map(int, input().split())
    if ra < rb : sa -= rb
    elif rb < ra : sb -= ra
print(sa)
print(sb)