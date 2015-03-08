namespace whyfp

module NewtonRaphson =

  let next n x = (x + n/x) / 2.0

  let rec repeat f a =  Seq.unfold (fun x -> Some(f x, f (f x))) a

  let approximations n a0 = repeat (next n) a0

  let abs n =
    if n > 0.0
    then n
    else -n

  let rec within eps list =
    let a = Seq.head list
    let rest = Seq.skip 1 list
    let b = Seq.head rest
    if (abs (a-b)) <= eps
    then b
    else (within eps (rest))

  let sqrt a0 eps n = within eps (approximations n a0)