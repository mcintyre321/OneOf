module FsOneOf

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

type FsOneOf10<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9> = 
  | T10_0 of 't0
  | T10_1 of 't1
  | T10_2 of 't2
  | T10_3 of 't3
  | T10_4 of 't4
  | T10_5 of 't5
  | T10_6 of 't6
  | T10_7 of 't7
  | T10_8 of 't8
  | T10_9 of 't9
  member self.toOneOf =
    match self with
    | T10_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t0
    | T10_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t1
    | T10_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t2
    | T10_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t3
    | T10_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t4
    | T10_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t5
    | T10_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t6
    | T10_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t7
    | T10_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t8
    | T10_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>.op_Implicit t9
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9>) = 
    oneOf.Match(
      (fun t0 -> T10_0 t0),
      (fun t1 -> T10_1 t1),
      (fun t2 -> T10_2 t2),
      (fun t3 -> T10_3 t3),
      (fun t4 -> T10_4 t4),
      (fun t5 -> T10_5 t5),
      (fun t6 -> T10_6 t6),
      (fun t7 -> T10_7 t7),
      (fun t8 -> T10_8 t8),
      (fun t9 -> T10_9 t9)
    )

type FsOneOf11<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10> = 
  | T11_0 of 't0
  | T11_1 of 't1
  | T11_2 of 't2
  | T11_3 of 't3
  | T11_4 of 't4
  | T11_5 of 't5
  | T11_6 of 't6
  | T11_7 of 't7
  | T11_8 of 't8
  | T11_9 of 't9
  | T11_10 of 't10
  member self.toOneOf =
    match self with
    | T11_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t0
    | T11_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t1
    | T11_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t2
    | T11_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t3
    | T11_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t4
    | T11_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t5
    | T11_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t6
    | T11_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t7
    | T11_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t8
    | T11_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t9
    | T11_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>.op_Implicit t10
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10>) = 
    oneOf.Match(
      (fun t0 -> T11_0 t0),
      (fun t1 -> T11_1 t1),
      (fun t2 -> T11_2 t2),
      (fun t3 -> T11_3 t3),
      (fun t4 -> T11_4 t4),
      (fun t5 -> T11_5 t5),
      (fun t6 -> T11_6 t6),
      (fun t7 -> T11_7 t7),
      (fun t8 -> T11_8 t8),
      (fun t9 -> T11_9 t9),
      (fun t10 -> T11_10 t10)
    )

type FsOneOf12<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11> = 
  | T12_0 of 't0
  | T12_1 of 't1
  | T12_2 of 't2
  | T12_3 of 't3
  | T12_4 of 't4
  | T12_5 of 't5
  | T12_6 of 't6
  | T12_7 of 't7
  | T12_8 of 't8
  | T12_9 of 't9
  | T12_10 of 't10
  | T12_11 of 't11
  member self.toOneOf =
    match self with
    | T12_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t0
    | T12_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t1
    | T12_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t2
    | T12_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t3
    | T12_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t4
    | T12_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t5
    | T12_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t6
    | T12_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t7
    | T12_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t8
    | T12_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t9
    | T12_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t10
    | T12_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>.op_Implicit t11
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11>) = 
    oneOf.Match(
      (fun t0 -> T12_0 t0),
      (fun t1 -> T12_1 t1),
      (fun t2 -> T12_2 t2),
      (fun t3 -> T12_3 t3),
      (fun t4 -> T12_4 t4),
      (fun t5 -> T12_5 t5),
      (fun t6 -> T12_6 t6),
      (fun t7 -> T12_7 t7),
      (fun t8 -> T12_8 t8),
      (fun t9 -> T12_9 t9),
      (fun t10 -> T12_10 t10),
      (fun t11 -> T12_11 t11)
    )

type FsOneOf13<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12> = 
  | T13_0 of 't0
  | T13_1 of 't1
  | T13_2 of 't2
  | T13_3 of 't3
  | T13_4 of 't4
  | T13_5 of 't5
  | T13_6 of 't6
  | T13_7 of 't7
  | T13_8 of 't8
  | T13_9 of 't9
  | T13_10 of 't10
  | T13_11 of 't11
  | T13_12 of 't12
  member self.toOneOf =
    match self with
    | T13_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t0
    | T13_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t1
    | T13_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t2
    | T13_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t3
    | T13_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t4
    | T13_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t5
    | T13_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t6
    | T13_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t7
    | T13_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t8
    | T13_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t9
    | T13_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t10
    | T13_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t11
    | T13_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>.op_Implicit t12
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12>) = 
    oneOf.Match(
      (fun t0 -> T13_0 t0),
      (fun t1 -> T13_1 t1),
      (fun t2 -> T13_2 t2),
      (fun t3 -> T13_3 t3),
      (fun t4 -> T13_4 t4),
      (fun t5 -> T13_5 t5),
      (fun t6 -> T13_6 t6),
      (fun t7 -> T13_7 t7),
      (fun t8 -> T13_8 t8),
      (fun t9 -> T13_9 t9),
      (fun t10 -> T13_10 t10),
      (fun t11 -> T13_11 t11),
      (fun t12 -> T13_12 t12)
    )

type FsOneOf14<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13> = 
  | T14_0 of 't0
  | T14_1 of 't1
  | T14_2 of 't2
  | T14_3 of 't3
  | T14_4 of 't4
  | T14_5 of 't5
  | T14_6 of 't6
  | T14_7 of 't7
  | T14_8 of 't8
  | T14_9 of 't9
  | T14_10 of 't10
  | T14_11 of 't11
  | T14_12 of 't12
  | T14_13 of 't13
  member self.toOneOf =
    match self with
    | T14_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t0
    | T14_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t1
    | T14_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t2
    | T14_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t3
    | T14_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t4
    | T14_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t5
    | T14_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t6
    | T14_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t7
    | T14_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t8
    | T14_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t9
    | T14_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t10
    | T14_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t11
    | T14_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t12
    | T14_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>.op_Implicit t13
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13>) = 
    oneOf.Match(
      (fun t0 -> T14_0 t0),
      (fun t1 -> T14_1 t1),
      (fun t2 -> T14_2 t2),
      (fun t3 -> T14_3 t3),
      (fun t4 -> T14_4 t4),
      (fun t5 -> T14_5 t5),
      (fun t6 -> T14_6 t6),
      (fun t7 -> T14_7 t7),
      (fun t8 -> T14_8 t8),
      (fun t9 -> T14_9 t9),
      (fun t10 -> T14_10 t10),
      (fun t11 -> T14_11 t11),
      (fun t12 -> T14_12 t12),
      (fun t13 -> T14_13 t13)
    )

