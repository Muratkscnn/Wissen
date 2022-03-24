import React, { useState } from 'react'

function MetalSample() {

    const[metalBands,setMetalBands] = useState([]);
    const[newMetal,setNewMetal]=useState('');
    const addNewMetal=()=>{
        //setMetalBands([...metalBands]);
        setMetalBands([...metalBands,newMetal])
    }
  return (
    <div>
        <div>
            <label> New Metal Band</label>
            <input type='text' value={newMetal} onChange={(e) => setNewMetal(e.target.value)} />
        </div>
        <div>
        <button onClick={()=> addNewMetal()}>Add</button>
        </div>
        <div>
            <ul>
                {
                    metalBands && metalBands.map((item,key)=>
                    {
                        return <li>{item}</li>
                    })
                }
            </ul>
        </div>
    </div>
  )
}

export default MetalSample