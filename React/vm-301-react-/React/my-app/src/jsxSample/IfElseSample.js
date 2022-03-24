import React from 'react'

function IfElseSample() {
    let onlineStatus=true;
  return (
    <div>
        {
        onlineStatus=true? <h1>User Online</h1> : <h1>User Offline</h1>
        
        }
    </div>
  )
}

export default IfElseSample