h,m = map(int,input().split())

if 0 <= h and h <= 23 and 0 <= m and m <= 59:
  if m >= 45:
    m -= 45
  else:
    h -= 1
    m += 15
    if h < 0:
      h = 23

print(f"{h} {m}")