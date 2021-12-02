file = open("input.txt", "r")
contents = file.read().split('\n')

submarine = {
    "hori": 0,
    "depth": 0
}

for i in contents:
    split = i.split(' ')

    if split[0] == 'forward':
        submarine['hori'] += int(split[1])

    elif split[0] == 'up':
        submarine['depth'] -= int(split[1])

    elif split[0] == 'down':
        submarine['depth'] += int(split[1])

print(submarine['depth'] * submarine['hori'])