namespace whyfp

module Lists = 

  let Nil = []

  let Cons a b = a :: b

  let rec foldr f zero l =
    match l with
    | [] -> zero
    | a :: b -> f a (foldr f zero b)

  let plus a b = a + b
  let sum l = foldr (plus) 0 l

  let times a b = a * b
  let prod l = foldr times 1 l

  let or_ a b = a || b
  let anyTrue l = foldr or_ false l

  let and_ a b = a && b
  let allTrue l = foldr and_ true l

  let append l1 l2 = foldr Cons l2 l1

  let count a b = a + 1
  let length l = foldr count 0 l