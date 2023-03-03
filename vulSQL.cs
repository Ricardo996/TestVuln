var sql = "SELECT * FROM UserAccount WHERE Username = '" + username "'";
SqlCommand command = new SqlCommand(sql , connection);
SqlDataReader reader = command.ExecuteReader();
