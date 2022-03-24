import React, { useEffect, useState } from 'react'

function EffectSample(props) {
    

  return (
    <div>
         <table>
                <tr>
                    <td>Id</td>
                    <td>Company Name</td>
                    <td>Contact Name</td>
                    <td>Delete</td>
                </tr>

                {
                    props.suppliers && props.suppliers.map((item, key) => {
                        return <tr>
                            <td>{item.id}</td>
                            <td>{item.companyName}</td>
                            <td>{item.contactName}</td>
                            <td><button onClick={() => props.deleteSuppliers(item.id)}>Delete</button></td>
                        </tr>
                    })
                }
            </table>
    </div>
  )
}

export default EffectSample