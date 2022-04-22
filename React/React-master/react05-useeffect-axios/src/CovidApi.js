import axios from "axios";
import React, { useEffect, useState } from "react";

function CovidApi() {
  const [data, setData] = useState("");
  const [tarih, setTarih] = useState("");

  useEffect(() => {
    axios
      .get(
        "https://raw.githubusercontent.com/ozanerturk/covid19-turkey-api/master/dataset/timeline.json")
      .then((res) => setData(res.data[tarih]));
  }, [data, tarih]);

  return(
    <div>
    <div className="container">
        <div className="row">
            <div className="col-md-8 mx-auto mt-4">
                <h2 className="text-center">TÜRKİYE GÜNCEL COVİD VERİLERİ</h2>
                <input type="text" placeholder="GG/AA/YYY" className="form-control text-center" onChange={(e) => setTarih(e.target.value)} />
                <table className="table table dark">
                    <thead>
                        <tr className={data===undefined ? "bg-light" : "bg-info"}>
                            <th>#</th>
                            <th>Test Sayısı</th>
                            <th>Günlük Hasta Sayısı</th>
                            <th>Toplam Hasta Sayısı</th>
                            <th>Toplam Vefat Sayısı</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>{data===undefined ? "Veri bekleniyor" : data.totalTests}</td>
                            <td>{data===undefined ? "Veri bekleniyor" : data.patients}</td>
                            <td>{data===undefined ? "Veri bekleniyor" : data.totalPatients}</td>
                            <td>{data===undefined ? "Veri bekleniyor" : data.totalDeaths}</td>

                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    </div>
  )
    
  
}

export default CovidApi;