type FsOneOf15<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14> = 
  | T15_0 of 't0
  | T15_1 of 't1
  | T15_2 of 't2
  | T15_3 of 't3
  | T15_4 of 't4
  | T15_5 of 't5
  | T15_6 of 't6
  | T15_7 of 't7
  | T15_8 of 't8
  | T15_9 of 't9
  | T15_10 of 't10
  | T15_11 of 't11
  | T15_12 of 't12
  | T15_13 of 't13
  | T15_14 of 't14
  member self.toOneOf =
    match self with
    | T15_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t0
    | T15_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t1
    | T15_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t2
    | T15_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t3
    | T15_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t4
    | T15_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t5
    | T15_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t6
    | T15_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t7
    | T15_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t8
    | T15_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t9
    | T15_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t10
    | T15_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t11
    | T15_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t12
    | T15_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t13
    | T15_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>.op_Implicit t14
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14>) = 
    oneOf.Match(
      (fun t0 -> T15_0 t0),
      (fun t1 -> T15_1 t1),
      (fun t2 -> T15_2 t2),
      (fun t3 -> T15_3 t3),
      (fun t4 -> T15_4 t4),
      (fun t5 -> T15_5 t5),
      (fun t6 -> T15_6 t6),
      (fun t7 -> T15_7 t7),
      (fun t8 -> T15_8 t8),
      (fun t9 -> T15_9 t9),
      (fun t10 -> T15_10 t10),
      (fun t11 -> T15_11 t11),
      (fun t12 -> T15_12 t12),
      (fun t13 -> T15_13 t13),
      (fun t14 -> T15_14 t14)
    )

type FsOneOf16<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15> = 
  | T16_0 of 't0
  | T16_1 of 't1
  | T16_2 of 't2
  | T16_3 of 't3
  | T16_4 of 't4
  | T16_5 of 't5
  | T16_6 of 't6
  | T16_7 of 't7
  | T16_8 of 't8
  | T16_9 of 't9
  | T16_10 of 't10
  | T16_11 of 't11
  | T16_12 of 't12
  | T16_13 of 't13
  | T16_14 of 't14
  | T16_15 of 't15
  member self.toOneOf =
    match self with
    | T16_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t0
    | T16_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t1
    | T16_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t2
    | T16_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t3
    | T16_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t4
    | T16_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t5
    | T16_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t6
    | T16_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t7
    | T16_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t8
    | T16_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t9
    | T16_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t10
    | T16_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t11
    | T16_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t12
    | T16_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t13
    | T16_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t14
    | T16_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>.op_Implicit t15
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15>) = 
    oneOf.Match(
      (fun t0 -> T16_0 t0),
      (fun t1 -> T16_1 t1),
      (fun t2 -> T16_2 t2),
      (fun t3 -> T16_3 t3),
      (fun t4 -> T16_4 t4),
      (fun t5 -> T16_5 t5),
      (fun t6 -> T16_6 t6),
      (fun t7 -> T16_7 t7),
      (fun t8 -> T16_8 t8),
      (fun t9 -> T16_9 t9),
      (fun t10 -> T16_10 t10),
      (fun t11 -> T16_11 t11),
      (fun t12 -> T16_12 t12),
      (fun t13 -> T16_13 t13),
      (fun t14 -> T16_14 t14),
      (fun t15 -> T16_15 t15)
    )

type FsOneOf17<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16> = 
  | T17_0 of 't0
  | T17_1 of 't1
  | T17_2 of 't2
  | T17_3 of 't3
  | T17_4 of 't4
  | T17_5 of 't5
  | T17_6 of 't6
  | T17_7 of 't7
  | T17_8 of 't8
  | T17_9 of 't9
  | T17_10 of 't10
  | T17_11 of 't11
  | T17_12 of 't12
  | T17_13 of 't13
  | T17_14 of 't14
  | T17_15 of 't15
  | T17_16 of 't16
  member self.toOneOf =
    match self with
    | T17_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t0
    | T17_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t1
    | T17_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t2
    | T17_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t3
    | T17_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t4
    | T17_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t5
    | T17_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t6
    | T17_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t7
    | T17_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t8
    | T17_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t9
    | T17_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t10
    | T17_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t11
    | T17_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t12
    | T17_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t13
    | T17_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t14
    | T17_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t15
    | T17_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>.op_Implicit t16
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16>) = 
    oneOf.Match(
      (fun t0 -> T17_0 t0),
      (fun t1 -> T17_1 t1),
      (fun t2 -> T17_2 t2),
      (fun t3 -> T17_3 t3),
      (fun t4 -> T17_4 t4),
      (fun t5 -> T17_5 t5),
      (fun t6 -> T17_6 t6),
      (fun t7 -> T17_7 t7),
      (fun t8 -> T17_8 t8),
      (fun t9 -> T17_9 t9),
      (fun t10 -> T17_10 t10),
      (fun t11 -> T17_11 t11),
      (fun t12 -> T17_12 t12),
      (fun t13 -> T17_13 t13),
      (fun t14 -> T17_14 t14),
      (fun t15 -> T17_15 t15),
      (fun t16 -> T17_16 t16)
    )

type FsOneOf18<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17> = 
  | T18_0 of 't0
  | T18_1 of 't1
  | T18_2 of 't2
  | T18_3 of 't3
  | T18_4 of 't4
  | T18_5 of 't5
  | T18_6 of 't6
  | T18_7 of 't7
  | T18_8 of 't8
  | T18_9 of 't9
  | T18_10 of 't10
  | T18_11 of 't11
  | T18_12 of 't12
  | T18_13 of 't13
  | T18_14 of 't14
  | T18_15 of 't15
  | T18_16 of 't16
  | T18_17 of 't17
  member self.toOneOf =
    match self with
    | T18_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t0
    | T18_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t1
    | T18_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t2
    | T18_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t3
    | T18_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t4
    | T18_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t5
    | T18_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t6
    | T18_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t7
    | T18_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t8
    | T18_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t9
    | T18_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t10
    | T18_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t11
    | T18_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t12
    | T18_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t13
    | T18_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t14
    | T18_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t15
    | T18_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t16
    | T18_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>.op_Implicit t17
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17>) = 
    oneOf.Match(
      (fun t0 -> T18_0 t0),
      (fun t1 -> T18_1 t1),
      (fun t2 -> T18_2 t2),
      (fun t3 -> T18_3 t3),
      (fun t4 -> T18_4 t4),
      (fun t5 -> T18_5 t5),
      (fun t6 -> T18_6 t6),
      (fun t7 -> T18_7 t7),
      (fun t8 -> T18_8 t8),
      (fun t9 -> T18_9 t9),
      (fun t10 -> T18_10 t10),
      (fun t11 -> T18_11 t11),
      (fun t12 -> T18_12 t12),
      (fun t13 -> T18_13 t13),
      (fun t14 -> T18_14 t14),
      (fun t15 -> T18_15 t15),
      (fun t16 -> T18_16 t16),
      (fun t17 -> T18_17 t17)
    )

