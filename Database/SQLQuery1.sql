INSERT INTO Tickets
(CustomerID, AgentID, CategoryID, Title, Description, Status, Priority, CreatedDate, ResolvedDate)
VALUES
(1,1,1,'Software Crash','Application crashes while opening','Closed','High','2026-01-02','2026-01-03'),
(2,2,2,'Payment Failed','Payment not processed','Closed','Medium','2026-01-05','2026-01-06'),
(3,3,3,'Cannot Login','Password reset not working','Open','High','2026-01-08',NULL),
(4,4,4,'Service Inquiry','Need information about services','Closed','Low','2026-01-10','2026-01-11'),
(5,1,1,'System Error','Unexpected system error','Open','High','2026-01-12',NULL),
(6,2,2,'Refund Request','Customer asking for refund','Closed','Medium','2026-01-15','2026-01-16'),
(7,3,5,'Service Complaint','Customer unhappy with service','Open','High','2026-01-18',NULL),
(8,4,3,'Account Locked','Account locked after login attempts','Closed','Medium','2026-01-20','2026-01-21'),
(2,1,1,'Application Freeze','App freezes randomly','Closed','High','2026-02-01','2026-02-02'),
(3,2,2,'Billing Error','Incorrect invoice generated','Open','Medium','2026-02-03',NULL),
(4,3,4,'Information Request','Customer asking about upgrade','Closed','Low','2026-02-05','2026-02-06'),
(5,4,3,'Password Issue','Unable to change password','Closed','Medium','2026-02-07','2026-02-08'),
(6,1,5,'Complaint about delay','Service delayed','Open','High','2026-02-10',NULL),
(7,2,2,'Payment Declined','Card declined issue','Closed','Medium','2026-02-12','2026-02-13'),
(8,3,1,'System Lag','System running slow','Open','Low','2026-02-15',NULL);