import { useEffect, useState } from "react"
import type { Ticket } from "../models/Ticket"
import { getTickets, deleteTicket, resolveTicket } from "../services/api"

function TicketsPage() {

  const [tickets, setTickets] = useState<Ticket[]>([])

  useEffect(() => {
    loadTickets()
  }, [])

  const loadTickets = async () => {
    const data = await getTickets()
    setTickets(data)
  }
  const handleDelete = async (id: number) => {
  await deleteTicket(id)
  loadTickets()
}

const handleResolve = async (id: number) => {
  await resolveTicket(id)
  loadTickets()
}

  return (
    <div className="container mt-4">
      <h2>Tickets</h2>

      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Actions</th>
            <th>ID</th>
            <th>Title</th>
            <th>Status</th>
            <th>Priority</th>
          </tr>
        </thead>

        <tbody>
          {tickets.map(ticket => (
            <tr key={ticket.ticketID}>
              <td>{ticket.ticketID}</td>
              <td>{ticket.title}</td>
              <td>{ticket.status}</td>
              <td>{ticket.priority}</td>
              <td>
                <button
                className="btn btn-success btn-sm me-2"
                onClick={() => handleResolve(ticket.ticketID)}
                >
                    Resolve
                </button>

                <button
                className="btn btn-danger btn-sm"
                onClick={() => handleDelete(ticket.ticketID)}
                >
                    Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>

      </table>
    </div>
  )
}

export default TicketsPage