type FsOneOf19<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18> = 
  | T19_0 of 't0
  | T19_1 of 't1
  | T19_2 of 't2
  | T19_3 of 't3
  | T19_4 of 't4
  | T19_5 of 't5
  | T19_6 of 't6
  | T19_7 of 't7
  | T19_8 of 't8
  | T19_9 of 't9
  | T19_10 of 't10
  | T19_11 of 't11
  | T19_12 of 't12
  | T19_13 of 't13
  | T19_14 of 't14
  | T19_15 of 't15
  | T19_16 of 't16
  | T19_17 of 't17
  | T19_18 of 't18
  member self.toOneOf =
    match self with
    | T19_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t0
    | T19_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t1
    | T19_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t2
    | T19_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t3
    | T19_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t4
    | T19_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t5
    | T19_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t6
    | T19_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t7
    | T19_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t8
    | T19_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t9
    | T19_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t10
    | T19_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t11
    | T19_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t12
    | T19_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t13
    | T19_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t14
    | T19_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t15
    | T19_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t16
    | T19_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t17
    | T19_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>.op_Implicit t18
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18>) = 
    oneOf.Match(
      (fun t0 -> T19_0 t0),
      (fun t1 -> T19_1 t1),
      (fun t2 -> T19_2 t2),
      (fun t3 -> T19_3 t3),
      (fun t4 -> T19_4 t4),
      (fun t5 -> T19_5 t5),
      (fun t6 -> T19_6 t6),
      (fun t7 -> T19_7 t7),
      (fun t8 -> T19_8 t8),
      (fun t9 -> T19_9 t9),
      (fun t10 -> T19_10 t10),
      (fun t11 -> T19_11 t11),
      (fun t12 -> T19_12 t12),
      (fun t13 -> T19_13 t13),
      (fun t14 -> T19_14 t14),
      (fun t15 -> T19_15 t15),
      (fun t16 -> T19_16 t16),
      (fun t17 -> T19_17 t17),
      (fun t18 -> T19_18 t18)
    )

type FsOneOf20<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19> = 
  | T20_0 of 't0
  | T20_1 of 't1
  | T20_2 of 't2
  | T20_3 of 't3
  | T20_4 of 't4
  | T20_5 of 't5
  | T20_6 of 't6
  | T20_7 of 't7
  | T20_8 of 't8
  | T20_9 of 't9
  | T20_10 of 't10
  | T20_11 of 't11
  | T20_12 of 't12
  | T20_13 of 't13
  | T20_14 of 't14
  | T20_15 of 't15
  | T20_16 of 't16
  | T20_17 of 't17
  | T20_18 of 't18
  | T20_19 of 't19
  member self.toOneOf =
    match self with
    | T20_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t0
    | T20_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t1
    | T20_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t2
    | T20_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t3
    | T20_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t4
    | T20_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t5
    | T20_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t6
    | T20_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t7
    | T20_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t8
    | T20_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t9
    | T20_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t10
    | T20_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t11
    | T20_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t12
    | T20_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t13
    | T20_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t14
    | T20_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t15
    | T20_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t16
    | T20_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t17
    | T20_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t18
    | T20_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>.op_Implicit t19
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19>) = 
    oneOf.Match(
      (fun t0 -> T20_0 t0),
      (fun t1 -> T20_1 t1),
      (fun t2 -> T20_2 t2),
      (fun t3 -> T20_3 t3),
      (fun t4 -> T20_4 t4),
      (fun t5 -> T20_5 t5),
      (fun t6 -> T20_6 t6),
      (fun t7 -> T20_7 t7),
      (fun t8 -> T20_8 t8),
      (fun t9 -> T20_9 t9),
      (fun t10 -> T20_10 t10),
      (fun t11 -> T20_11 t11),
      (fun t12 -> T20_12 t12),
      (fun t13 -> T20_13 t13),
      (fun t14 -> T20_14 t14),
      (fun t15 -> T20_15 t15),
      (fun t16 -> T20_16 t16),
      (fun t17 -> T20_17 t17),
      (fun t18 -> T20_18 t18),
      (fun t19 -> T20_19 t19)
    )

type FsOneOf21<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20> = 
  | T21_0 of 't0
  | T21_1 of 't1
  | T21_2 of 't2
  | T21_3 of 't3
  | T21_4 of 't4
  | T21_5 of 't5
  | T21_6 of 't6
  | T21_7 of 't7
  | T21_8 of 't8
  | T21_9 of 't9
  | T21_10 of 't10
  | T21_11 of 't11
  | T21_12 of 't12
  | T21_13 of 't13
  | T21_14 of 't14
  | T21_15 of 't15
  | T21_16 of 't16
  | T21_17 of 't17
  | T21_18 of 't18
  | T21_19 of 't19
  | T21_20 of 't20
  member self.toOneOf =
    match self with
    | T21_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t0
    | T21_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t1
    | T21_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t2
    | T21_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t3
    | T21_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t4
    | T21_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t5
    | T21_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t6
    | T21_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t7
    | T21_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t8
    | T21_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t9
    | T21_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t10
    | T21_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t11
    | T21_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t12
    | T21_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t13
    | T21_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t14
    | T21_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t15
    | T21_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t16
    | T21_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t17
    | T21_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t18
    | T21_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t19
    | T21_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>.op_Implicit t20
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20>) = 
    oneOf.Match(
      (fun t0 -> T21_0 t0),
      (fun t1 -> T21_1 t1),
      (fun t2 -> T21_2 t2),
      (fun t3 -> T21_3 t3),
      (fun t4 -> T21_4 t4),
      (fun t5 -> T21_5 t5),
      (fun t6 -> T21_6 t6),
      (fun t7 -> T21_7 t7),
      (fun t8 -> T21_8 t8),
      (fun t9 -> T21_9 t9),
      (fun t10 -> T21_10 t10),
      (fun t11 -> T21_11 t11),
      (fun t12 -> T21_12 t12),
      (fun t13 -> T21_13 t13),
      (fun t14 -> T21_14 t14),
      (fun t15 -> T21_15 t15),
      (fun t16 -> T21_16 t16),
      (fun t17 -> T21_17 t17),
      (fun t18 -> T21_18 t18),
      (fun t19 -> T21_19 t19),
      (fun t20 -> T21_20 t20)
    )

