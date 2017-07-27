namespace WarnAsError

open System

type WarnAsError() = 
    [<Obsolete>]
    member this.X = "F#"

    member this.Y = this.X + "asdf"
