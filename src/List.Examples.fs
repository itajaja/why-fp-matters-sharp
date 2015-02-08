namespace whyfp

module Examples =
  
  open whyfp.Lists

  let list1 = Cons 1 (Cons 2 (Cons 3 (Cons 4 Nil))) // [1, 2, 3, 4]

  let sum1 = sum list1 // 10

  let prod1 = prod list1 // 24

  let list2 = Cons true (Cons true (Cons false Nil)) // [true, true, false]

  let true1 = anyTrue list2 // true

  let false1 = allTrue list2 // false

  let list3 = Cons 5 (Cons 6 (Cons 7 (Cons 8 Nil))) // [5, 6, 7, 8]

  let list4 = append list1 list3 // [1, 2, 3, 4, 5, 6, 7, 8]

  let lit4Lenght = length list4 // 8