type FsOneOf22<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21> = 
  | T22_0 of 't0
  | T22_1 of 't1
  | T22_2 of 't2
  | T22_3 of 't3
  | T22_4 of 't4
  | T22_5 of 't5
  | T22_6 of 't6
  | T22_7 of 't7
  | T22_8 of 't8
  | T22_9 of 't9
  | T22_10 of 't10
  | T22_11 of 't11
  | T22_12 of 't12
  | T22_13 of 't13
  | T22_14 of 't14
  | T22_15 of 't15
  | T22_16 of 't16
  | T22_17 of 't17
  | T22_18 of 't18
  | T22_19 of 't19
  | T22_20 of 't20
  | T22_21 of 't21
  member self.toOneOf =
    match self with
    | T22_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t0
    | T22_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t1
    | T22_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t2
    | T22_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t3
    | T22_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t4
    | T22_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t5
    | T22_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t6
    | T22_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t7
    | T22_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t8
    | T22_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t9
    | T22_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t10
    | T22_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t11
    | T22_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t12
    | T22_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t13
    | T22_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t14
    | T22_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t15
    | T22_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t16
    | T22_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t17
    | T22_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t18
    | T22_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t19
    | T22_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t20
    | T22_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>.op_Implicit t21
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21>) = 
    oneOf.Match(
      (fun t0 -> T22_0 t0),
      (fun t1 -> T22_1 t1),
      (fun t2 -> T22_2 t2),
      (fun t3 -> T22_3 t3),
      (fun t4 -> T22_4 t4),
      (fun t5 -> T22_5 t5),
      (fun t6 -> T22_6 t6),
      (fun t7 -> T22_7 t7),
      (fun t8 -> T22_8 t8),
      (fun t9 -> T22_9 t9),
      (fun t10 -> T22_10 t10),
      (fun t11 -> T22_11 t11),
      (fun t12 -> T22_12 t12),
      (fun t13 -> T22_13 t13),
      (fun t14 -> T22_14 t14),
      (fun t15 -> T22_15 t15),
      (fun t16 -> T22_16 t16),
      (fun t17 -> T22_17 t17),
      (fun t18 -> T22_18 t18),
      (fun t19 -> T22_19 t19),
      (fun t20 -> T22_20 t20),
      (fun t21 -> T22_21 t21)
    )

type FsOneOf23<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22> = 
  | T23_0 of 't0
  | T23_1 of 't1
  | T23_2 of 't2
  | T23_3 of 't3
  | T23_4 of 't4
  | T23_5 of 't5
  | T23_6 of 't6
  | T23_7 of 't7
  | T23_8 of 't8
  | T23_9 of 't9
  | T23_10 of 't10
  | T23_11 of 't11
  | T23_12 of 't12
  | T23_13 of 't13
  | T23_14 of 't14
  | T23_15 of 't15
  | T23_16 of 't16
  | T23_17 of 't17
  | T23_18 of 't18
  | T23_19 of 't19
  | T23_20 of 't20
  | T23_21 of 't21
  | T23_22 of 't22
  member self.toOneOf =
    match self with
    | T23_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t0
    | T23_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t1
    | T23_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t2
    | T23_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t3
    | T23_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t4
    | T23_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t5
    | T23_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t6
    | T23_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t7
    | T23_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t8
    | T23_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t9
    | T23_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t10
    | T23_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t11
    | T23_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t12
    | T23_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t13
    | T23_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t14
    | T23_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t15
    | T23_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t16
    | T23_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t17
    | T23_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t18
    | T23_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t19
    | T23_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t20
    | T23_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t21
    | T23_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>.op_Implicit t22
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22>) = 
    oneOf.Match(
      (fun t0 -> T23_0 t0),
      (fun t1 -> T23_1 t1),
      (fun t2 -> T23_2 t2),
      (fun t3 -> T23_3 t3),
      (fun t4 -> T23_4 t4),
      (fun t5 -> T23_5 t5),
      (fun t6 -> T23_6 t6),
      (fun t7 -> T23_7 t7),
      (fun t8 -> T23_8 t8),
      (fun t9 -> T23_9 t9),
      (fun t10 -> T23_10 t10),
      (fun t11 -> T23_11 t11),
      (fun t12 -> T23_12 t12),
      (fun t13 -> T23_13 t13),
      (fun t14 -> T23_14 t14),
      (fun t15 -> T23_15 t15),
      (fun t16 -> T23_16 t16),
      (fun t17 -> T23_17 t17),
      (fun t18 -> T23_18 t18),
      (fun t19 -> T23_19 t19),
      (fun t20 -> T23_20 t20),
      (fun t21 -> T23_21 t21),
      (fun t22 -> T23_22 t22)
    )

