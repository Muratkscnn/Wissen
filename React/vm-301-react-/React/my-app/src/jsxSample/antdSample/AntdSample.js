import { Table } from 'antd'
import React, { useEffect, useState } from 'react'

function AntdSample() {

    const [suppliers, setSuppliers] = useState()
    
    useEffect(() => {
        fetch("https://northwind.vercel.app/api/suppliers")
            .then(res => res.json())
            .then((data) => {
                setSuppliers(data);
            })
      
    }, [])
    let columns = [
        {
            title:'ID',
            dataIndex:'id',
            key:'id'
        },
        {
            title:'Contact Name',
            dataIndex:'contactName',
            key:'contactName'
        },
        {
            title:'Company Name',
            dataIndex:'companyName',
            key:'companyName'
        },
        {
            title:'Contact Title',
            dataIndex:'contactTitle',
            key:'contactTitle'
        }
    ]
    

  return (
    <div>
        <Table dataSource={suppliers} columns={columns} />
    </div>
  )
}

export default AntdSample