import React, { useState } from 'react'

function EffectAdd(props) {
    const [companyName, setCompanyName] = useState('');
    const [contactName, setContactName] = useState('');

    const add = ()=>{
        let newSuppliers={
            companyName:companyName,
            contactName:contactName,
            
        };
        props.addNewSuppliers(newSuppliers);
    }
    

  return (
    <div>
            <div>
                <label>Company Name:</label>
                <input type='text' value={companyName} onChange={(e) => setCompanyName(e.target.value) } />
            </div>

            <div>
                <label>Contact Name:</label>
                <input type='text' value={contactName} onChange={(e) => setContactName(e.target.value) } />
            </div>

            <div>
                <button onClick={() => add()}>Add</button>
            </div>
        </div>
  )
}

export default EffectAdd