type FsOneOf24<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23> = 
  | T24_0 of 't0
  | T24_1 of 't1
  | T24_2 of 't2
  | T24_3 of 't3
  | T24_4 of 't4
  | T24_5 of 't5
  | T24_6 of 't6
  | T24_7 of 't7
  | T24_8 of 't8
  | T24_9 of 't9
  | T24_10 of 't10
  | T24_11 of 't11
  | T24_12 of 't12
  | T24_13 of 't13
  | T24_14 of 't14
  | T24_15 of 't15
  | T24_16 of 't16
  | T24_17 of 't17
  | T24_18 of 't18
  | T24_19 of 't19
  | T24_20 of 't20
  | T24_21 of 't21
  | T24_22 of 't22
  | T24_23 of 't23
  member self.toOneOf =
    match self with
    | T24_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t0
    | T24_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t1
    | T24_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t2
    | T24_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t3
    | T24_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t4
    | T24_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t5
    | T24_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t6
    | T24_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t7
    | T24_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t8
    | T24_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t9
    | T24_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t10
    | T24_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t11
    | T24_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t12
    | T24_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t13
    | T24_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t14
    | T24_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t15
    | T24_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t16
    | T24_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t17
    | T24_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t18
    | T24_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t19
    | T24_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t20
    | T24_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t21
    | T24_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t22
    | T24_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>.op_Implicit t23
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23>) = 
    oneOf.Match(
      (fun t0 -> T24_0 t0),
      (fun t1 -> T24_1 t1),
      (fun t2 -> T24_2 t2),
      (fun t3 -> T24_3 t3),
      (fun t4 -> T24_4 t4),
      (fun t5 -> T24_5 t5),
      (fun t6 -> T24_6 t6),
      (fun t7 -> T24_7 t7),
      (fun t8 -> T24_8 t8),
      (fun t9 -> T24_9 t9),
      (fun t10 -> T24_10 t10),
      (fun t11 -> T24_11 t11),
      (fun t12 -> T24_12 t12),
      (fun t13 -> T24_13 t13),
      (fun t14 -> T24_14 t14),
      (fun t15 -> T24_15 t15),
      (fun t16 -> T24_16 t16),
      (fun t17 -> T24_17 t17),
      (fun t18 -> T24_18 t18),
      (fun t19 -> T24_19 t19),
      (fun t20 -> T24_20 t20),
      (fun t21 -> T24_21 t21),
      (fun t22 -> T24_22 t22),
      (fun t23 -> T24_23 t23)
    )

type FsOneOf25<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24> = 
  | T25_0 of 't0
  | T25_1 of 't1
  | T25_2 of 't2
  | T25_3 of 't3
  | T25_4 of 't4
  | T25_5 of 't5
  | T25_6 of 't6
  | T25_7 of 't7
  | T25_8 of 't8
  | T25_9 of 't9
  | T25_10 of 't10
  | T25_11 of 't11
  | T25_12 of 't12
  | T25_13 of 't13
  | T25_14 of 't14
  | T25_15 of 't15
  | T25_16 of 't16
  | T25_17 of 't17
  | T25_18 of 't18
  | T25_19 of 't19
  | T25_20 of 't20
  | T25_21 of 't21
  | T25_22 of 't22
  | T25_23 of 't23
  | T25_24 of 't24
  member self.toOneOf =
    match self with
    | T25_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t0
    | T25_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t1
    | T25_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t2
    | T25_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t3
    | T25_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t4
    | T25_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t5
    | T25_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t6
    | T25_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t7
    | T25_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t8
    | T25_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t9
    | T25_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t10
    | T25_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t11
    | T25_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t12
    | T25_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t13
    | T25_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t14
    | T25_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t15
    | T25_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t16
    | T25_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t17
    | T25_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t18
    | T25_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t19
    | T25_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t20
    | T25_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t21
    | T25_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t22
    | T25_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t23
    | T25_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>.op_Implicit t24
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24>) = 
    oneOf.Match(
      (fun t0 -> T25_0 t0),
      (fun t1 -> T25_1 t1),
      (fun t2 -> T25_2 t2),
      (fun t3 -> T25_3 t3),
      (fun t4 -> T25_4 t4),
      (fun t5 -> T25_5 t5),
      (fun t6 -> T25_6 t6),
      (fun t7 -> T25_7 t7),
      (fun t8 -> T25_8 t8),
      (fun t9 -> T25_9 t9),
      (fun t10 -> T25_10 t10),
      (fun t11 -> T25_11 t11),
      (fun t12 -> T25_12 t12),
      (fun t13 -> T25_13 t13),
      (fun t14 -> T25_14 t14),
      (fun t15 -> T25_15 t15),
      (fun t16 -> T25_16 t16),
      (fun t17 -> T25_17 t17),
      (fun t18 -> T25_18 t18),
      (fun t19 -> T25_19 t19),
      (fun t20 -> T25_20 t20),
      (fun t21 -> T25_21 t21),
      (fun t22 -> T25_22 t22),
      (fun t23 -> T25_23 t23),
      (fun t24 -> T25_24 t24)
    )

type FsOneOf26<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25> = 
  | T26_0 of 't0
  | T26_1 of 't1
  | T26_2 of 't2
  | T26_3 of 't3
  | T26_4 of 't4
  | T26_5 of 't5
  | T26_6 of 't6
  | T26_7 of 't7
  | T26_8 of 't8
  | T26_9 of 't9
  | T26_10 of 't10
  | T26_11 of 't11
  | T26_12 of 't12
  | T26_13 of 't13
  | T26_14 of 't14
  | T26_15 of 't15
  | T26_16 of 't16
  | T26_17 of 't17
  | T26_18 of 't18
  | T26_19 of 't19
  | T26_20 of 't20
  | T26_21 of 't21
  | T26_22 of 't22
  | T26_23 of 't23
  | T26_24 of 't24
  | T26_25 of 't25
  member self.toOneOf =
    match self with
    | T26_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t0
    | T26_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t1
    | T26_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t2
    | T26_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t3
    | T26_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t4
    | T26_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t5
    | T26_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t6
    | T26_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t7
    | T26_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t8
    | T26_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t9
    | T26_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t10
    | T26_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t11
    | T26_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t12
    | T26_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t13
    | T26_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t14
    | T26_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t15
    | T26_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t16
    | T26_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t17
    | T26_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t18
    | T26_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t19
    | T26_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t20
    | T26_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t21
    | T26_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t22
    | T26_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t23
    | T26_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t24
    | T26_25 t25 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>.op_Implicit t25
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25>) = 
    oneOf.Match(
      (fun t0 -> T26_0 t0),
      (fun t1 -> T26_1 t1),
      (fun t2 -> T26_2 t2),
      (fun t3 -> T26_3 t3),
      (fun t4 -> T26_4 t4),
      (fun t5 -> T26_5 t5),
      (fun t6 -> T26_6 t6),
      (fun t7 -> T26_7 t7),
      (fun t8 -> T26_8 t8),
      (fun t9 -> T26_9 t9),
      (fun t10 -> T26_10 t10),
      (fun t11 -> T26_11 t11),
      (fun t12 -> T26_12 t12),
      (fun t13 -> T26_13 t13),
      (fun t14 -> T26_14 t14),
      (fun t15 -> T26_15 t15),
      (fun t16 -> T26_16 t16),
      (fun t17 -> T26_17 t17),
      (fun t18 -> T26_18 t18),
      (fun t19 -> T26_19 t19),
      (fun t20 -> T26_20 t20),
      (fun t21 -> T26_21 t21),
      (fun t22 -> T26_22 t22),
      (fun t23 -> T26_23 t23),
      (fun t24 -> T26_24 t24),
      (fun t25 -> T26_25 t25)
    )

