namespace Types

[<Struct>]
type Battery =
    { current : double
      cap     : double }

[<Struct>]
type Energy =
    { current : double
      needed  : double }

[<Struct>]
type Electricity =
    { battery : Battery
      energy  : Energy }

[<Struct>]
type Matter =
    { current : double
      needed  : double }

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
  { amount   : double
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
  { energy : double
    matter : double }

[<Struct>]
type Provides =
  { energy  : double
    battery : double
    matter  : double
    credits : int64
    space   : int64
    drones  : int64 }

[<Struct>]
type Cost =
  { matter  : double
    energy  : double
    upkeep  : Upkeep
    time    : int64
    credits : int64 }

[<Struct>]
type Utility =
  { cost : Cost
    provides : Provides }

[<Struct>]
type Engine =
  { elapsed        : int64
    power_obtained : double
    power_consumed : double
    battery_cap    : double
    matter         : double
    matter_change  : double }