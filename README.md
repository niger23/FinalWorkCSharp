## Итоговая проверочная работа
---
### Текст задачи:

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

Для решения данной задачи
***Создаём 3 функции:***

+ ### Создание и заполнение исходного массива
> *Запрашиваем у пользователя поочерёдно каждый элемент и записываем, добавляя каждый раз в размер массива +1.*
---
    Как только пользователь ввёл "пустой" элемент - заканчиваем и возвращаем готовый массив.
+ ### Вывод массива в консоль
> *С помощью цикла поочерёдно выводим все элементы массива с запятой.*
---
    Последний элемент выводим отдельно, для эстетического воприятия и отсутствия запятой после последнего элемента.
+ ### Создаём массив из элементов исходного, которые меньше либо равны 3 символам.
> *Создаём "нулевой" массив. Проверяем каждый элемент входящего массива, и если он удовлетворяет нашим условиям (а именно его размер меньше либо равен 3), мы записываем его в новый массив. Предварительно увеличив размер результирующего на 1.*
---
    Как только только были проверены все элементы возвращаем результирующий массив.


**Задача решена!**
*Спасибо за внимание!*

---
---
---
Приложение:
- блок схема 3 функции
![blockDiagram](https://raw.githubusercontent.com/niger23/FinalWorkCSharp/main/blockDiagram.png)