type FsOneOf27<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26> = 
  | T27_0 of 't0
  | T27_1 of 't1
  | T27_2 of 't2
  | T27_3 of 't3
  | T27_4 of 't4
  | T27_5 of 't5
  | T27_6 of 't6
  | T27_7 of 't7
  | T27_8 of 't8
  | T27_9 of 't9
  | T27_10 of 't10
  | T27_11 of 't11
  | T27_12 of 't12
  | T27_13 of 't13
  | T27_14 of 't14
  | T27_15 of 't15
  | T27_16 of 't16
  | T27_17 of 't17
  | T27_18 of 't18
  | T27_19 of 't19
  | T27_20 of 't20
  | T27_21 of 't21
  | T27_22 of 't22
  | T27_23 of 't23
  | T27_24 of 't24
  | T27_25 of 't25
  | T27_26 of 't26
  member self.toOneOf =
    match self with
    | T27_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t0
    | T27_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t1
    | T27_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t2
    | T27_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t3
    | T27_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t4
    | T27_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t5
    | T27_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t6
    | T27_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t7
    | T27_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t8
    | T27_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t9
    | T27_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t10
    | T27_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t11
    | T27_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t12
    | T27_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t13
    | T27_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t14
    | T27_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t15
    | T27_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t16
    | T27_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t17
    | T27_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t18
    | T27_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t19
    | T27_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t20
    | T27_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t21
    | T27_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t22
    | T27_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t23
    | T27_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t24
    | T27_25 t25 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t25
    | T27_26 t26 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>.op_Implicit t26
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26>) = 
    oneOf.Match(
      (fun t0 -> T27_0 t0),
      (fun t1 -> T27_1 t1),
      (fun t2 -> T27_2 t2),
      (fun t3 -> T27_3 t3),
      (fun t4 -> T27_4 t4),
      (fun t5 -> T27_5 t5),
      (fun t6 -> T27_6 t6),
      (fun t7 -> T27_7 t7),
      (fun t8 -> T27_8 t8),
      (fun t9 -> T27_9 t9),
      (fun t10 -> T27_10 t10),
      (fun t11 -> T27_11 t11),
      (fun t12 -> T27_12 t12),
      (fun t13 -> T27_13 t13),
      (fun t14 -> T27_14 t14),
      (fun t15 -> T27_15 t15),
      (fun t16 -> T27_16 t16),
      (fun t17 -> T27_17 t17),
      (fun t18 -> T27_18 t18),
      (fun t19 -> T27_19 t19),
      (fun t20 -> T27_20 t20),
      (fun t21 -> T27_21 t21),
      (fun t22 -> T27_22 t22),
      (fun t23 -> T27_23 t23),
      (fun t24 -> T27_24 t24),
      (fun t25 -> T27_25 t25),
      (fun t26 -> T27_26 t26)
    )

type FsOneOf28<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27> = 
  | T28_0 of 't0
  | T28_1 of 't1
  | T28_2 of 't2
  | T28_3 of 't3
  | T28_4 of 't4
  | T28_5 of 't5
  | T28_6 of 't6
  | T28_7 of 't7
  | T28_8 of 't8
  | T28_9 of 't9
  | T28_10 of 't10
  | T28_11 of 't11
  | T28_12 of 't12
  | T28_13 of 't13
  | T28_14 of 't14
  | T28_15 of 't15
  | T28_16 of 't16
  | T28_17 of 't17
  | T28_18 of 't18
  | T28_19 of 't19
  | T28_20 of 't20
  | T28_21 of 't21
  | T28_22 of 't22
  | T28_23 of 't23
  | T28_24 of 't24
  | T28_25 of 't25
  | T28_26 of 't26
  | T28_27 of 't27
  member self.toOneOf =
    match self with
    | T28_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t0
    | T28_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t1
    | T28_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t2
    | T28_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t3
    | T28_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t4
    | T28_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t5
    | T28_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t6
    | T28_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t7
    | T28_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t8
    | T28_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t9
    | T28_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t10
    | T28_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t11
    | T28_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t12
    | T28_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t13
    | T28_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t14
    | T28_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t15
    | T28_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t16
    | T28_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t17
    | T28_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t18
    | T28_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t19
    | T28_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t20
    | T28_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t21
    | T28_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t22
    | T28_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t23
    | T28_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t24
    | T28_25 t25 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t25
    | T28_26 t26 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t26
    | T28_27 t27 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>.op_Implicit t27
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27>) = 
    oneOf.Match(
      (fun t0 -> T28_0 t0),
      (fun t1 -> T28_1 t1),
      (fun t2 -> T28_2 t2),
      (fun t3 -> T28_3 t3),
      (fun t4 -> T28_4 t4),
      (fun t5 -> T28_5 t5),
      (fun t6 -> T28_6 t6),
      (fun t7 -> T28_7 t7),
      (fun t8 -> T28_8 t8),
      (fun t9 -> T28_9 t9),
      (fun t10 -> T28_10 t10),
      (fun t11 -> T28_11 t11),
      (fun t12 -> T28_12 t12),
      (fun t13 -> T28_13 t13),
      (fun t14 -> T28_14 t14),
      (fun t15 -> T28_15 t15),
      (fun t16 -> T28_16 t16),
      (fun t17 -> T28_17 t17),
      (fun t18 -> T28_18 t18),
      (fun t19 -> T28_19 t19),
      (fun t20 -> T28_20 t20),
      (fun t21 -> T28_21 t21),
      (fun t22 -> T28_22 t22),
      (fun t23 -> T28_23 t23),
      (fun t24 -> T28_24 t24),
      (fun t25 -> T28_25 t25),
      (fun t26 -> T28_26 t26),
      (fun t27 -> T28_27 t27)
    )

