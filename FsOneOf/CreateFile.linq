<Query Kind="FSharpProgram" />

let getGenericArguments index = [for i in 0 .. index -> sprintf "'t%i%s" i (if i = index then "" else ", ")] |> String.concat ""
    
let className index = sprintf "type FsOneOf%i<%s> = %s" (index + 1) (getGenericArguments index) Environment.NewLine
    
let getCases index = [for i in 0 .. index -> sprintf "  | T%i_%i of 't%i%s" (index + 1) i i Environment.NewLine] |> String.concat ""
    
let toOneOfDecl = sprintf "  member self.toOneOf =%s    match self with%s" Environment.NewLine Environment.NewLine
    
let getToOneOfCase oneOfIndex caseIndex = sprintf "    | T%i_%i t%i -> OneOf<%s>.op_Implicit t%i%s" (oneOfIndex + 1) caseIndex caseIndex (getGenericArguments oneOfIndex) caseIndex Environment.NewLine
    
let getToOneOfCases index = [for i in 0 .. index -> getToOneOfCase index i] |> String.concat ""
    
let fromOneOfDecl index = sprintf "  static member fromOneOf (oneOf: OneOf<%s>) = %s" (getGenericArguments index) Environment.NewLine
    
let getFromOneOfCase index oneOfIndex printComma = sprintf "      (fun t%i -> T%i_%i t%i)%s%s" index (oneOfIndex + 1) index index (if printComma then "," else "") Environment.NewLine
    
let getFromOneOfCases index = sprintf "    oneOf.Match(%s%s    )" Environment.NewLine ([for i in 0 .. index -> getFromOneOfCase i index (i <> index)] |> String.concat "")
    
let getFromOneOf index = sprintf "%s%s" (fromOneOfDecl index) (getFromOneOfCases index)
    
let getToOneOf index = sprintf "%s%s" toOneOfDecl (getToOneOfCases index)
    
let getType index = 
    let typeDeclaration = className index
    let cases = getCases index
    let toOneOf = getToOneOf index
    let fromOneOf = getFromOneOf index
    sprintf "%s%s%s%s%s%s" typeDeclaration cases toOneOf fromOneOf Environment.NewLine Environment.NewLine
    
let getContent =     
    let fileIntro = @"module FsOneOf

open OneOf
"
    let results = List.Cons(fileIntro, [for i in 0 .. 31 -> getType i])
    String.concat "" results

let main =
    let output = getContent
    let outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "FsOneOf.fs");
    File.WriteAllText(outpath, output);
    0