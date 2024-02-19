module Physics
open Types

let gen_solar_power (inst : double)
                    (delta : double)
                    (orbit: bool)
                    (travel: bool)
                    (travel_time: double) =
        if orbit then double(inst)
        elif travel then
                inst / (pown (1.0 + travel_time) 2)
        else match sin(delta+3.141)+0.4 with
                | (pmod: double) when pmod > 0 -> inst * pmod
                | _ -> 0

let physics_process (delta: int64)
                    (st : State) : int64 =
        delta + int64(1)