import { useEffect, useState } from "react"
import { getTickets } from "../services/api"

function Dashboard() {

  const [tickets, setTickets] = useState<any[]>([])

  useEffect(() => {
    loadTickets()
  }, [])

  const loadTickets = async () => {
    const data = await getTickets()
    setTickets(data)
  }

  const totalTickets = tickets.length
  const openTickets = tickets.filter(t => t.status === "Open").length
  const closedTickets = tickets.filter(t => t.status === "Closed").length
  const highPriority = tickets.filter(t => t.priority === "High").length

  return (
    <div className="container mt-4">

      <h2>Dashboard</h2>

      <div className="row mt-4">

        <div className="col-md-3">
          <div className="card bg-primary text-white p-3">
            <h4>Total Tickets</h4>
            <h2>{totalTickets}</h2>
          </div>
        </div>

        <div className="col-md-3">
          <div className="card bg-warning text-dark p-3">
            <h4>Open Tickets</h4>
            <h2>{openTickets}</h2>
          </div>
        </div>

        <div className="col-md-3">
          <div className="card bg-success text-white p-3">
            <h4>Closed Tickets</h4>
            <h2>{closedTickets}</h2>
          </div>
        </div>

        <div className="col-md-3">
          <div className="card bg-danger text-white p-3">
            <h4>High Priority</h4>
            <h2>{highPriority}</h2>
          </div>
        </div>

      </div>

    </div>
  )
}

export default Dashboard