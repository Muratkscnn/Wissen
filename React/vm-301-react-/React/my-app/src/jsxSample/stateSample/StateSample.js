import React, { useState } from 'react'

function StateSample() {
    const [name,setName] = useState('Murat')
    const changeName=()=>{
        setName('Wissen')
    }
  return (
    <div>
        <h1>{name}</h1>
        <button onClick={() => changeName()}>Change Name</button>
    </div>
  )
}

export default StateSample