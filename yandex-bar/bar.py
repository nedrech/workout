import re

n, _ = map(int, input().strip().split(" "))

glass = [input() for _ in range(n)]

k = int(input())

parts = [0] * k
for i in range(k):
    _, count, symbol = input().strip().split(" ")
    parts[i] = [int(count), symbol]

iterator_glass = iter(glass[n-2::-1])
iterator_parts = iter(parts)

glass = [glass[-1]]

line = next(iterator_glass)
while line:
    part = next(iterator_parts, False)
    if part:
        for _ in range(part[0]):
            count = line.count(' ')
            line = re.sub(r'(?<=[|/\\])\s+(?=[\\/|])', ''.join([part[1]] * count), line)
            glass = [line] + glass
            line = next(iterator_glass, False)
    else:
        glass = [line] + glass
        line = next(iterator_glass, False)

print('\n'.join(glass))