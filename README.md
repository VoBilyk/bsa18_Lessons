# Lesson1_StructuresAndLINQ

Используя HttpClient получил набор открытых данных с помощью API запросов и представил полученные данные в виде набора
сущностей (вложенных объектов).
-Users
---Posts
-------Comments
---Todos

Список запросов:
1. Получить количество комментов под постами конкретного пользователя (по айди) (список из пост-количество)
2. Получить список комментов под постами конкретного пользователя (по айди), где body коммента < 50 символов (список из комментов)
3. Получить список (id, name) из списка todos которые выполнены для конкретного пользователя (по айди)
4. Получить список пользователей по алфавиту (по возрастанию) с отсортированными todo items по длине name (по убыванию)
5. Получить следующую структуру (передать Id пользователя в параметры)
- User
- Последний пост пользователя (по дате)
- Количество комментов под последним постом
- Количество невыполненных тасков для пользователя
- Самый популярный пост пользователя (там где больше всего комментов с длиной текста больше 80 символов)
- Самый популярный пост пользователя (там где больше всего лайков)
6. Получить следующую структуру (передать Id поста в параметры):
- Пост
- Самый длинный коммент поста
- Самый залайканный коммент поста
- Количество комментов под постом где или 0 лайков или длина текста < 80
