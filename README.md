# **Программа для формирования нового массива из элементов старого массива, длина которых меньше либо равна трем символам.**
---

## Описание методов.
## **void printArray(string[] array).** Метод для вывода элементов одномерного массива.

>### Входные данные - одномерный массив из сток.

>### Результат - печать массива в консоли в квадратных скобках с кавычками и запятыми между элементами массива.
---

## **string[] fillToThree(string[] array).** Метод для поиска в исходном массиве элементов, длина которых меньше либо равна трем с последующим формированием нового массива из этих найденных элементов. 

>### Входные данные - одномерный массив и строк.

>### Выходные данные - массив из сток, элементами которого являются элементы входного массива, длина которых равна либо меньше трех символов.
---
---

## Использование методов.

>1. Задаем исходный массив: string[] array= new string[4] {"hello","2","world",":-)"};
>2. Печатаем исходный массив: printArray(array);
>3. Вызываем метод печати параметром которого является метод поиска нужных элементов из заданного ранее массива.