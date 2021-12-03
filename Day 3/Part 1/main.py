file = open("input.txt", "r")
contents = file.read().split('\n')

gammaRate = ""
epsilonRate = ""

for i in range(0, len(contents[0])):
    mostCommon = {"0": 0, "1": 0}

    for j in range(0, len(contents)):
        mostCommon[contents[j][i]] += 1

    if mostCommon["0"] > mostCommon["1"]:
        gammaRate += "0"
        epsilonRate += "1"
    else:
        gammaRate += "1"
        epsilonRate += "0"

print(int(gammaRate, 2) * int(epsilonRate, 2))
