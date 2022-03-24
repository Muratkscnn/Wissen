import React, { useEffect, useState } from 'react'
import EffectAdd from './EffectAdd';
import EffectSample from './EffectSample';
function EffectPage() {
    const [suppliers, setSuppliers] = useState([]);

    useEffect(() => {
        fetch("https://northwind.vercel.app/api/suppliers")
        .then((res) => res.json())
        .then((data) => {
            setSuppliers(data);
        })
    }, []);
    const deleteSuppliers = (id) => {
        let newSuppliers = suppliers.filter(q => q.id != id);
        setSuppliers(newSuppliers);
    }

    const addNewSuppliers = (item) => {

        setSuppliers([...suppliers,item]);
    }
    
  return (
    <div>
        <EffectAdd addNewSuppliers={addNewSuppliers}></EffectAdd>
        <EffectSample suppliers={suppliers} deleteSuppliers={deleteSuppliers}></EffectSample>
    </div>
  )
}

export default EffectPage