type FsOneOf29<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28> = 
  | T29_0 of 't0
  | T29_1 of 't1
  | T29_2 of 't2
  | T29_3 of 't3
  | T29_4 of 't4
  | T29_5 of 't5
  | T29_6 of 't6
  | T29_7 of 't7
  | T29_8 of 't8
  | T29_9 of 't9
  | T29_10 of 't10
  | T29_11 of 't11
  | T29_12 of 't12
  | T29_13 of 't13
  | T29_14 of 't14
  | T29_15 of 't15
  | T29_16 of 't16
  | T29_17 of 't17
  | T29_18 of 't18
  | T29_19 of 't19
  | T29_20 of 't20
  | T29_21 of 't21
  | T29_22 of 't22
  | T29_23 of 't23
  | T29_24 of 't24
  | T29_25 of 't25
  | T29_26 of 't26
  | T29_27 of 't27
  | T29_28 of 't28
  member self.toOneOf =
    match self with
    | T29_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t0
    | T29_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t1
    | T29_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t2
    | T29_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t3
    | T29_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t4
    | T29_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t5
    | T29_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t6
    | T29_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t7
    | T29_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t8
    | T29_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t9
    | T29_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t10
    | T29_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t11
    | T29_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t12
    | T29_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t13
    | T29_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t14
    | T29_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t15
    | T29_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t16
    | T29_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t17
    | T29_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t18
    | T29_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t19
    | T29_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t20
    | T29_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t21
    | T29_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t22
    | T29_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t23
    | T29_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t24
    | T29_25 t25 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t25
    | T29_26 t26 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t26
    | T29_27 t27 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t27
    | T29_28 t28 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>.op_Implicit t28
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28>) = 
    oneOf.Match(
      (fun t0 -> T29_0 t0),
      (fun t1 -> T29_1 t1),
      (fun t2 -> T29_2 t2),
      (fun t3 -> T29_3 t3),
      (fun t4 -> T29_4 t4),
      (fun t5 -> T29_5 t5),
      (fun t6 -> T29_6 t6),
      (fun t7 -> T29_7 t7),
      (fun t8 -> T29_8 t8),
      (fun t9 -> T29_9 t9),
      (fun t10 -> T29_10 t10),
      (fun t11 -> T29_11 t11),
      (fun t12 -> T29_12 t12),
      (fun t13 -> T29_13 t13),
      (fun t14 -> T29_14 t14),
      (fun t15 -> T29_15 t15),
      (fun t16 -> T29_16 t16),
      (fun t17 -> T29_17 t17),
      (fun t18 -> T29_18 t18),
      (fun t19 -> T29_19 t19),
      (fun t20 -> T29_20 t20),
      (fun t21 -> T29_21 t21),
      (fun t22 -> T29_22 t22),
      (fun t23 -> T29_23 t23),
      (fun t24 -> T29_24 t24),
      (fun t25 -> T29_25 t25),
      (fun t26 -> T29_26 t26),
      (fun t27 -> T29_27 t27),
      (fun t28 -> T29_28 t28)
    )

type FsOneOf30<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29> = 
  | T30_0 of 't0
  | T30_1 of 't1
  | T30_2 of 't2
  | T30_3 of 't3
  | T30_4 of 't4
  | T30_5 of 't5
  | T30_6 of 't6
  | T30_7 of 't7
  | T30_8 of 't8
  | T30_9 of 't9
  | T30_10 of 't10
  | T30_11 of 't11
  | T30_12 of 't12
  | T30_13 of 't13
  | T30_14 of 't14
  | T30_15 of 't15
  | T30_16 of 't16
  | T30_17 of 't17
  | T30_18 of 't18
  | T30_19 of 't19
  | T30_20 of 't20
  | T30_21 of 't21
  | T30_22 of 't22
  | T30_23 of 't23
  | T30_24 of 't24
  | T30_25 of 't25
  | T30_26 of 't26
  | T30_27 of 't27
  | T30_28 of 't28
  | T30_29 of 't29
  member self.toOneOf =
    match self with
    | T30_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t0
    | T30_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t1
    | T30_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t2
    | T30_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t3
    | T30_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t4
    | T30_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t5
    | T30_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t6
    | T30_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t7
    | T30_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t8
    | T30_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t9
    | T30_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t10
    | T30_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t11
    | T30_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t12
    | T30_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t13
    | T30_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t14
    | T30_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t15
    | T30_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t16
    | T30_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t17
    | T30_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t18
    | T30_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t19
    | T30_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t20
    | T30_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t21
    | T30_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t22
    | T30_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t23
    | T30_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t24
    | T30_25 t25 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t25
    | T30_26 t26 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t26
    | T30_27 t27 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t27
    | T30_28 t28 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t28
    | T30_29 t29 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>.op_Implicit t29
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29>) = 
    oneOf.Match(
      (fun t0 -> T30_0 t0),
      (fun t1 -> T30_1 t1),
      (fun t2 -> T30_2 t2),
      (fun t3 -> T30_3 t3),
      (fun t4 -> T30_4 t4),
      (fun t5 -> T30_5 t5),
      (fun t6 -> T30_6 t6),
      (fun t7 -> T30_7 t7),
      (fun t8 -> T30_8 t8),
      (fun t9 -> T30_9 t9),
      (fun t10 -> T30_10 t10),
      (fun t11 -> T30_11 t11),
      (fun t12 -> T30_12 t12),
      (fun t13 -> T30_13 t13),
      (fun t14 -> T30_14 t14),
      (fun t15 -> T30_15 t15),
      (fun t16 -> T30_16 t16),
      (fun t17 -> T30_17 t17),
      (fun t18 -> T30_18 t18),
      (fun t19 -> T30_19 t19),
      (fun t20 -> T30_20 t20),
      (fun t21 -> T30_21 t21),
      (fun t22 -> T30_22 t22),
      (fun t23 -> T30_23 t23),
      (fun t24 -> T30_24 t24),
      (fun t25 -> T30_25 t25),
      (fun t26 -> T30_26 t26),
      (fun t27 -> T30_27 t27),
      (fun t28 -> T30_28 t28),
      (fun t29 -> T30_29 t29)
    )

