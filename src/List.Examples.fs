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

  let list5 = doubleAll(list1) // [2, 4, 6, 8]

  let matrix1 = Cons list1 (Cons list1 (Cons list3 Nil))

  let sum2 = sumMatrix matrix1 // 46

  let tree1 = Node 1 [(Node 2 Nil); (Node 3 [(Node 4 Nil); (Node 5 Nil)])]

  let sum3 = sumTree tree1 // 15

  let labels = treeLabels tree1 // [1, 2, 3, 4, 5]

  let tree2 = mapTree double tree1 //[2 [4; 6 [8, 10] ] ]