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

  /// Trees

  type Tree<'T> = Node of 'T * (Tree<'T> List)

  let Node a b = Node(a, b)

  let rec foldTree f g a tree =
    match tree with
    | Node(label, subtrees) -> f label (foldTreeList f g a subtrees)
  and foldTreeList f g a treeList =
    match treeList with
    | subtree :: rest -> g (foldTree f g a subtree) (foldTreeList f g a rest)
    | [] -> a

  let sumTree tree = foldTree plus plus 0 tree

  let treeLabels tree = foldTree Cons append Nil tree

  let mapTree f = foldTree (f >> Node) Cons Nil