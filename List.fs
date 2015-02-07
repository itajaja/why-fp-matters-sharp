module my.Lists

/// List type built out of Nil and Cons primitives
/// e.g: Cons(1, Cons(2, Cons(3, Nil)))
type List<'T> = 
  | Nil
  | Cons of ('T * List<'T>)

  override this.ToString() = 
    "[" + this.toStringInt() + "]"
  
  member private this.toStringInt() = 
    match this with
    | Nil -> ""
    | Cons(a, Cons(b, c)) -> a.ToString() + ", " + Cons(b,c).toStringInt()
    | Cons(a, Nil) -> a.ToString()

let rec foldr (l , f, zero) =
  match l with
  | Nil -> zero
  | Cons(a, b) -> f (a, foldr (b, f, zero))

let plus (a, b) = a + b
let sum l = foldr (l, plus, 0)

let times (a, b) = a * b
let prod l = foldr (l, times, 1)

let or_ (a, b) = a || b
let anyTrue l = foldr (l, or_, false)

let and_ (a, b) = a && b
let allTrue l = foldr (l, and_, true)

// test

let list1 = Cons(1, Cons(2, Cons(3, Cons(4, Nil))))

let sum1 = sum list1

let prod1 = prod list1

let list2 = Cons(true, Cons(true, Cons(false, Nil)))

let true1 = anyTrue list2

let false1 = allTrue list2


////////////////////

let append(a, b) = foldr(a,Cons,b)

let list3 = Cons(5, Cons(6, Cons(7, Cons(8, Nil))))

let list4 = append(list1, list3)