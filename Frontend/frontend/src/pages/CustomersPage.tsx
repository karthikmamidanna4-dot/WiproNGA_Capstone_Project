import { useEffect, useState } from "react"
import { getCustomers } from "../services/api"

function CustomersPage() {

  const [customers, setCustomers] = useState<any[]>([])

  useEffect(() => {
    loadCustomers()
  }, [])

  const loadCustomers = async () => {
    const data = await getCustomers()
    setCustomers(data)
  }

  return (
    <div className="container mt-4">

      <h2>Customers</h2>

      <table className="table table-bordered">

        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
          </tr>
        </thead>

        <tbody>
          {customers.map((customer) => (
            <tr key={customer.customerID}>
              <td>{customer.customerID}</td>
             <td>{customer.firstName} {customer.lastName}</td>
              <td>{customer.email}</td>
              <td>{customer.phone}</td>
            </tr>
          ))}
        </tbody>

      </table>

    </div>
  )
}

export default CustomersPage