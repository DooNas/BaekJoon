def inputlist(count):
  x_list = []
  y_list = []
  for i in range(count):
    x,y = map(int, input().split())
    x_list.append(x)
    y_list.append(y)
  return x_list, y_list


def find_box(count, *xy):
  x = 0
  y = 0
  for i in range(count):
    if xy[0].count(xy[0][i]) == 1:
      x = xy[0][i]
    if xy[1].count(xy[1][i]) == 1:
      y = xy[1][i]
  return x, y


x_list = []
y_list = []
count = 3
x_list, y_list = inputlist(count)
x,y = find_box(count, x_list, y_list)
print(f"{x} {y}")
