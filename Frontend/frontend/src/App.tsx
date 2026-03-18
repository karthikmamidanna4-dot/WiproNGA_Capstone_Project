// import 'bootstrap/dist/css/bootstrap.min.css'
// import TicketsPage from './pages/TicketsPage'

// function App() {
//   return (
//     <div className="container mt-5">
//       <h1>Customer Support Dashboard</h1>
//       <TicketsPage />
//     </div>
//   )
// }

// export default App
import 'bootstrap/dist/css/bootstrap.min.css'
import { BrowserRouter, Routes, Route, Link } from "react-router-dom"

import Dashboard from "./pages/Dashboard"
import TicketsPage from "./pages/TicketsPage"
import CustomersPage from "./pages/CustomersPage"
import AgentsPage from "./pages/AgentsPage"
import CreateTicket from "./pages/CreateTicket"

function App() {

  return (
    <BrowserRouter>

      <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
        <div className="container">

          <Link className="navbar-brand" to="/">Support System</Link>

          <div className="navbar-nav">
            <Link className="nav-link" to="/">Dashboard</Link>
            <Link className="nav-link" to="/tickets">Tickets</Link>
            <Link className="nav-link" to="/customers">Customers</Link>
            <Link className="nav-link" to="/agents">Agents</Link>
            <Link className="nav-link" to="/create-ticket">Create Ticket</Link>
          </div>

        </div>
      </nav>

      <Routes>
        <Route path="/" element={<Dashboard />} />
        <Route path="/tickets" element={<TicketsPage />} />
        <Route path="/customers" element={<CustomersPage />} />
        <Route path="/agents" element={<AgentsPage />} />
        <Route path="/create-ticket" element={<CreateTicket />} />
      </Routes>

    </BrowserRouter>
  )
}

export default App
