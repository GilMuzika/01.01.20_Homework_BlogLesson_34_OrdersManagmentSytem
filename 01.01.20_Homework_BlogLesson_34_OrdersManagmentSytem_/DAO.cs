using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._01._20_Homework_BlogLesson_34_OrdersManagmentSytem_
{
    class DAO
    {
        private SqlConnection _connection = new SqlConnection();
        private SqlCommand _command = new SqlCommand();

        public DAO()
        {
            _connection.ConnectionString = ConfigurationManager.ConnectionStrings["OrdersManagementSystem"].ConnectionString;
            _command.Connection = _connection;
            _command.CommandType = System.Data.CommandType.Text;

            FlexibleMessageBox.MAX_WIDTH_FACTOR = Screen.PrimaryScreen.WorkingArea.Width;
            FlexibleMessageBox.MAX_HEIGHT_FACTOR = Screen.PrimaryScreen.WorkingArea.Height;
        }

        public void AddNewDefinedObject<T>(T poko)
        {
            string tableName = typeof(T).Name + "s";
            bool IsOperationSucseed = false;
            try
            {
                _connection.Open();                
                _command.CommandText = $"INSERT INTO {tableName} ({typeof(T).GetProperties()[1].Name}) VALUES ('{typeof(T).GetProperties()[1].GetValue(poko)}')";
                _command.ExecuteNonQuery();
                for(int i = 2; i < typeof(T).GetProperties().Length; i++)
                {
                    _command.CommandText = $"UPDATE {tableName} SET {typeof(T).GetProperties()[i].Name} = '{typeof(T).GetProperties()[i].GetValue(poko)}' WHERE {typeof(T).GetProperties()[1].Name} = '{typeof(T).GetProperties()[1].GetValue(poko)}'";
                    _command.ExecuteNonQuery();
                }
                IsOperationSucseed = true;
                
            }
            catch (Exception ex)
            {
                IsOperationSucseed = false;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                AddOperationRecord($"Adding a new {typeof(T).Name}", IsOperationSucseed);
                _connection.Close();
            }
        }
        public T GetOneDefinedObject<T>(int objectID) where T : class, new()
        {
            string operationRecordingMessage = $"Retriving one {typeof(T).Name} from the DB";
            return GetDefinedObjectsInternal<T>(objectID, operationRecordingMessage).First();
        }
        public List<T> GetAllDefinedObjects<T>() where T : class, new()
        {
            string operationRecordingMessage = $"Retriving all the {typeof(T).Name}s from the DB";
            return GetDefinedObjectsInternal<T>(-2, operationRecordingMessage);
        }
        private List<T> GetDefinedObjectsInternal<T>(int objectID, string operationRecordingMessage) where T : class, new()
        {            
            bool IsOperationSucseed = false;
            List<T> allPocos = new List<T>();
            try
            {                
                string tableName = typeof(T).Name + "s";
                _connection.Open();
                if (objectID == -2) { _command.CommandText = $"SELECT * FROM {tableName}"; }
                else _command.CommandText = $"SELECT * FROM {tableName} WHERE NUM = {objectID}";
                using (SqlDataReader reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T poco = new T();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            object value = reader[i];
                            if (reader[i] is DBNull) value = "";
                            typeof(T).GetProperties()[i].SetValue(poco, value);
                        }
                        allPocos.Add(poco);
                        IsOperationSucseed = true;
                    }
                }              
            }
            catch (Exception ex)
            {
                IsOperationSucseed = false;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                AddOperationRecord(operationRecordingMessage, IsOperationSucseed);
                _connection.Close();
            }
            return allPocos;
        }
        public void MakeOrder(Client client, Product product, int amount)
        {
            bool isSucseeded = false;
            try
            {
                _connection.Open();
                _command.CommandText = $"INSERT INTO Orders (clientNUM, productNUM, amount, orderPrice) VALUES ({client.NUM}, {product.NUM}, {amount}, {product.price})";
                _command.ExecuteNonQuery();
                isSucseeded = true;
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                AddOperationRecord($"{product.amount} {product.GetType().Name}s ordered", isSucseeded);
                _connection.Close();
            }
        }
        public bool isIInTheSystem<T>(string name, string pass, out T someone) where T : new()
        {            
            bool isIInTheSystem = false;
            T poco = new T();
            try
            {                
                string tableName = typeof(T).Name + "s";
                _connection.Open();
                _command.CommandText = $"SELECT * FROM {tableName} WHERE userName = '{name}'";
                using (SqlDataReader reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var readerDecrypted = Statics.Decrypt((string)reader["pass"], name);
                        if (Statics.Decrypt(pass, name).Equals(readerDecrypted)) 
                        {
                            isIInTheSystem = true;
                            for(int i = 0; i < reader.FieldCount; i++)
                            {
                                typeof(T).GetProperties()[i].SetValue(poco, reader[i]);
                            }

                            break; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                string trackingMessage = string.Empty;
                if (isIInTheSystem) trackingMessage = $"{typeof(T).Name} {typeof(T).GetProperties()[0].GetValue(poco)} is signed in";
                else trackingMessage = $"Some {typeof(T).Name} tryed to sign in but failed";
                AddOperationRecord(trackingMessage, isIInTheSystem);
                _connection.Close();
            }
            someone = poco;
            return isIInTheSystem;
        }
        public DataTable ViewAsGrid(string tableName, int someoneNum)
        {
            return ViewAsGridInternal(tableName, someoneNum);
        }
        public DataTable ViewAsGrid(string tableName)
        {
            return ViewAsGridInternal(tableName, -2);
        }
        private DataTable ViewAsGridInternal(string tableName, int someoneNum)
        {
            bool isSucseed = false;
            string operationDescription = string.Empty;
            string baseSQLtext = string.Empty;
            DataTable dataTable = new DataTable();
            try
            {
                _connection.Open();

                if (tableName.Equals("Orders")) baseSQLtext = $"SELECT  Products.productName, price, Orders.amount, (Products.price * Orders.amount) as 'this order price' FROM Orders JOIN Products ON Products.NUM = Orders.productNUM";
                else baseSQLtext = $"SELECT * FROM {tableName}";
                if (someoneNum == -2)
                {
                    _command.CommandText = baseSQLtext;
                    operationDescription = $"retriving all the {tableName} for grid view";                    
                }
                else
                {
                    _command.CommandText = $"{baseSQLtext} WHERE clientNUM = {someoneNum}";
                    operationDescription = $"retriving {tableName} of the client or supplier {someoneNum} for grid view";
                }
                SqlDataAdapter adapter = new SqlDataAdapter(_command);
                
                adapter.Fill(dataTable);
                isSucseed = true;
                
            }
            catch (Exception ex)
            {
                isSucseed = false;
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
            finally
            {
                AddOperationRecord(operationDescription, isSucseed);
                _connection.Close();
            }
            return dataTable;
        }


        private void AddOperationRecord(string operaionDescription, bool isSucseeded)
        {
            try
            {             
                _command.CommandText = $"INSERT INTO TrackingLog (DateAndTime, KindOfOperation, Sucseeded) VALUES ('{DateTime.Now}', '{operaionDescription}', '{isSucseeded}')";
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {                
                FlexibleMessageBox.Show($"{ex.GetType().Name}\n\n{ex.Message}\n\n{ex.StackTrace}");
            }
        }
    }
}
