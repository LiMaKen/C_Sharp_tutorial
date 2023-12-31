﻿using Database.Sql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BTStaff
{
    internal class StaffData
    {
        public static List<Staff> SelectAllDataBySalary()
        {
            List<Staff> staffs = new List<Staff>();
            MySqlCommand command = DatabaseConnect.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM staff ORDER BY salary DESC";
            using (var reder = command.ExecuteReader())
            {
                if (reder.HasRows)
                {
                    while (reder.Read())
                    {
                        string staffId = reder.GetString("staffid");
                        string fullName = reder.GetString("fullname");
                        string email = reder.GetString("email");
                        string phone = reder.GetString("phone");
                        string role = reder.GetString("role");
                        long salary = reder.GetInt64("salary");
                        int workingday = reder.GetInt32("workingday");
                        long realsalary = reder.GetInt64("realsalary");
                        float bonus = reder.GetFloat("bonus");
                        string time = reder.GetString("time");
                        if (time != "Trong")
                        {
                            staffs.Add(new Director(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus, time));
                        }
                        else if (time == "Trong" && bonus == -1)
                        {
                            staffs.Add(new Staff(staffId, fullName, email, phone, role, salary, workingday, realsalary));
                        }
                        else
                        {
                            staffs.Add(new Manager(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus));
                        }
                    }
                }
            }
            return staffs;
        }
        public static List<Staff> SelectAllData()
        {
            List<Staff> staffs = new List<Staff>();
            MySqlCommand command = DatabaseConnect.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM staff";
            using (var reder = command.ExecuteReader())
            {
                if (reder.HasRows)
                {
                    while (reder.Read())
                    {
                        string staffId = reder.GetString("staffid");
                        string fullName = reder.GetString("fullname");
                        string email = reder.GetString("email");
                        string phone = reder.GetString("phone");
                        string role = reder.GetString("role");
                        long salary = reder.GetInt64("salary");
                        int workingday = reder.GetInt32("workingday");
                        long realsalary = reder.GetInt64("realsalary");
                        float bonus = reder.GetFloat("bonus");
                        string time = reder.GetString("time");
                        if (time != "Trong")
                        {
                            staffs.Add(new Director(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus, time));
                        }
                        else if (time == "Trong" && bonus == -1)
                        {
                            staffs.Add(new Staff(staffId, fullName, email, phone, role, salary, workingday, realsalary));
                        }
                        else
                        {
                            staffs.Add(new Manager(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus));
                        }
                    }
                }
            }
            return staffs;
        }
        public static string CheckIdInData()
        {
            string id = null;
            MySqlCommand command = DatabaseConnect.Connection.CreateCommand();
            command.CommandText = "SELECT MAX(staffid) FROM staff";
            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.IsDBNull(0))
                    {
                        id = reader.GetString(0);
                    }
                    reader.Close();
                }

            }
            if (id != null)
            {
                var resultid = id.Substring(3);
                var realid = Convert.ToInt32(resultid);
                return "EMP" + ++realid;
            }
            return "EMP1000";
        }
        public static void InsertData(Staff staff)
        {
            try
            {
                MySqlCommand command = DatabaseConnect.Connection.CreateCommand();
                command.CommandText = "INSERT INTO staff(staffid,fullname,email,phone,role,salary,workingday,realsalary,bonus,time) VALUES" +
                    " (@staffid,@fullname,@email,@phone,@role,@salary,@workingday,@realsalary,@bonus,@time)";
                command.Parameters.AddWithValue("staffid", CheckIdInData());
                command.Parameters.AddWithValue("fullname", staff.FullName);
                command.Parameters.AddWithValue("email", staff.Email);
                command.Parameters.AddWithValue("phone", staff.Phone);
                command.Parameters.AddWithValue("role", staff.Role);
                command.Parameters.AddWithValue("salary", staff.Salary);
                command.Parameters.AddWithValue("workingday", staff.WorkingDay);
                command.Parameters.AddWithValue("realsalary", staff.RealSalary);
                if (staff is Manager)
                {
                    var manager = (Manager)staff;
                    command.Parameters.AddWithValue("bonus", manager.Bonus);
                    command.Parameters.AddWithValue("time", "Trong");
                }
                else if (staff is Director)
                {
                    var director = (Director)staff;
                    command.Parameters.AddWithValue("bonus", director.Bonus);
                    command.Parameters.AddWithValue("time", director.Time);
                }
                else
                {
                    command.Parameters.AddWithValue("bonus", -1);
                    command.Parameters.AddWithValue("time", "Trong");
                }
                command.ExecuteNonQuery();
                Console.WriteLine("Tao thanh cong!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Tao that bai!");
                Console.WriteLine(e.ToString());
            }

        }

        internal static List<Staff> SelectByWorkingDay()
        {
            List<Staff> staffs = new List<Staff>();
            MySqlCommand command = DatabaseConnect.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM staff ORDER BY workingday DESC";
            using (var reder = command.ExecuteReader())
            {
                if (reder.HasRows)
                {
                    while (reder.Read())
                    {
                        string staffId = reder.GetString("staffid");
                        string fullName = reder.GetString("fullname");
                        string email = reder.GetString("email");
                        string phone = reder.GetString("phone");
                        string role = reder.GetString("role");
                        long salary = reder.GetInt64("salary");
                        int workingday = reder.GetInt32("workingday");
                        long realsalary = reder.GetInt64("realsalary");
                        float bonus = reder.GetFloat("bonus");
                        string time = reder.GetString("time");
                        if (time != "Trong")
                        {
                            staffs.Add(new Director(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus, time));
                        }
                        else if (time == "Trong" && bonus == -1)
                        {
                            staffs.Add(new Staff(staffId, fullName, email, phone, role, salary, workingday, realsalary));
                        }
                        else
                        {
                            staffs.Add(new Manager(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus));
                        }
                    }
                }
            }
            return staffs;
        }

        internal static List<Staff> SeachStaffId(string staffid)
        {
            List<Staff> staffs = new List<Staff>();
            MySqlCommand command = DatabaseConnect.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM staff WHERE staffid=@staffid LIMIT 1";
            command.Parameters.AddWithValue("staffid", staffid);
            using (var reder = command.ExecuteReader())
            {
                if (reder.HasRows)
                {
                        reder.Read();
                        string staffId = reder.GetString("staffid");
                        string fullName = reder.GetString("fullname");
                        string email = reder.GetString("email");
                        string phone = reder.GetString("phone");
                        string role = reder.GetString("role");
                        long salary = reder.GetInt64("salary");
                        int workingday = reder.GetInt32("workingday");
                        long realsalary = reder.GetInt64("realsalary");
                        float bonus = reder.GetFloat("bonus");
                        string time = reder.GetString("time");
                        if (time != "Trong")
                        {
                            staffs.Add(new Director(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus, time));
                        }
                        else if (time == "Trong" && bonus == -1)
                        {
                            staffs.Add(new Staff(staffId, fullName, email, phone, role, salary, workingday, realsalary));
                        }
                        else
                        {
                            staffs.Add(new Manager(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus));
                        }
                        reder.Close();
                }
            }
            return staffs;
        }

        internal static List<Staff> SeachStaffBySalary(string salarySeach)
        {
            List<Staff> staffs = new List<Staff>();
            MySqlCommand command = DatabaseConnect.Connection.CreateCommand();
            command.CommandText = "SELECT * FROM staff WHERE salary=@salary";
            command.Parameters.AddWithValue("salary", salarySeach);
            using (var reder = command.ExecuteReader())
            {
                if (reder.HasRows)
                {
                    while (reder.Read())
                    {
                        string staffId = reder.GetString("staffid");
                        string fullName = reder.GetString("fullname");
                        string email = reder.GetString("email");
                        string phone = reder.GetString("phone");
                        string role = reder.GetString("role");
                        long salary = reder.GetInt64("salary");
                        int workingday = reder.GetInt32("workingday");
                        long realsalary = reder.GetInt64("realsalary");
                        float bonus = reder.GetFloat("bonus");
                        string time = reder.GetString("time");
                        if (time != "Trong")
                        {
                            staffs.Add(new Director(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus, time));
                        }
                        else if (time == "Trong" && bonus == -1)
                        {
                            staffs.Add(new Staff(staffId, fullName, email, phone, role, salary, workingday, realsalary));
                        }
                        else
                        {
                            staffs.Add(new Manager(staffId, fullName, email, phone, role, salary, workingday, realsalary, bonus));
                        }
                    }
                }
            }
            return staffs;
        }

        internal static void UpdateStaffSalary(Staff staff, string salary)
        {
            try
            {
                MySqlCommand cmd = DatabaseConnect.Connection.CreateCommand();
                cmd.CommandText = "UPDATE staff SET salary=@salary WHERE staffid=@staffid LIMIT 1";
                cmd.Parameters.AddWithValue("staffid", staff.StaffId);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.ExecuteNonQuery();
                Console.WriteLine("cap nhat thanh cong!");
            }
            catch (Exception e)
            {
                Console.WriteLine("cap nhat that bai!");
                Console.WriteLine(e);
            }
        }

        internal static void DeleteStaff(Staff staff)
        {
            try
            {
                MySqlCommand cmd = DatabaseConnect.Connection.CreateCommand();
                cmd.CommandText = "DELETE FROM staff WHERE staffid=@staffid LIMIT 1";
                cmd.Parameters.AddWithValue("staffid", staff.StaffId);
                cmd.ExecuteNonQuery();
                Console.WriteLine("XOA thanh cong!");
            }
            catch (Exception e)
            {
                Console.WriteLine("XOA that bai!");
                Console.WriteLine(e);
            }
        }
    }
}
