namespace whyfp

module Examples =
  
  open whyfp.Lists

  let list1 = Cons(1, Cons(2, Cons(3, Cons(4, Nil))))

  let sum1 = sum list1

  let prod1 = prod list1

  let list2 = Cons(true, Cons(true, Cons(false, Nil)))

  let true1 = anyTrue list2

  let false1 = allTrue list2

  let list3 = Cons(5, Cons(6, Cons(7, Cons(8, Nil))))

  let list4 = append(list1, list3)