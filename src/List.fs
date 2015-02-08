namespace whyfp

module Lists = 

  let Nil = []

  let Cons a b = a :: b

  let rec foldr f zero l =
    match l with
    | [] -> zero
    | a :: b -> f a (foldr f zero b)

  let plus a b = a + b
  let sum = foldr (plus) 0

  let times a b = a * b
  let prod = foldr times 1

  let or_ a b = a || b
  let anyTrue = foldr or_ false

  let and_ a b = a && b
  let allTrue = foldr and_ true

  let append l1 l2 = foldr Cons l2 l1

  let count a b = a + 1
  let length = foldr count 0

  let fAndCons f = f >> Cons

  let map f = foldr (fAndCons f) Nil

  let double x = x * 2
  let doubleAll = map double

  let sumMatrix = (map sum) >> sum