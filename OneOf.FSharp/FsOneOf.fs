module OneOf.FSharp

open OneOf
type FsOneOf1<'t0> = 
  | T1_0 of 't0
  member self.toOneOf =
    match self with
    | T1_0 t0 -> OneOf<'t0>.op_Implicit t0
  static member fromOneOf (oneOf: OneOf<'t0>) = 
    oneOf.Match(
      (fun t0 -> T1_0 t0)
    )

type FsOneOf2<'t0, 't1> = 
  | T2_0 of 't0
  | T2_1 of 't1
  member self.toOneOf =
    match self with
    | T2_0 t0 -> OneOf<'t0, 't1>.op_Implicit t0
    | T2_1 t1 -> OneOf<'t0, 't1>.op_Implicit t1
  static member fromOneOf (oneOf: OneOf<'t0, 't1>) = 
    oneOf.Match(
      (fun t0 -> T2_0 t0),
      (fun t1 -> T2_1 t1)
    )

type FsOneOf3<'t0, 't1, 't2> = 
  | T3_0 of 't0
  | T3_1 of 't1
  | T3_2 of 't2
  member self.toOneOf =
    match self with
    | T3_0 t0 -> OneOf<'t0, 't1, 't2>.op_Implicit t0
    | T3_1 t1 -> OneOf<'t0, 't1, 't2>.op_Implicit t1
    | T3_2 t2 -> OneOf<'t0, 't1, 't2>.op_Implicit t2
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2>) = 
    oneOf.Match(
      (fun t0 -> T3_0 t0),
      (fun t1 -> T3_1 t1),
      (fun t2 -> T3_2 t2)
    )

type FsOneOf4<'t0, 't1, 't2, 't3> = 
  | T4_0 of 't0
  | T4_1 of 't1
  | T4_2 of 't2
  | T4_3 of 't3
  member self.toOneOf =
    match self with
    | T4_0 t0 -> OneOf<'t0, 't1, 't2, 't3>.op_Implicit t0
    | T4_1 t1 -> OneOf<'t0, 't1, 't2, 't3>.op_Implicit t1
    | T4_2 t2 -> OneOf<'t0, 't1, 't2, 't3>.op_Implicit t2
    | T4_3 t3 -> OneOf<'t0, 't1, 't2, 't3>.op_Implicit t3
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3>) = 
    oneOf.Match(
      (fun t0 -> T4_0 t0),
      (fun t1 -> T4_1 t1),
      (fun t2 -> T4_2 t2),
      (fun t3 -> T4_3 t3)
    )

type FsOneOf5<'t0, 't1, 't2, 't3, 't4> = 
  | T5_0 of 't0
  | T5_1 of 't1
  | T5_2 of 't2
  | T5_3 of 't3
  | T5_4 of 't4
  member self.toOneOf =
    match self with
    | T5_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4>.op_Implicit t0
    | T5_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4>.op_Implicit t1
    | T5_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4>.op_Implicit t2
    | T5_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4>.op_Implicit t3
    | T5_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4>.op_Implicit t4
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4>) = 
    oneOf.Match(
      (fun t0 -> T5_0 t0),
      (fun t1 -> T5_1 t1),
      (fun t2 -> T5_2 t2),
      (fun t3 -> T5_3 t3),
      (fun t4 -> T5_4 t4)
    )

type FsOneOf6<'t0, 't1, 't2, 't3, 't4, 't5> = 
  | T6_0 of 't0
  | T6_1 of 't1
  | T6_2 of 't2
  | T6_3 of 't3
  | T6_4 of 't4
  | T6_5 of 't5
  member self.toOneOf =
    match self with
    | T6_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5>.op_Implicit t0
    | T6_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5>.op_Implicit t1
    | T6_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5>.op_Implicit t2
    | T6_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5>.op_Implicit t3
    | T6_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5>.op_Implicit t4
    | T6_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5>.op_Implicit t5
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5>) = 
    oneOf.Match(
      (fun t0 -> T6_0 t0),
      (fun t1 -> T6_1 t1),
      (fun t2 -> T6_2 t2),
      (fun t3 -> T6_3 t3),
      (fun t4 -> T6_4 t4),
      (fun t5 -> T6_5 t5)
    )

type FsOneOf7<'t0, 't1, 't2, 't3, 't4, 't5, 't6> = 
  | T7_0 of 't0
  | T7_1 of 't1
  | T7_2 of 't2
  | T7_3 of 't3
  | T7_4 of 't4
  | T7_5 of 't5
  | T7_6 of 't6
  member self.toOneOf =
    match self with
    | T7_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>.op_Implicit t0
    | T7_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>.op_Implicit t1
    | T7_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>.op_Implicit t2
    | T7_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>.op_Implicit t3
    | T7_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>.op_Implicit t4
    | T7_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>.op_Implicit t5
    | T7_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>.op_Implicit t6
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6>) = 
    oneOf.Match(
      (fun t0 -> T7_0 t0),
      (fun t1 -> T7_1 t1),
      (fun t2 -> T7_2 t2),
      (fun t3 -> T7_3 t3),
      (fun t4 -> T7_4 t4),
      (fun t5 -> T7_5 t5),
      (fun t6 -> T7_6 t6)
    )

type FsOneOf8<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7> = 
  | T8_0 of 't0
  | T8_1 of 't1
  | T8_2 of 't2
  | T8_3 of 't3
  | T8_4 of 't4
  | T8_5 of 't5
  | T8_6 of 't6
  | T8_7 of 't7
  member self.toOneOf =
    match self with
    | T8_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t0
    | T8_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t1
    | T8_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t2
    | T8_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t3
    | T8_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t4
    | T8_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t5
    | T8_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t6
    | T8_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>.op_Implicit t7
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7>) = 
    oneOf.Match(
      (fun t0 -> T8_0 t0),
      (fun t1 -> T8_1 t1),
      (fun t2 -> T8_2 t2),
      (fun t3 -> T8_3 t3),
      (fun t4 -> T8_4 t4),
      (fun t5 -> T8_5 t5),
      (fun t6 -> T8_6 t6),
      (fun t7 -> T8_7 t7)
    )

type FsOneOf9<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8> = 
  | T9_0 of 't0
  | T9_1 of 't1
  | T9_2 of 't2
  | T9_3 of 't3
  | T9_4 of 't4
  | T9_5 of 't5
  | T9_6 of 't6
  | T9_7 of 't7
  | T9_8 of 't8
  member self.toOneOf =
    match self with
    | T9_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t0
    | T9_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t1
    | T9_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t2
    | T9_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t3
    | T9_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t4
    | T9_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t5
    | T9_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t6
    | T9_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t7
    | T9_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>.op_Implicit t8
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8>) = 
    oneOf.Match(
      (fun t0 -> T9_0 t0),
      (fun t1 -> T9_1 t1),
      (fun t2 -> T9_2 t2),
      (fun t3 -> T9_3 t3),
      (fun t4 -> T9_4 t4),
      (fun t5 -> T9_5 t5),
      (fun t6 -> T9_6 t6),
      (fun t7 -> T9_7 t7),
      (fun t8 -> T9_8 t8)
    )

