def matrixout(a):
    for i in range(len(a)):
        for j in range(len(a)):
            print(a[i][j], "\t", end='')
        print()



def make_stepback(coord, last, finish):
    if last[-1] == 1:
        coord[1] = coord[1] + 1
    if last[-1] == 2:
        coord[0] = coord[0] - 1
    if last[-1] == 3:
        coord[1] = coord[1] - 1
    if last[-1] == 4:
        coord[0] = coord[0] + 1
    last.pop()
    return coord
    #make_step(coord, last, finish)

def make_step(start, last, finish):
    coord = [start[0], start[1]]
    if coord == finish:
        return True
    while coord != finish:
        a[coord[0]][coord[1]] = 1
        if coord[1] - 1 < len(a) and coord[1] - 1 >= 0 and a[coord[0]][coord[1] - 1] != 1:
            coord[1] = coord[1] - 1
            if coord == finish:
                return True
            last.append(1)
          #  matrixout(a)
        elif coord[0] + 1 < len(a) and a[coord[0] + 1][coord[1]] != 1:
            coord[0] = coord[0] + 1
            if coord == finish:
                return True
            last.append(2)
           # matrixout(a)
        elif coord[1] + 1 < len(a) and coord[1] + 1 >= 0 and a[coord[0]][coord[1] + 1] != 1:
            coord[1] = coord[1] + 1
            if coord == finish:
                return True
            last.append(3)
            #matrixout(a)
        elif coord[0] - 1 >= 0 and a[coord[0] - 1][coord[1]] != 1:
            coord[0] = coord[0] - 1
            if coord == finish:
                return True
            last.append(4)
            #matrixout(a)
        elif (coord[1] - 1 >= len(a) or coord[1] - 1 < 0 or a[coord[0]][coord[1] - 1] == 1) and (coord[0] + 1 >= len(a) or a[coord[0] + 1][coord[1]] == 1) and (coord[1] + 1 >= len(a) or coord[1] + 1 < 0 or a[coord[0]][coord[1] + 1] == 1) and (coord[0] - 1 < 0 or a[coord[0] - 1][coord[1]] == 1):
            if len(last) != 0:
                coord = make_stepback(coord, last, finish)
            else:
                print("Невозможно провести всех к выходам")
                exit()
    return False




a = [
    [1, 0, 1, 1, 1, 1, 0, 0],
    [1, 0, 1, 1, 1, 1, 1, 0],
    [0, 0, 1, 1, 0, 0, 0, 0],
    [1, 0, 1, 1, 1, 0, 0, 0],
    [1, 0, 1, 1, 1, 0, 0, 0],
    [1, 0, 1, 1, 0, 0, 0, 0],
    [1, 0, 1, 1, 0, 1, 0, 0],
    [1, 0, 1, 1, 1, 1, 0, 0],
]

matrixout(a)

start = list()
finish = list()
count = 0
# 2 - вход                                # 3 - выход
for i in range(len(a)):
    if a[0][i] == 0:
        a[0][i] = 2
        count += 1
        start.append([0, i])

for i in range(len(a)):
    if a[len(a) - 1][i] == 0:
        a[len(a) - 1][i] = 3
        finish.append([len(a) - 1, i])
last = list()
start = list(start)


for i in range(count):
    last = []
    if make_step(start[i], last, finish[i]):
        continue
    else:
        print("Невозможно провести всех к выходам")
        exit()
print("\nВсе прошли")