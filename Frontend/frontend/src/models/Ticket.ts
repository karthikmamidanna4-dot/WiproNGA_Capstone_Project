export interface Ticket {
  ticketID: number
  title: string
  description: string
  customerID: number
  agentID: number
  categoryID: number
  status: string
  priority: string
  createdDate: string
  resolvedDate?: string
}