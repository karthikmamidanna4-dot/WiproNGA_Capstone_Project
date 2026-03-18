const API_URL = "https://localhost:7089/api"

export const getTickets = async () => {
  const response = await fetch("https://localhost:7089/api/Tickets")

  if (!response.ok) {
    throw new Error("Failed to fetch tickets")
  }

  return await response.json()
}
export const createTicket = async (ticket: any) => {
  const response = await fetch("https://localhost:7089/api/Tickets", {
    method: "POST",
    headers: {
      "Content-Type": "application/json"
    },
    body: JSON.stringify(ticket)
  })

  if (!response.ok) {
    throw new Error("Failed to create ticket")
  }

  return await response.text()
}
export const getCustomers = async () => {
  const response = await fetch("https://localhost:7089/api/Customers")

  if (!response.ok) {
    throw new Error("Failed to fetch customers")
  }

  return await response.json()
}
export const getAgents = async () => {
  const response = await fetch("https://localhost:7089/api/Agents")

  if (!response.ok) {
    throw new Error("Failed to fetch agents")
  }

  return await response.json()
}
export const deleteTicket = async (id: number) => {
  const response = await fetch(`https://localhost:7089/api/Tickets/${id}`, {
    method: "DELETE"
  })

  if (!response.ok) {
    throw new Error("Failed to delete ticket")
  }
}
export const resolveTicket = async (id: number) => {
  const response = await fetch(`https://localhost:7089/api/Tickets/resolve/${id}`, {
    method: "PUT"
  })

  if (!response.ok) {
    throw new Error("Failed to resolve ticket")
  }
}
