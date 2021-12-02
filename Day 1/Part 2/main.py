file = open("input.txt", "r")
contents = file.read().split('\n')

for i in range(0, len(contents) - 1):
    contents[i] = int(contents[i])

total = 0

for i in range(0, len(contents) - 4):
    if contents[i + 3] > contents[i]:
        total += 1

print(total)