type FsOneOf31<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30> = 
  | T31_0 of 't0
  | T31_1 of 't1
  | T31_2 of 't2
  | T31_3 of 't3
  | T31_4 of 't4
  | T31_5 of 't5
  | T31_6 of 't6
  | T31_7 of 't7
  | T31_8 of 't8
  | T31_9 of 't9
  | T31_10 of 't10
  | T31_11 of 't11
  | T31_12 of 't12
  | T31_13 of 't13
  | T31_14 of 't14
  | T31_15 of 't15
  | T31_16 of 't16
  | T31_17 of 't17
  | T31_18 of 't18
  | T31_19 of 't19
  | T31_20 of 't20
  | T31_21 of 't21
  | T31_22 of 't22
  | T31_23 of 't23
  | T31_24 of 't24
  | T31_25 of 't25
  | T31_26 of 't26
  | T31_27 of 't27
  | T31_28 of 't28
  | T31_29 of 't29
  | T31_30 of 't30
  member self.toOneOf =
    match self with
    | T31_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t0
    | T31_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t1
    | T31_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t2
    | T31_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t3
    | T31_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t4
    | T31_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t5
    | T31_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t6
    | T31_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t7
    | T31_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t8
    | T31_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t9
    | T31_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t10
    | T31_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t11
    | T31_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t12
    | T31_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t13
    | T31_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t14
    | T31_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t15
    | T31_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t16
    | T31_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t17
    | T31_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t18
    | T31_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t19
    | T31_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t20
    | T31_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t21
    | T31_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t22
    | T31_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t23
    | T31_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t24
    | T31_25 t25 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t25
    | T31_26 t26 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t26
    | T31_27 t27 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t27
    | T31_28 t28 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t28
    | T31_29 t29 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t29
    | T31_30 t30 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>.op_Implicit t30
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30>) = 
    oneOf.Match(
      (fun t0 -> T31_0 t0),
      (fun t1 -> T31_1 t1),
      (fun t2 -> T31_2 t2),
      (fun t3 -> T31_3 t3),
      (fun t4 -> T31_4 t4),
      (fun t5 -> T31_5 t5),
      (fun t6 -> T31_6 t6),
      (fun t7 -> T31_7 t7),
      (fun t8 -> T31_8 t8),
      (fun t9 -> T31_9 t9),
      (fun t10 -> T31_10 t10),
      (fun t11 -> T31_11 t11),
      (fun t12 -> T31_12 t12),
      (fun t13 -> T31_13 t13),
      (fun t14 -> T31_14 t14),
      (fun t15 -> T31_15 t15),
      (fun t16 -> T31_16 t16),
      (fun t17 -> T31_17 t17),
      (fun t18 -> T31_18 t18),
      (fun t19 -> T31_19 t19),
      (fun t20 -> T31_20 t20),
      (fun t21 -> T31_21 t21),
      (fun t22 -> T31_22 t22),
      (fun t23 -> T31_23 t23),
      (fun t24 -> T31_24 t24),
      (fun t25 -> T31_25 t25),
      (fun t26 -> T31_26 t26),
      (fun t27 -> T31_27 t27),
      (fun t28 -> T31_28 t28),
      (fun t29 -> T31_29 t29),
      (fun t30 -> T31_30 t30)
    )

type FsOneOf32<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31> = 
  | T32_0 of 't0
  | T32_1 of 't1
  | T32_2 of 't2
  | T32_3 of 't3
  | T32_4 of 't4
  | T32_5 of 't5
  | T32_6 of 't6
  | T32_7 of 't7
  | T32_8 of 't8
  | T32_9 of 't9
  | T32_10 of 't10
  | T32_11 of 't11
  | T32_12 of 't12
  | T32_13 of 't13
  | T32_14 of 't14
  | T32_15 of 't15
  | T32_16 of 't16
  | T32_17 of 't17
  | T32_18 of 't18
  | T32_19 of 't19
  | T32_20 of 't20
  | T32_21 of 't21
  | T32_22 of 't22
  | T32_23 of 't23
  | T32_24 of 't24
  | T32_25 of 't25
  | T32_26 of 't26
  | T32_27 of 't27
  | T32_28 of 't28
  | T32_29 of 't29
  | T32_30 of 't30
  | T32_31 of 't31
  member self.toOneOf =
    match self with
    | T32_0 t0 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t0
    | T32_1 t1 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t1
    | T32_2 t2 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t2
    | T32_3 t3 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t3
    | T32_4 t4 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t4
    | T32_5 t5 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t5
    | T32_6 t6 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t6
    | T32_7 t7 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t7
    | T32_8 t8 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t8
    | T32_9 t9 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t9
    | T32_10 t10 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t10
    | T32_11 t11 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t11
    | T32_12 t12 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t12
    | T32_13 t13 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t13
    | T32_14 t14 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t14
    | T32_15 t15 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t15
    | T32_16 t16 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t16
    | T32_17 t17 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t17
    | T32_18 t18 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t18
    | T32_19 t19 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t19
    | T32_20 t20 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t20
    | T32_21 t21 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t21
    | T32_22 t22 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t22
    | T32_23 t23 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t23
    | T32_24 t24 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t24
    | T32_25 t25 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t25
    | T32_26 t26 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t26
    | T32_27 t27 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t27
    | T32_28 t28 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t28
    | T32_29 t29 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t29
    | T32_30 t30 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t30
    | T32_31 t31 -> OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>.op_Implicit t31
  static member fromOneOf (oneOf: OneOf<'t0, 't1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20, 't21, 't22, 't23, 't24, 't25, 't26, 't27, 't28, 't29, 't30, 't31>) = 
    oneOf.Match(
      (fun t0 -> T32_0 t0),
      (fun t1 -> T32_1 t1),
      (fun t2 -> T32_2 t2),
      (fun t3 -> T32_3 t3),
      (fun t4 -> T32_4 t4),
      (fun t5 -> T32_5 t5),
      (fun t6 -> T32_6 t6),
      (fun t7 -> T32_7 t7),
      (fun t8 -> T32_8 t8),
      (fun t9 -> T32_9 t9),
      (fun t10 -> T32_10 t10),
      (fun t11 -> T32_11 t11),
      (fun t12 -> T32_12 t12),
      (fun t13 -> T32_13 t13),
      (fun t14 -> T32_14 t14),
      (fun t15 -> T32_15 t15),
      (fun t16 -> T32_16 t16),
      (fun t17 -> T32_17 t17),
      (fun t18 -> T32_18 t18),
      (fun t19 -> T32_19 t19),
      (fun t20 -> T32_20 t20),
      (fun t21 -> T32_21 t21),
      (fun t22 -> T32_22 t22),
      (fun t23 -> T32_23 t23),
      (fun t24 -> T32_24 t24),
      (fun t25 -> T32_25 t25),
      (fun t26 -> T32_26 t26),
      (fun t27 -> T32_27 t27),
      (fun t28 -> T32_28 t28),
      (fun t29 -> T32_29 t29),
      (fun t30 -> T32_30 t30),
      (fun t31 -> T32_31 t31)
    )

