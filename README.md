# Описание программы

Данная программа формирует из массива строк, заданного пользователем, новый массив, в котором длина строк не превышает трех символов. 

## Структура программы: 
1. Метод **GetStringArrayFromUser** позволяет создать массив из строк. Размер и элементы массива вводятся пользователем с клавиатуры.
2. Метод **PrintStringArray** выводит массив в консоль.
3. Метод **GetTextFinalLength** определяет количество элементов в исходном массиве, число символов в которых менее или равно 3, и записывает это количество в отдельную переменную *textFinalLength*.
4. Метод **GetTextLessThanThree** создает новый массив с размером, равным значению переменной *textFinalLength*, после чего определяет элементы исходного массива, , число символов в которых менее или равно 3, и записывает их в новый массив.
5. Новый массив выводится в консоль методом **PrintStringArray**.

## Алгоритм программы
![Диаграмма с алгоритмом программы](/diagram.png)