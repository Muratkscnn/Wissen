import React from "react";

function Employee() {
  const employees = [
    {
      name: "Berkay",
      id: "01",
    },
    {
      name: "Alper",
      id: "02",
    },
    {
      name: "Yasemin",
      id: "03",
    },
    {
      name: "Furkan",
      id: "04",
    },
    {
      name: "Belinay",
      id: "05",
    },
  ];

  return (
    <div className="container">
        <div className="row">
      {employees.map((employee) => (
        
            <div className="col-4 mb-4">
          <div className="card">
            <div className="card-body">
              <h5 className="card-title">{employee.name}</h5>
              <p className="card-text">{employee.id}</p>
              <a href="#" className="btn btn-primary">
                Detay
              </a>
            </div>
          </div>
        </div>
        
      ))}
      </div>
    </div>
  );
}

export default Employee;
