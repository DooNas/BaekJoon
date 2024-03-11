count = int(input())
result = []
for i in range(count):
  a = list(map(int, input().split()))
  a.sort()
  if a[0] == a[1] == a[2]:
    result.append(10000 + a[0] * 1000)
  elif a[0] == a[1] or a[1] == a[2] or a[0] == a[2]:
    n = 0
    if a[0] == a[1] :
      n = a[0]
    elif a[1] == a[2]:
      n = a[1]
    elif a[0] == a[2]:
      n = a[2]
    result.append(1000 + n * 100)
  else:
    result.append(max(a) * 100)
print(max(result))
