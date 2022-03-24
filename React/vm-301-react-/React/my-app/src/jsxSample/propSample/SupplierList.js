import React from 'react'

function SupplierList(props) {
  return (
    <div>
    <table>
        <tr>
            <td>Id</td>
            <td>Company Name</td>
            <td>Contact Name</td>
        </tr>
        
            {
                props.suppliers.map((item,key)=>{
                    return (<tr>
                        <td>{item.id}</td>
                        <td>{item.companyName}</td>
                        <td>{item.contactName}</td>
    
                    </tr>)
                })
            }
        
    </table>
</div>
  )
}

export default SupplierList