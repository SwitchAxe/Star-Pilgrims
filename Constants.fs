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

let battery_storage_cost: Utility =
    { cost =
        { matter = 1
          energy = 30
          upkeep = { energy = 0.1; matter = 1 }
          time = 5
          credits = 500 }
      provides =
        { energy = 0
          battery = 50
          matter = 0
          credits = 0
          space = 0
          drones = 0 } }


let basic_living_cost: Utility =
    { cost =
        { matter = 5
          energy = 50
          upkeep = { energy = 3; matter = 5 }
          time = 20
          credits = 2000 }
      provides =
        { space = 5
          drones = 0
          energy = 0
          battery = 20
          credits = 0
          matter = 0 } }

let computing_centre_cost: Utility =
    { cost =
        { matter = 5
          energy = 200
          upkeep = { energy = 50; matter = 0.5 }
          time = 10
          credits = 2000 }
      provides =
        { space = 0
          drones = 0
          energy = 0
          battery = 30
          credits = 20
          matter = 0 } }

let drone_bay_cost: Utility =
    { cost =
        { matter = 5
          energy = 50
          upkeep = { energy = 20; matter = 10 }
          time = 60
          credits = 10000 }
      provides =
        { space = 0
          drones = 3
          energy = 0
          battery = 50
          credits = 0
          matter = 0 } }

let luxury_living_cost: Utility =
    { cost =
        { matter = 15
          energy = 75
          upkeep = { energy = 20; matter = 20 }
          time = 120
          credits = 20000 }
      provides =
        { space = 10
          drones = 0
          energy = 0
          battery = 50
          credits = 0
          matter = 0 } }

let ion_engine_cost: Utility =
    { cost =
        { matter = 5
          energy = 10
          upkeep = { energy = 1; matter = 1 }
          time = 10
          credits = 3000 }
      provides =
        { space = 0
          drones = 0
          energy = 0
          battery = 0
          credits = 0
          matter = 0 } }

let factory_cost: Utility =
    { cost =
        { matter = 10
          energy = 300
          upkeep = { energy = 1; matter = 100 }
          time = 120
          credits = 30000 }
      provides =
        { space = 0
          drones = 0
          energy = 0
          battery = 0
          credits = 200
          matter = 0 } }

let default_engine: Engine =
    { elapsed = 0
      power_obtained = 0
      power_consumed = 0
      battery_cap = 0
      matter = 0
      matter_change = 0 }
