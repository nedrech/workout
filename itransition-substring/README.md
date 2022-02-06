# Подстрока
Задача от компании Itransition на курсах обучения.
## Задача
Реализовать алгоритм, печатающий на консоль самую длинную общую подстроку всех переданных в виде аргументов командной строки строк.
### Примеры
При различных решениях выводы могут отличаться.
```console
nedrech@server:~$ node lcs.js ABCDEFZ WBCDXYZ
BCD
```
```console
nedrech@server:~$ node lcs.js 132 12332 12312
1
```
```console
nedrech@server:~$ node lcs.js ABCDEFGH ABCDEFG ABCEDF ABCED
ABC
```
```console
nedrech@server:~$ node lcs.js ABCDEFGH ABCDEFG ABCEDF ABCED
ABC
```
```console
nedrech@server:~$ node lcs.js ABCDEFGH ABCDEFG ABCDEF ABCDE
ABCDE
```
```console
nedrech@server:~$ node lcs.js ABCDEFGH ABCDEFG ABCDEF ABCDE EDCBA
BC
```
```console
nedrech@server:~$ node lcs.js ABCDEFGH ABCDEFG AxBCDEF ABCDxE EDCBCAABCD
BCD
```
```console
nedrech@server:~$ node lcs.js ABCQEFDEFGHIJ BCXEFGYZBCDEWEFGHU
EFGH
```
```console
nedrech@server:~$ node lcs.js ABCDEFGH 1234


```
```console
nedrech@server:~$ node lcs.js ABCDEFGH
ABCDEFGH
```
```console
nedrech@server:~$ node lcs.js


```
