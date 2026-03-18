import { useEffect, useState } from "react"
import { getAgents } from "../services/api"

function AgentsPage() {

  const [agents, setAgents] = useState<any[]>([])

  useEffect(() => {
    loadAgents()
  }, [])

  const loadAgents = async () => {
    const data = await getAgents()
    setAgents(data)
  }

  return (
    <div className="container mt-4">

      <h2>Agents</h2>

      <table className="table table-bordered">

        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Department</th>
          </tr>
        </thead>

        <tbody>
          {agents.map((agent) => (
            <tr key={agent.agentID}>
              <td>{agent.agentID}</td>
              <td>{agent.agentName}</td>
              <td>{agent.email}</td>
              <td>{agent.department}</td>
            </tr>
          ))}
        </tbody>

      </table>

    </div>
  )
}

export default AgentsPage