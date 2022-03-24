import React from 'react'

function MapSample() {
    let metalBand=["Iron Maiden", "Rotting Christ" , "In Flames", "Gojira","Moonspell","Parkway Drive"]
  return (
    <div>
        <ul>
        {
            metalBand.map((item,key)=>{
               return (<li>{item}</li>)
            })
        }
        </ul>

    </div>
  )
}

export default MapSample