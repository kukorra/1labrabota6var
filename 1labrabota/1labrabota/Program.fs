open System  // Подключаем пространство имен для работы с Console и другими стандартными классами

// Функция для инвертирования чисел в списке
let obratchisla (numbers: int list) : int list =
    numbers |> List.map (fun x -> -x)

// Функция для ввода чисел пользователем
let readNumbers () =
    printfn "Введите числа, разделённые пробелами:"
    let input = Console.ReadLine() // Читаем строку ввода
    input.Split(' ')                // Разделяем строку по пробелам
    |> Array.map (fun x -> int x)   // Преобразуем строки в числа
    |> Array.toList                 // Преобразуем массив в список

// Получаем список чисел от пользователя
let dobavleniespiska = readNumbers ()

// Инвертируем числа
let izmenenniylist = obratchisla dobavleniespiska

// Выводим результат
printfn "Инвертированные числа: %A" izmenenniylist