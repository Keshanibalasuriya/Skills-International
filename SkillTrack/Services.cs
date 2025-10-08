using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrack
{
    internal class Services
    {
        Connection db = new Connection(); // call connection class

       
        // ADD STUDENT METHOD
       
        public bool AddStudent(Student student)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"INSERT INTO Registration
                                (regNo, firstName, lastName, dateOfBirth, gender, address, email, 
                                 mobilePhone, homePhone, parentName, nic, contactNo) 
                                VALUES
                                (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, 
                                 @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", student.regNo);
                    cmd.Parameters.AddWithValue("@firstName", student.firstName);
                    cmd.Parameters.AddWithValue("@lastName", student.lastName);
                    cmd.Parameters.AddWithValue("@dateOfBirth", student.dateOfBirth);
                    cmd.Parameters.AddWithValue("@gender", student.gender);
                    cmd.Parameters.AddWithValue("@address", student.address);
                    cmd.Parameters.AddWithValue("@email", student.email);
                    cmd.Parameters.AddWithValue("@mobilePhone", student.mobilePhone);
                    cmd.Parameters.AddWithValue("@homePhone", student.homePhone);
                    cmd.Parameters.AddWithValue("@parentName", student.parentName);
                    cmd.Parameters.AddWithValue("@nic", student.nic);
                    cmd.Parameters.AddWithValue("@contactNo", student.contactNo);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

       
        }
    }

