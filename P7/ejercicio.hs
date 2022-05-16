--realizar una funcion para sumar 2 numeros
-- suma de dos numeros
import System.Directory

suma :: Int -> Int -> Int
suma x y = x + y

resta :: Int -> Int -> Int
resta x y = x - y

multiplicasion :: Int -> Int -> Int
multiplicasion x y = x * y

divicion :: Int -> Int -> Int
divicion x y = x `div` y


main = do
    putStrLn "Ingrese un numero"
    num1 <- getLine
    putStrLn "Ingrese otro numero"
    num2 <- getLine
    putStrLn "La suma es: "
    print(suma (read num1) (read num2))
    putStrLn "La resta es: "
    print(resta (read num1) (read num2))
    putStrLn "La multiplicasion es: "
    print(multiplicasion (read num1) (read num2))
    putStrLn "La divicion es: "
    print(divicion (read num1) (read num2))

    