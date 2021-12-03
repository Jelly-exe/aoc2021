file = open("input.txt", "r")
contents = file.read().split('\n')


def function(values, index, type):
    newValues = []

    mostCommonValues = {
        "0": 0,
        "1": 0
    }
    for j in range(0, len(values)):
        mostCommonValues[values[j][index]] += 1

    if (mostCommonValues["0"] > mostCommonValues["1"] and type == "oxygen") or (mostCommonValues["1"] >= mostCommonValues["0"] and type == "CO2"):
        lookingFor = "0"
    else:
        lookingFor = "1"

    for i in values:
        if i[index] == lookingFor: newValues.append(i)

    if len(newValues) == 1:
        return newValues[0]

    return function(newValues, index + 1, type)


oxygen = function(contents, 0, "oxygen")
co2 = function(contents, 0, "CO2")

print(int(oxygen, 2) * int(co2, 2))
