file = open("input.txt", "r")
contents = file.readlines()

for i in range(0, len(contents) - 1):
    contents[i] = int(contents[i])

total = 0

for i in range(0, len(contents) - 2):
    if contents[i] < contents[i + 1]:
        total += 1

print(total)