namespace Types

[<Struct>]
type Battery =
    { current : int64
      cap     : int64 }

[<Struct>]
type Energy =
    { current : int64
      needed  : int64 }

[<Struct>]
type Electricity =
    { battery : Battery
      energy  : Energy }

[<Struct>]
type Matter =
    { current : int64
      needed  : int64 }

[<Struct>]
type Humans =
    { current : int64
      cap     : int64 }

[<Struct>]
type Drones =
    { current : int64
      cap     : int64 }

[<Struct>]
type Day =
    { count    : int64
      gametick : int64 }

[<Struct>]
type Money =
  { amount : int64
    earnings : int64 }

[<Struct>]
type State =
    { credits     : Money
      matter      : Matter
      electricity : Electricity
      humans      : Humans
      drones      : Drones
      day         : Day }


[<Struct>]
type Upkeep =
  { energy : int64
    matter : int64 }

[<Struct>]
type Provides =
  { energy  : int64
    battery : int64
    matter  : int64
    credits : int64
    space   : int64
    drones  : int64 }

[<Struct>]
type Cost =
  { matter  : int64
    energy  : int64
    upkeep  : Upkeep
    time    : int64
    credits : int64 }

[<Struct>]
type Utility =
  { cost : Cost
    provides : Provides }