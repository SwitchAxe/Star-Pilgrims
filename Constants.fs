module Constants

open Types

let default_state: State =
    { credits = { amount = 0; earnings = 0 }
      matter = { current = 0; needed = 0 }
      electricity =
        { battery = { current = 0; cap = 0 }
          energy = { current = 0; needed = 0 } }
      humans = { current = 0; cap = 0 }
      drones = { current = 0; cap = 0 }
      day = { count = 0; gametick = 0 } }

let start_state: State =
    { credits = { amount = 1000; earnings = 0 }
      matter = { current = 0; needed = 0 }
      electricity =
        { battery = { current = 0; cap = 50 }
          energy = { current = 15; needed = 3 } }
      humans = { current = 0; cap = 3 }
      drones = { current = 0; cap = 0 }
      day = { count = 1; gametick = 0 } }


// various cost defaults for different space station
// utilities that need to be unlocked by the player.

let solar_panel_cost: Utility =
    { cost =
        { matter = 1
          energy = 20
          upkeep = { energy = 0; matter = 0 }
          time = 3
          credits = 500 }
      provides =
        { energy = 30
          battery = 5
          matter = 0
          credits = 0
          space = 0
          drones = 0 } }
