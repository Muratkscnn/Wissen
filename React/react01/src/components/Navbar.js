import React from 'react'

function Navbar() {
  return (
    <div className="container-fluid">
    <nav
      className="navbar navbar-expand-lg navbar-light "
      style={{ backgroundColor: "rgb(231, 225, 225)" }}
    >
      <div className="container-fluid">
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarTogglerDemo03"
          aria-controls="navbarTogglerDemo03"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon" />
        </button>
        <a className="navbar-brand" href="#">
          <img src="logo-removebg-preview.png" alt="" />
        </a>
        <div className="collapse navbar-collapse" id="navbarTogglerDemo03">
          <ul className="navbar-nav me-auto mb-2 mb-lg-0">
            <li className="nav-item">
              <a className="nav-link active" aria-current="page" href="/Home">
                Sinemalarımız
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="#">
                Etkinlikler
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="#">
                Kampanyalar
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="#">
                Duyurular
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="/About">
                Hakkımızda
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="/Contact">
                İletişim
              </a>
            </li>
          </ul>
          <form className="d-flex">
            <input
              className="form-control me-2"
              type="search"
              placeholder="Search"
              aria-label="Search"
            />
            <button className="btn btn-outline-success" type="submit">
              Search
            </button>
          </form>
        </div>
      </div>
    </nav>
  </div>
  )
}

export default Navbar