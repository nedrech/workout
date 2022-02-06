# Яндекс Бар
Задача от Яндекса в рамках тестирования на стажировку 2021-2022
## Задача
Реализовать программу, которая будет заполнять заданную емкость (готовить коктейль) определенными ингридиентами.
### Входные данные
Первая строка - два числа (N, M), которые задают высоту и ширину емкости.</br>
Вторая и до N+1 строки - задание емкости.</br>
K - количество ингридиентов коктейля.</br>
K строк с заданием компонента в виде: gin 2 % (наименование, кол-во частей и символ-заполнитель)
### Выходные данные
Заполненный стакан необходимыми ингридиентами в нужной последовательности.
#### Пример 1
```
8 15
\             /
.|           |.
.|           |.
..\         /..
...|       |...
...|       |...
....\     /....
.....\___/.....
2
gin 2 %
tonic 4 *
```
```
\             /
.|***********|.
.|***********|.
..\*********/..
...|*******|...
...|%%%%%%%|...
....\%%%%%/....
.....\___/.....
```
#### Пример 2
```
10 23
.........\   /.........
........./   \.........
......../     \........
......./       \.......
....../         \......
...../           \.....
..../             \....
.../               \...
../                 \..
./___________________\.
1
acid 5 X
```
```
.........\   /.........
........./   \.........
......../     \........
......./       \.......
....../XXXXXXXXX\......
...../XXXXXXXXXXX\.....
..../XXXXXXXXXXXXX\....
.../XXXXXXXXXXXXXXX\...
../XXXXXXXXXXXXXXXXX\..
./___________________\.
```
#### Пример 3
```
16 28
...|                    |...
...|                    |...
...|                    |...
...|                    |...
...|                    |...
...|                    |...
....|                  |....
....|                  |....
....|                  |....
....|                  |....
....|                  |....
.....|                |.....
.....|                |.....
.....|                |.....
.....|                |.....
......|______________|......
4
kahlua 4 k
baileys 5 b
cointreau 3 c
fire 1 !
```
```
...|                    |...
...|                    |...
...|!!!!!!!!!!!!!!!!!!!!|...
...|cccccccccccccccccccc|...
...|cccccccccccccccccccc|...
...|cccccccccccccccccccc|...
....|bbbbbbbbbbbbbbbbbb|....
....|bbbbbbbbbbbbbbbbbb|....
....|bbbbbbbbbbbbbbbbbb|....
....|bbbbbbbbbbbbbbbbbb|....
....|bbbbbbbbbbbbbbbbbb|....
.....|kkkkkkkkkkkkkkkk|.....
.....|kkkkkkkkkkkkkkkk|.....
.....|kkkkkkkkkkkkkkkk|.....
.....|kkkkkkkkkkkkkkkk|.....
......|______________|......
```
#### Пример 4
```
10 16
...|     \......
...|      /.....
../        /....
...\        /...
....|        \..
...../      |...
......\     /...
.......|   |....
....../     \...
.......\_____\..
4
some 1 (
thing 2 ?
really 3 )
strange 1 ^
```
```
...|     \......
...|      /.....
../^^^^^^^^/....
...\))))))))/...
....|))))))))\..
...../))))))|...
......\?????/...
.......|???|....
....../(((((\...
.......\_____\..
```