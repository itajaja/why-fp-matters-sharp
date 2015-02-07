namespace whyfp

module Lists = 
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

  let append(a, b) = foldr(a, Cons, b)

  let count(a, n) = n + 1
  let length a = foldr(a, count, 0)