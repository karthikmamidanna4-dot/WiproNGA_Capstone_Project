import { useState } from "react"
import { createTicket } from "../services/api"

function CreateTicket() {

  const [title, setTitle] = useState("")
  const [description, setDescription] = useState("")
  const [status, setStatus] = useState("Open")
  const [priority, setPriority] = useState("Medium")

  const handleSubmit = async (e: any) => {
  e.preventDefault()

  const newTicket = {
  Title: title,
  Description: description,
  Status: status,
  Priority: priority,
  CustomerID: 1,
  AgentID: 1,
  CategoryID: 1,
  CreatedDate: new Date().toISOString(),
  ResolvedDate: null
}

  try {
    const response = await createTicket(newTicket)
    console.log(response)

    alert("Ticket Created Successfully")

    setTitle("")
    setDescription("")
  } catch (error) {
    console.error(error)
    alert("Error creating ticket")
  }
}

  return (
    <div className="container mt-4">

      <h2>Create Ticket</h2>

      <form onSubmit={handleSubmit}>

        <div className="mb-3">
          <label className="form-label">Title</label>
          <input
            className="form-control"
            value={title}
            onChange={(e) => setTitle(e.target.value)}
            required
          />
        </div>

        <div className="mb-3">
          <label className="form-label">Description</label>
          <textarea
            className="form-control"
            value={description}
            onChange={(e) => setDescription(e.target.value)}
            required
          />
        </div>

        <div className="mb-3">
          <label className="form-label">Status</label>
          <select
            className="form-control"
            value={status}
            onChange={(e) => setStatus(e.target.value)}
          >
            <option>Open</option>
            <option>Closed</option>
          </select>
        </div>

        <div className="mb-3">
          <label className="form-label">Priority</label>
          <select
            className="form-control"
            value={priority}
            onChange={(e) => setPriority(e.target.value)}
          >
            <option>Low</option>
            <option>Medium</option>
            <option>High</option>
          </select>
        </div>

        <button className="btn btn-primary">
          Create Ticket
        </button>

      </form>

    </div>
  )
}

export default CreateTicket