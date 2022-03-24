import React from 'react'

function PropSample(props) {
  return (
    <div>
        <h1>User Name: {props.name}</h1>
        <h1>SurName: {props.surname}</h1>

    </div>
  )
}

export default PropSample