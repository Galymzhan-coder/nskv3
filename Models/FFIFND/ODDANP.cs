//using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Configuration;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Models.FFIFND
{
    public interface INPRoutine
    {
        decimal GetSeq(string seqname, string shema = null);
        string GetTable(decimal tblid, ref string message);
        string GetField(decimal fldid, ref string message);
        int GetIdTable(string tbl, ref string message);
        int CheckGenerator(decimal tblid, ref string seqname, ref string message);
        decimal PutToDatabase<T>(T model, string tablename, string seqname, ref string message, string shema = null, bool dateasstring = false);
        decimal UpdateFromModel<T>(T model, string tablename, ref string message, string whereclause = null, string shema = null, bool dateasstring = false);
        IEnumerable<T> GetFromDatabase<T>(ref string message, string sql = null, string tablename = null, string whereclause = null, string shema = null, List<string> propertyname = null) where T : class, new();
        bool DeleteFromDB(string tablename, string whereclause, ref string message);
        bool UpdateFromSql(string sql, ref string message);
        //decimal UpdateFromIUFValues<T>(T model, ref string message);
        bool ExecTransaction(string[] sqlcommands, ref string message);
        byte[] QueryBlobValue(string tblname, string blobfield, string whereclause, ref string message);
        bool UpdateBlobValue(string tblname, string blobfield, byte[] blobvalue, string whereclause, ref string message);
        IEnumerable<string> QueryAsResultArray(string tblname, string listfield, string whereclause, ref string message);
        IEnumerable<string> QueryAsResultArray(string sql, ref string message);
        Dictionary<string, string> QueryAsDictionary(string tblname, string whereclause, ref string message, string listfield = "*");
        IEnumerable<Dictionary<string, string>> QueryAsListDictionaryAny(string sql, ref string message);
        //<Dictionary<string, string>> QueryAsListDictionary(string tblname, ref string message, string listfield = "*", string whereclause = null);
        //IEnumerable<Dictionary<string, string>> QueryAsListDictionary(Dictionary<string, string> prm, ref string message);
        List<object> ExecuteProc(string refproc, List<IDbDataParameter> param, string shema = null);
        string ExecuteProcNPG(string refproc);
        string SerializeObj<T>(T obj);
        T Deserialize<T>(XElement XML) where T : class, new();
        XElement RemoveAllNullNodes(XElement xmlDocument);
        //IEnumerable<Dictionary<string, string>> QueryAsPortionListDictionary(string tablename, int portion, ref string message, string listfield = "*", string whereclause = null);
        //IEnumerable<Dictionary<string, string>> QueryAsPageListDictionary(string tablename, int start, int length, ref string message, string listfield = "*", string whereclause = null, string exaddons = null, string exorder = null);
        IEnumerable<Dictionary<string, string>> QueryAsPageListDictionaryAny(string sql, int start, int length, ref string message, string exaddons = null, string exorder = null);
        //IEnumerable<Dictionary<string, string>> QueryAsPortionListDictionary(Dictionary<string, string> prm, int portion, ref string message);
        //IEnumerable<Dictionary<string, string>> QueryAsPageListDictionary(Dictionary<string, string> prm, int start, int length, ref string message, string exaddons = null, string exorder = null);
        //int GetTotalCnt(Dictionary<string, string> prm, ref string err, string search);
        //string GetTableNameByTableId(decimal tableid);
        //decimal GetTableIdByTableName(string tablename);
        // GetFieldNameByFieldId(decimal id);
        //string GetSeqName(decimal tableid);
        //decimal PutIntoDb(int mode, StTable tb);
    }
    public class NPRoutine : INPRoutine
    {
        private readonly IConfiguration _configuration ;

        private readonly string _rstring = string.Empty;//System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public NPRoutine()
        {
            //_rstring = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Укажите путь к файлу appsettings.json
                .AddJsonFile("appsettings.json")
                .Build();

            _rstring = _configuration.GetConnectionString("ConnectionString");
        }
        public NPRoutine(IConfiguration configuration)
        {
            _configuration = configuration;

            if (_configuration != null)
                _rstring = _configuration.GetConnectionString("ConnectionString");
            //_rstring = _configuration.GetConnectionString("ConnectionStrings");
            //_rstring = "Server=172.16.0.61; Port=5432; User Id=db_nsk; Password=db_nsk11!!; Database=db_nsk;";
        }

        /*
                public decimal PutIntoDb(int mode, StTable tb)
                {
                    decimal ST = 0;
                    try
                    {
                        if (mode == 1)
                        {
                            var update = $"update {tb.name.ToLower().Trim()} set ";
                            foreach (var item in tb.fields)
                            {
                                if (item.Value.fieldvalues != null && item.Value.forupdate == true)
                                    update += $"{item.Value.name.ToLower().Trim()} = @{item.Value.name.ToLower().Trim()},";
                            }
                            update = $"{update.Remove(update.Length - 1, 1)} where id = {tb.fields["ID"].fieldvalues.value}";
                            ST = decimal.Parse(tb.fields["ID"].fieldvalues.value);
                            using (var conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                            {
                                conn.Open();
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;
                                    cmd.CommandText = update;
                                    foreach (var item in tb.fields)
                                    {
                                        if (item.Value.forupdate == true)
                                        {
                                            if (!string.IsNullOrWhiteSpace(item.Value.fieldvalues.value))
                                            {
                                                DateTime dtm;
                                                NpgsqlParameter dt = new NpgsqlParameter($"@{item.Value.name.ToLower().Trim()}", NpgsqlDbType.Timestamp);
                                                if (DateTime.TryParseExact(item.Value.fieldvalues.value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(item.Value.fieldvalues.value, "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(item.Value.fieldvalues.value, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm))
                                                {
                                                    dt.Value = dtm;
                                                    cmd.Parameters.Add(dt);
                                                }
                                                else cmd.Parameters.Add(new NpgsqlParameter($"@{item.Value.name.ToLower().Trim()}", item.Value.isupper ? item.Value.fieldvalues.value.Trim().ToUpper() : item.Value.fieldvalues.value.Trim()));
                                            }
                                            else cmd.Parameters.Add(new NpgsqlParameter($"@{item.Value.name.ToLower().Trim()}", DBNull.Value));
                                        }
                                    }
                                    cmd.ExecuteNonQuery();
                                    return ST;
                                }
                            }
                        }
                        else
                        {
                            var insertfld = $"insert into {tb.name.ToLower().Trim()}(id,";
                            ST = GetSeq(GetSeqName(decimal.Parse(tb.id)));
                            var insertval = $" values({ST},";
                            foreach (var item in tb.fields)
                            {
                                if (item.Value.forcreate == true)
                                {
                                    insertfld += $"{item.Value.name.ToLower().Trim()},";
                                    insertval += $"@{item.Value.name.ToLower().Trim()},";
                                }
                            }
                            var transaction = $"{insertfld.Remove(insertfld.Length - 1, 1)}){insertval.Remove(insertval.Length - 1, 1)})";
                            using (var conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                            {
                                conn.Open();
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;
                                    cmd.CommandText = transaction;
                                    foreach (var item in tb.fields)
                                    {
                                        if (item.Value.forcreate == true)
                                        {
                                            if (!string.IsNullOrWhiteSpace(item.Value.fieldvalues.value))
                                            {
                                                DateTime dtm;
                                                NpgsqlParameter dt = new NpgsqlParameter($"@{item.Value.name.ToLower().Trim()}", NpgsqlDbType.Timestamp);
                                                if (DateTime.TryParseExact(item.Value.fieldvalues.value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(item.Value.fieldvalues.value, "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(item.Value.fieldvalues.value, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm))
                                                {
                                                    dt.Value = dtm;
                                                    cmd.Parameters.Add(dt);
                                                }
                                                else cmd.Parameters.Add(new NpgsqlParameter($"@{item.Value.name.ToLower().Trim()}", item.Value.isupper ? item.Value.fieldvalues.value.Trim().ToUpper() : item.Value.fieldvalues.value.Trim()));
                                            }
                                            else cmd.Parameters.Add(new NpgsqlParameter($"@{item.Value.name.ToLower().Trim()}", DBNull.Value));
                                        }
                                    }
                                    cmd.ExecuteNonQuery();
                                    return ST;
                                }
                            }
                        }
                    }
                    catch
                    {
                        return -1;
                    }
                }
                public string GetFieldNameByFieldId(decimal id)
                {
                    string err = string.Empty;
                    return QueryAsResultArray(StConst.StCoreTables.acc_fields, "name", $"id = {id}", ref err).FirstOrDefault();
                }
                public string GetTableNameByTableId(decimal tableid)
                {
                    string err = string.Empty;
                    return QueryAsResultArray(StConst.StCoreTables.acc_tables, "name", $"id = {tableid}", ref err).FirstOrDefault();
                }
                public decimal GetTableIdByTableName(string tablename)
                {
                    string err = string.Empty;
                    decimal dt;
                    return decimal.TryParse(QueryAsResultArray(StConst.StCoreTables.acc_tables, "id", $"name = '{tablename.ToUpper().Trim()}'", ref err).FirstOrDefault(), out dt) ? dt : -1;
                }
                public string GetSeqName(decimal tableid)
                {
                    string err = string.Empty;
                    return QueryAsResultArray(StConst.StCoreTables.acc_tables, "seqname", $"id = {tableid}", ref err).FirstOrDefault();
                }
        */
        private char NextAlfabeth(int index)
        {
            return (char)('b' + index);
        }
        private IEnumerable<string> CheckProperty(string tablename)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"select column_name from information_schema.columns where upper(table_name::text) = '{tablename.ToUpper()}' order by ordinal_position";
                    using (NpgsqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.VisibleFieldCount; i++)
                            {
                                yield return reader[i].ToString().ToLower();
                            }
                        }

                    }
                }
            }

        }
        public decimal GetSeq(string seqname, string shema = null)
        {
            try
            {
                var tbl = string.IsNullOrWhiteSpace(shema) ? $"{seqname}" : $"{shema}.{seqname}";
                decimal res = 0;
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"select nextval('{tbl}')";
                        using (NpgsqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                res = decimal.Parse(reader[0].ToString());
                            }
                        }
                    }
                }
                return res;
            }
            catch { return -1; }
        }
        public string GetTable(decimal tblid, ref string message)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand($"call gettablebyid({tblid},null)", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) return reader.GetString(0).ToLower();
                            else return null;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        public string GetField(decimal fldid, ref string message)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand($"call getfieldbyid({fldid},null)", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) return reader.GetString(0).ToLower();
                            else return null;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        public int GetIdTable(string tbl, ref string message)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand($"call getidtablebyname('{tbl}',null)", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) return reader.GetInt32(0);
                            else return -1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return -1;
            }
        }
        public int CheckGenerator(decimal tblid, ref string seqname, ref string message)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand($"call check_generator({tblid},null,null)", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                seqname = reader.GetString(0).ToLower();
                                return reader.GetInt32(1);
                            }
                            else return -1;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return -1;
            }
        }
        public decimal PutToDatabase<T>(T model, string tablename, string seqname, ref string message, string shema = null, bool dateasstring = false)
        {
            try
            {
                List<string> fields = CheckProperty(tablename).ToList();
                decimal ST = 0;
                var tbl = string.IsNullOrWhiteSpace(shema) ? $"{tablename} (" : $"{shema}.{tablename} (";
                var insertfld = $"insert into {tbl}";
                var insertval = " values(";
                foreach (var prop in model.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
                {
                    var propname = prop.Name.ToLower();
                    var pp = prop.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                    if (pp != null)
                    {
                        propname = pp.Name.ToLower();
                    }
                    if (fields.Contains(propname))
                    {
                        insertfld += $"{propname},";
                        insertval += $"@{propname},";
                    }
                }
                var transaction = $"{insertfld.Remove(insertfld.Length - 1, 1)}){insertval.Remove(insertval.Length - 1, 1)})";
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = transaction;
                        foreach (var prop in model.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
                        {
                            var val = prop.GetValue(model, null);
                            var propname = prop.Name.ToLower();
                            var pp = prop.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                            if (pp != null)
                            {
                                propname = pp.Name.ToLower();
                            }
                            if (fields.Contains(propname))
                            {
                                if (val != null)
                                {
                                    try
                                    {

                                        var isEnum = prop.PropertyType.IsEnum;
                                        if (prop.PropertyType.GenericTypeArguments.Count() > 0)
                                        {
                                            if (prop.PropertyType.GenericTypeArguments[0].IsEnum)
                                            {
                                                isEnum = true;
                                            }
                                        }
                                        if (isEnum) val = Convert.ChangeType(prop.GetValue(model, null), Enum.GetUnderlyingType(prop.GetValue(model, null).GetType()));
                                    }
                                    catch (Exception e)
                                    {
                                        var a = e.Message;
                                    }
                                }
                                if (propname == "id")
                                {
                                    var NEXT = GetSeq(seqname, shema);
                                    prop.SetValue(model, Convert.ChangeType(NEXT, prop.PropertyType), null);
                                    ST = NEXT;
                                    val = ST;
                                }
                                if (dateasstring == false)
                                {
                                    if (val != null)
                                    {
                                        DateTime dtm;
                                        NpgsqlParameter dt = new NpgsqlParameter($"@{propname}", NpgsqlDbType.Timestamp);
                                        if (DateTime.TryParseExact(val.ToString(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dtm) ||
                                            DateTime.TryParseExact(val.ToString(), "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dtm) ||
                                            DateTime.TryParseExact(val.ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dtm))
                                        {
                                            dt.Value = dtm;
                                            cmd.Parameters.Add(dt);
                                        }
                                        else cmd.Parameters.Add(new NpgsqlParameter($"@{propname}", val));
                                    }
                                    else cmd.Parameters.Add(new NpgsqlParameter($"@{propname}", DBNull.Value));
                                }
                                else cmd.Parameters.Add(new NpgsqlParameter($"@{propname}", val ?? DBNull.Value));
                            }
                        }
                        cmd.ExecuteNonQuery();
                        return ST;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return -1;
            }
        }
        public decimal UpdateFromModel<T>(T model, string tablename, ref string message, string whereclause = null, string shema = null, bool dateasstring = false)
        {

            try
            {
                List<string> fields = CheckProperty(tablename).ToList();
                decimal ST = 0;
                var tbl = string.IsNullOrWhiteSpace(shema) ? $"{tablename} set " : $"{shema}.{tablename} set ";
                var update = $"update {tbl}";
                foreach (var prop in model.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
                {
                    var propname = prop.Name.ToLower();
                    var pp = prop.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                    if (pp != null)
                    {
                        propname = pp.Name.ToLower();
                    }

                    if (fields.Contains(propname))
                    {
                        update += $"{propname} = @{propname},";
                    }
                }
                update = $"{update.Remove(update.Length - 1, 1)} where {whereclause}";
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = update;
                        foreach (var prop in model.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
                        {
                            var propname = prop.Name.ToLower();
                            var pp = prop.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                            if (pp != null)
                                propname = pp.Name.ToLower();
                            if (fields.Contains(propname))
                            {


                                if (propname == "id")
                                {
                                    var id = prop.GetValue(model, null);
                                    ST = decimal.Parse(id.ToString());
                                }
                                var val = prop.GetValue(model, null);
                                var isEnum = prop.PropertyType.IsEnum;
                                if (prop.PropertyType.GenericTypeArguments.Count() > 0)
                                {
                                    if (prop.PropertyType.GenericTypeArguments[0].IsEnum)
                                    {
                                        isEnum = true;
                                    }
                                }
                                if (isEnum && prop.GetValue(model, null) != null) val = Convert.ChangeType(prop.GetValue(model, null), Enum.GetUnderlyingType(prop.GetValue(model, null).GetType()));
                                if (dateasstring == false)
                                {
                                    if (val != null)
                                    {
                                        DateTime dtm;
                                        NpgsqlParameter dt = new NpgsqlParameter($"@{propname}", NpgsqlDbType.Timestamp);
                                        if (DateTime.TryParseExact(val.ToString(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dtm) ||
                                            DateTime.TryParseExact(val.ToString(), "dd.MM.yyyy H:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dtm) ||
                                            DateTime.TryParseExact(val.ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dtm))
                                        {
                                            dt.Value = dtm;
                                            cmd.Parameters.Add(dt);
                                        }
                                        else cmd.Parameters.Add(new NpgsqlParameter($"@{propname}", val));
                                    }
                                    else cmd.Parameters.Add(new NpgsqlParameter($"@{propname}", DBNull.Value));
                                }
                                else cmd.Parameters.Add(new NpgsqlParameter($"@{propname}", val ?? DBNull.Value));
                            }
                        }
                        cmd.ExecuteNonQuery();
                        return ST;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return -1;
            }
        }
        private IEnumerable<T> _GetFromDatabase<T>(string sql = null, string tablename = null, string whereclause = null, string shema = null, List<string> propertyname = null) where T : class, new()
        {
            DataTable tbl = new DataTable();
            if (string.IsNullOrWhiteSpace(sql) == false)
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        using (NpgsqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (reader.HasRows)
                            {
                                tbl.Load(reader);
                                var properties = typeof(T).GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                                var activePropertiesWithTypes = new List<Tuple<PropertyInfo, Type>>();

                                foreach (var property in properties)
                                {
                                    if (propertyname == null || propertyname.Contains(property.Name))
                                    {
                                        Type propType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                        activePropertiesWithTypes.Add(new Tuple<PropertyInfo, Type>(property, propType));
                                    }
                                }
                                foreach (var row in tbl.AsEnumerable())
                                {
                                    T obj = new T();

                                    foreach (var propWithType in activePropertiesWithTypes)
                                    {
                                        var propName = propWithType.Item1.Name.ToLower();
                                        var pp = propWithType.Item1.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                                        if (pp != null)
                                        {
                                            propName = pp.Name.ToLower();
                                        }
                                        if (tbl.Columns.Contains(propName))
                                        {
                                            try
                                            {
                                                object safeValue = null;
                                                if (!(row[propName] == null || row[propName] == DBNull.Value))
                                                {
                                                    var isEnum = propWithType.Item2.IsEnum;
                                                    if (propWithType.Item1.PropertyType.GenericTypeArguments.Count() > 0)
                                                    {
                                                        if (propWithType.Item1.PropertyType.GenericTypeArguments[0].IsEnum)
                                                        {
                                                            isEnum = true;
                                                        }
                                                    }

                                                    if (isEnum)
                                                    {
                                                        safeValue =
                                                            Enum.Parse(propWithType.Item2, Convert.ChangeType(row[propName], Enum.GetUnderlyingType(propWithType.Item2)).ToString());
                                                        //  Enum.ToObject(Enum.GetUnderlyingType(propWithType.Item2), Convert.ChangeType(row[propName], Enum.GetUnderlyingType(propWithType.Item2)));
                                                    }
                                                    else
                                                    {
                                                        safeValue = Convert.ChangeType(row[propName], propWithType.Item2);
                                                    }
                                                }
                                                propWithType.Item1.SetValue(obj, safeValue, null);
                                            }
                                            catch
                                            {
                                                continue;
                                            }
                                        }

                                    }
                                    yield return obj;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                List<string> fields = CheckProperty(tablename).ToList();
                var get = "select ";
                T obj = new T();
                foreach (var prop in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
                {
                    var propname = prop.Name.ToLower();
                    var pp = prop.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                    if (pp != null)
                    {
                        propname = pp.Name.ToLower();
                    }

                    if (fields.Contains(propname))
                    {
                        if (propertyname == null || propertyname.Contains(propname))
                        {
                            get += $"{propname},";
                        }
                    }
                }
                var tb = string.IsNullOrWhiteSpace(shema) ? $" {tablename} " : $" {shema}.{tablename} ";
                get = $"{get.Remove(get.Length - 1, 1)} from {tb}";
                if (string.IsNullOrWhiteSpace(whereclause)) get += "limit 100000";
                else get += $"where {whereclause}";

                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = get;
                        using (NpgsqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (reader.HasRows)
                            {
                                tbl.Load(reader);
                                var properties = typeof(T).GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                                var activePropertiesWithTypes = new List<Tuple<PropertyInfo, Type>>();

                                foreach (var property in properties)
                                {
                                    var propname = property.Name.ToLower();
                                    var pp = property.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                                    if (pp != null)
                                    {
                                        propname = pp.Name.ToLower();
                                    }
                                    if (propertyname == null || propertyname.Contains(propname))
                                    {
                                        Type propType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                        activePropertiesWithTypes.Add(new Tuple<PropertyInfo, Type>(property, propType));
                                    }
                                }
                                foreach (var row in tbl.AsEnumerable())
                                {
                                    T objv = new T();

                                    foreach (var propWithType in activePropertiesWithTypes)
                                    {
                                        var propName = propWithType.Item1.Name.ToLower();
                                        var pp = propWithType.Item1.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute), true) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                                        if (pp != null)
                                        {
                                            propName = pp.Name.ToLower();
                                        }
                                        if (tbl.Columns.Contains(propName))
                                        {
                                            try
                                            {
                                                object safeValue = (row[propName] == null || row[propName] == DBNull.Value) ? null : Convert.ChangeType(row[propName], propWithType.Item2);
                                                propWithType.Item1.SetValue(objv, safeValue, null);
                                            }
                                            catch
                                            {
                                                continue;
                                            }
                                        }

                                    }
                                    yield return objv;
                                }
                            }
                        }
                    }
                }
            }
        }
        public IEnumerable<T> GetFromDatabase<T>(ref string message, string sql = null, string tablename = null, string whereclause = null, string shema = null, List<string> propertyname = null) where T : class, new()
        {
            try
            {
                return _GetFromDatabase<T>(sql, tablename, whereclause, shema, propertyname);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        public bool DeleteFromDB(string tablename, string whereclause, ref string message)
        {
            try
            {
                var delete = $"delete from {tablename} where {whereclause}";
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = delete;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return false;
            }
        }
        public bool UpdateFromSql(string sql, ref string message)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return false;
            }
        }
        private string complicateVal(string[] value)
        {
            if (value != null)
            {
                if (value.Length > 0)
                {
                    if (value.Length == 1) return value[0];
                    else return string.Join("$$$", value);
                }
                else return null;
            }
            else return null;
        }
        /*
                public decimal UpdateFromIUFValues<T>(T model, ref string message)
                {
                    decimal ST = 0;
                    try
                    {
                        if (typeof(T) == typeof(IUFValues))
                        {
                            var md = model as IUFValues;
                            ST = md.recid ?? -1;
                            if (md.formstate == 2)
                            {
                                var update = $"update {GetTable(md.tableid, ref message)} set ";
                                foreach (var item in md.fields)
                                {
                                    update += $"{item.field} = @{item.field},";
                                }
                                update = $"{update.Remove(update.Length - 1, 1)} where id = {md.recid}";
                                using (var conn = new NpgsqlConnection(_rstring))
                                {
                                    conn.Open();
                                    using (var cmd = new NpgsqlCommand())
                                    {
                                        cmd.Connection = conn;
                                        cmd.CommandText = update;
                                        foreach (var item in md.fields)
                                        {
                                            var val = complicateVal(item.value);
                                            if (!string.IsNullOrWhiteSpace(val))
                                            {
                                                DateTime dtm;
                                                NpgsqlParameter dt = new NpgsqlParameter($"@{item.field}", NpgsqlDbType.Timestamp);
                                                if (DateTime.TryParseExact(val, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(val, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(val, "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(val, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm))
                                                {
                                                    dt.Value = dtm;
                                                    cmd.Parameters.Add(dt);
                                                }
                                                else
                                                {
                                                    switch (item.datatype)
                                                    {
                                                        case 1:
                                                            NpgsqlParameter pnum = new NpgsqlParameter($"@{item.field}", NpgsqlDbType.Bigint);
                                                            pnum.Value = val.Trim();
                                                            cmd.Parameters.Add(pnum);
                                                            break;
                                                        case 4:
                                                            NpgsqlParameter pint = new NpgsqlParameter($"@{item.field}", NpgsqlDbType.Integer);
                                                            pint.Value = val.Trim();
                                                            cmd.Parameters.Add(pint);
                                                            break;
                                                        default:
                                                            cmd.Parameters.Add(new NpgsqlParameter($"@{item.field}", (item.isupper ? val.Trim().ToUpper() : val.Trim())));
                                                            break;
                                                    }
                                                }
                                            }
                                            else
                                                cmd.Parameters.Add(new NpgsqlParameter($"@{item.field}", DBNull.Value));
                                        }
                                        cmd.ExecuteNonQuery();
                                        return ST;
                                    }
                                }
                            }
                            else
                            {
                                var senqme = string.Empty;
                                var ch = CheckGenerator(md.tableid, ref senqme, ref message);
                                var insertfld = $"insert into {GetTable(md.tableid, ref message)}(";
                                var insertval = $" values(";
                                if (ch == 1)
                                {
                                    insertfld = $"insert into {GetTable(md.tableid, ref message)}(id,";
                                    ST = GetSeq(senqme);
                                    insertval = $" values({ST},";
                                }
                                foreach (var item in md.fields)
                                {
                                    insertfld += $"{item.field},";
                                    insertval += $"@{item.field},";
                                }
                                var transaction = $"{insertfld.Remove(insertfld.Length - 1, 1)}){insertval.Remove(insertval.Length - 1, 1)})";
                                using (var conn = new NpgsqlConnection(_rstring))
                                {
                                    conn.Open();
                                    using (var cmd = new NpgsqlCommand())
                                    {
                                        cmd.Connection = conn;
                                        cmd.CommandText = transaction;
                                        foreach (var item in md.fields)
                                        {
                                            var val = complicateVal(item.value);
                                            if (!string.IsNullOrWhiteSpace(val))
                                            {
                                                DateTime dtm;
                                                NpgsqlParameter dt = new NpgsqlParameter($"@{item.field}", NpgsqlDbType.Timestamp);
                                                if (DateTime.TryParseExact(val, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(val, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(val, "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm) ||
                                                    DateTime.TryParseExact(val, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtm))
                                                {
                                                    dt.Value = dtm;
                                                    cmd.Parameters.Add(dt);
                                                }
                                                else
                                                {
                                                    switch (item.datatype)
                                                    {
                                                        case 1:
                                                            NpgsqlParameter pnum = new NpgsqlParameter($"@{item.field}", NpgsqlDbType.Bigint);
                                                            pnum.Value = val.Trim();
                                                            cmd.Parameters.Add(pnum);
                                                            break;
                                                        case 4:
                                                            NpgsqlParameter pint = new NpgsqlParameter($"@{item.field}", NpgsqlDbType.Integer);
                                                            pint.Value = val.Trim();
                                                            cmd.Parameters.Add(pint);
                                                            break;
                                                        default:
                                                            cmd.Parameters.Add(new NpgsqlParameter($"@{item.field}", (item.isupper ? val.Trim().ToUpper() : val.Trim())));
                                                            break;
                                                    }
                                                }
                                            }
                                            else
                                                cmd.Parameters.Add(new NpgsqlParameter($"@{item.field}", DBNull.Value));
                                        }
                                        cmd.ExecuteNonQuery();
                                        return ST;
                                    }
                                }
                            }
                        }
                        else return -1;
                    }
                    catch (Exception e)
                    {
                        message = e.Message;
                        return -1;
                    }
                }
         */
        public bool ExecTransaction(string[] sqlcommands, ref string message)
        {
            bool res = false;
            using (var conn = new NpgsqlConnection(_rstring))
            {
                conn.Open();
                using (NpgsqlCommand cmd = conn.CreateCommand())
                {
                    NpgsqlTransaction transaction;

                    transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;

                    try
                    {
                        for (int i = 0; i < sqlcommands.Length; i++)
                        {
                            cmd.CommandText = sqlcommands[i];
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        res = true;
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        message = e.Message;
                    }
                }
            }
            return res;
        }
        public byte[] QueryBlobValue(string tblname, string blobfield, string whereclause, ref string message)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    using (var ExecCommand = new NpgsqlCommand())
                    {
                        byte[] arr = null;
                        conn.Open();
                        ExecCommand.Connection = conn;
                        ExecCommand.CommandText = $"select {blobfield} from {tblname} where {whereclause}";
                        ExecCommand.CommandType = CommandType.Text;
                        var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                        if (reader.Read())
                        {
                            var blob = reader[0];
                            if (!string.IsNullOrWhiteSpace(blob.ToString()))
                            {
                                arr = (byte[])blob;
                                reader.Close();
                                return arr;
                            }
                            else
                            {
                                reader.Close();
                                return null;
                            }
                        }
                        reader.Close();
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        public bool UpdateBlobValue(string tblname, string blobfield, byte[] blobvalue, string whereclause, ref string message)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    using (var cmd = new NpgsqlCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = $"update {tblname} set {blobfield} = @blobfield where {whereclause}";
                        cmd.Parameters.Add("@blobfield", NpgsqlDbType.Bytea);
                        cmd.Parameters["@blobfield"].Value = blobvalue;
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
                return false;
            }
        }
        private IEnumerable<string> _QueryAsResultArray(string tblname, string listfield, string whereclause)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                using (var ExecCommand = new NpgsqlCommand())
                {
                    conn.Open();
                    ExecCommand.Connection = conn;
                    ExecCommand.CommandText = $"select {listfield} from {tblname} where {whereclause}";
                    ExecCommand.CommandType = CommandType.Text;
                    var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            yield return reader[i].ToString();
                        }
                    }
                }
            }
        }
        public IEnumerable<string> QueryAsResultArray(string tblname, string listfield, string whereclause, ref string message)
        {
            try
            {
                return _QueryAsResultArray(tblname, listfield, whereclause);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        private IEnumerable<string> _QueryAsResultArray(string sql)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                using (var ExecCommand = new NpgsqlCommand())
                {
                    conn.Open();
                    ExecCommand.Connection = conn;
                    ExecCommand.CommandText = sql;
                    ExecCommand.CommandType = CommandType.Text;
                    var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            yield return reader[i].ToString();
                        }
                    }
                }
            }
        }
        public IEnumerable<string> QueryAsResultArray(string sql, ref string message)
        {
            try
            {
                return _QueryAsResultArray(sql);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        public Dictionary<string, string> QueryAsDictionary(string tblname, string whereclause, ref string message, string listfield = "*")
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                using (var conn = new NpgsqlConnection(_rstring))
                {
                    using (var ExecCommand = new NpgsqlCommand())
                    {
                        conn.Open();
                        ExecCommand.Connection = conn;
                        ExecCommand.CommandText = string.IsNullOrEmpty(tblname) ? $"select {listfield} " : $"select {listfield} from {tblname} where {whereclause}";
                        ExecCommand.CommandType = CommandType.Text;
                        var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.VisibleFieldCount; i++)
                            {
                                dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                            }
                        }
                    }
                }
                return dic;
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        private IEnumerable<Dictionary<string, string>> _QueryAsListDictionary(string tblname, string listfield = "*", string whereclause = null)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                using (var ExecCommand = new NpgsqlCommand())
                {
                    conn.Open();
                    ExecCommand.Connection = conn;
                    ExecCommand.CommandText = $"select {listfield} from {tblname} {(whereclause != null ? $"where {whereclause}" : null)}";
                    ExecCommand.CommandType = CommandType.Text;
                    var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                        }
                        yield return dic;
                    }
                }
            }
        }
        public IEnumerable<Dictionary<string, string>> QueryAsListDictionary(string tblname, ref string message, string listfield = "*", string whereclause = null)
        {
            try
            {
                return _QueryAsListDictionary(tblname, listfield, whereclause);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }

        private IEnumerable<Dictionary<string, string>> _QueryAsListDictionaryAny(string sql)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                using (var ExecCommand = new NpgsqlCommand())
                {
                    conn.Open();
                    ExecCommand.Connection = conn;
                    ExecCommand.CommandText = sql;
                    ExecCommand.CommandType = CommandType.Text;
                    var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                        }
                        yield return dic;
                    }
                }
            }
        }
        public IEnumerable<Dictionary<string, string>> QueryAsListDictionaryAny(string sql, ref string message)
        {
            try
            {
                return _QueryAsListDictionaryAny(sql);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }


        private IEnumerable<Dictionary<string, string>> _QueryAsPortionListDictionary(string tablename, int portion, string listfield = "*", string whereclause = null)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                using (var ExecCommand = new NpgsqlCommand())
                {
                    conn.Open();
                    ExecCommand.Connection = conn;
                    ExecCommand.CommandText = $"select *  from (select {listfield} from {tablename} {(whereclause != null ? $"where {whereclause}" : null)}) a offset 0 rows fetch first {portion} rows only";
                    ExecCommand.CommandType = CommandType.Text;
                    var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                        }
                        yield return dic;
                    }
                }
            }
        }
        public IEnumerable<Dictionary<string, string>> QueryAsPortionListDictionary(string tablename, int portion, ref string message, string listfield = "*", string whereclause = null)
        {
            try
            {
                return _QueryAsPortionListDictionary(tablename, portion, listfield, whereclause);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        private IEnumerable<Dictionary<string, string>> _QueryAsPageListDictionary(string tablename, int start, int length, string listfield = "*", string whereclause = null, string exaddons = null, string exorder = null)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                using (var ExecCommand = new NpgsqlCommand())
                {
                    conn.Open();
                    ExecCommand.Connection = conn;
                    ExecCommand.CommandText = $"select *  from (select * from (select {listfield} from {tablename} {(whereclause != null ? $"where {whereclause}" : null)}) b {(!string.IsNullOrWhiteSpace(exaddons) ? $" where {exaddons}{(!string.IsNullOrWhiteSpace(exorder) ? $" {exorder}" : string.Empty)}" : $" {(!string.IsNullOrWhiteSpace(exorder) ? $"{exorder}" : string.Empty)}")}) a offset {start} rows fetch first {length} rows only";
                    ExecCommand.CommandType = CommandType.Text;
                    var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                        }
                        yield return dic;
                    }
                }
            }
        }
        public IEnumerable<Dictionary<string, string>> QueryAsPageListDictionary(string tablename, int start, int length, ref string message, string listfield = "*", string whereclause = null, string exaddons = null, string exorder = null)
        {
            try
            {
                return _QueryAsPageListDictionary(tablename, start, length, listfield, whereclause, exaddons, exorder);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        /*
                private IEnumerable<Dictionary<string, string>> _QueryAsListDictionary(Dictionary<string, string> prm)
                {
                    var sql = "select distinct b.* from ";
                    var whereclause = "";
                    var s = 0;
                    char af = 'b';
                    char tf = 'b';
                    var err = string.Empty;
                    Dictionary<string, string> join = new Dictionary<string, string>();
                    Dictionary<string, string> where = new Dictionary<string, string>();
                    Dictionary<string, StTable> tables = new Dictionary<string, StTable>();
                    //Конечный автомат
                    foreach (var item in prm)
                    {
                        if (item.Key.IndexOf("TABLE_dyhys_") != -1)
                        {
                            var tbl = item.Key.Split(new[] { "_dyhys_" }, StringSplitOptions.None);
                            if (tbl.Count() < 3)
                            {
                                var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                                sql += $"{tb} {af} ";
                                tables.Add(af.ToString(), new StTable(decimal.Parse(item.Value), false));
                            }
                            else
                            {
                                s++;
                                var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                                tf = NextAlfabeth(s);
                                join.Add(tf.ToString(), $"left join {tb} {tf} on {tf}.{tbl[2]} = {af}.id");
                                tables.Add(tf.ToString(), new StTable(decimal.Parse(item.Value), false));
                            }
                        }
                        else
                        {
                            if (s == 0)
                            {

                                if (item.Value == "'$NOT NULL'")
                                    if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is not null";
                                    else where.Add(af.ToString(), $"{af}.{item.Key} is not null");
                                else if (item.Value == "'$NULL'")
                                    if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is null";
                                    else where.Add(af.ToString(), $"{af}.{item.Key} is null");
                                else if (item.Value.IndexOf('%') != -1)
                                    if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and upper({af}.{item.Key}::text) like upper('{item.Value}')";
                                    else where.Add(af.ToString(), $"upper({af}.{item.Key}::text) like upper('{item.Value}')");
                                else
                                {
                                    var flds = tables.Where(t => t.Key == af.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;
                                    if (where.ContainsKey($"{af}"))
                                    {
                                        if (flds != null)
                                        {
                                            switch (flds.datatype.ToString())
                                            {
                                                case "1":
                                                case "4":
                                                case "3":
                                                case "5": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}"; break;
                                                case "2":
                                                case "6": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = '{item.Value}'"; break;
                                            }
                                        }
                                        else where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}";

                                    }
                                    else
                                    {
                                        if (flds != null)
                                        {
                                            switch (flds.datatype.ToString())
                                            {
                                                case "1":
                                                case "4":
                                                case "3":
                                                case "5": where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}"); break;
                                                case "2":
                                                case "6": where.Add(af.ToString(), $"{af}.{item.Key} = '{item.Value}'"); break;
                                            }
                                        }
                                        else where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}");
                                    }
                                }
                            }
                            else
                            if (item.Value == "'$NOT NULL'")
                                if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is not null";
                                else where.Add(tf.ToString(), $"{tf}.{item.Key} is not null");
                            else if (item.Value == "'$NULL'")
                                if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is null";
                                else where.Add(tf.ToString(), $"{tf}.{item.Key} is null");
                            else if (item.Value.IndexOf('%') != -1)
                                if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and upper({tf}.{item.Key}::text) like upper('{item.Value}')";
                                else where.Add(tf.ToString(), $"upper({tf}.{item.Key}::text) like upper('{item.Value}')");
                            else
                            {
                                var flds = tables.Where(t => t.Key == tf.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;

                                if (where.ContainsKey($"{tf}"))
                                {
                                    if (flds != null)
                                    {
                                        switch (flds.datatype.ToString())
                                        {
                                            case "1":
                                            case "4":
                                            case "3":
                                            case "5": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}"; break;
                                            case "2":
                                            case "6": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = '{item.Value}'"; break;
                                        }
                                    }
                                    else where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}";
                                }
                                else
                                {
                                    if (flds != null)
                                    {
                                        switch (flds.datatype.ToString())
                                        {
                                            case "1":
                                            case "4":
                                            case "3":
                                            case "5": where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}"); break;
                                            case "2":
                                            case "6": where.Add(tf.ToString(), $"{tf}.{item.Key} = '{item.Value}'"); break;
                                        }
                                    }
                                    else where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}");
                                }
                            }
                        }
                    }

                    foreach (var wh in where)
                    {
                        sql += $"{join.Where(j => j.Key == wh.Key).FirstOrDefault().Value} ";
                        if (whereclause.IndexOf("where") != -1) whereclause += $"and {wh.Value} ";
                        else whereclause += $"where {wh.Value} ";
                    }

                    if (string.IsNullOrWhiteSpace(whereclause)) whereclause = "where b.id = -1";

                    sql += whereclause;
                    sql = sql.Trim();

                    using (var conn = new NpgsqlConnection(_rstring))
                    {
                        using (var ExecCommand = new NpgsqlCommand())
                        {
                            conn.Open();
                            ExecCommand.Connection = conn;
                            ExecCommand.CommandText = sql;
                            ExecCommand.CommandType = CommandType.Text;
                            var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                            while (reader.Read())
                            {
                                Dictionary<string, string> dic = new Dictionary<string, string>();
                                for (int i = 0; i < reader.VisibleFieldCount; i++)
                                {
                                    dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                                }
                                yield return dic;
                            }
                        }
                    }
                }
        */
        /*       
         *     public IEnumerable<Dictionary<string, string>> QueryAsListDictionary(Dictionary<string, string> prm, ref string message)
               {
                   try
                   {
                       return _QueryAsListDictionary(prm);
                   }
                   catch (Exception e)
                   {
                       message = e.Message;
                       return null;
                   }
               }

               private IEnumerable<Dictionary<string, string>> _QueryAsPortionListDictionary(Dictionary<string, string> prm, int portion)
               {
                   var sql = "select distinct b.* from ";
                   var whereclause = "";
                   var s = 0;
                   char af = 'b';
                   char tf = 'b';
                   var err = string.Empty;
                   Dictionary<string, string> join = new Dictionary<string, string>();
                   Dictionary<string, string> where = new Dictionary<string, string>();
                   Dictionary<string, StTable> tables = new Dictionary<string, StTable>();
                   //Конечный автомат
                   foreach (var item in prm)
                   {
                       if (item.Key.IndexOf("TABLE_dyhys_") != -1)
                       {
                           var tbl = item.Key.Split(new[] { "_dyhys_" }, StringSplitOptions.None);
                           if (tbl.Count() < 3)
                           {
                               var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                               sql += $"{tb} {af} ";
                               tables.Add(af.ToString(), new StTable(decimal.Parse(item.Value), false));
                           }
                           else
                           {
                               s++;
                               var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                               tf = NextAlfabeth(s);
                               join.Add(tf.ToString(), $"left join {tb} {tf} on {tf}.{tbl[2]} = {af}.id");
                               tables.Add(tf.ToString(), new StTable(decimal.Parse(item.Value), false));
                           }
                       }
                       else
                       {
                           if (s == 0)
                           {

                               if (item.Value == "'$NOT NULL'")
                                   if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is not null";
                                   else where.Add(af.ToString(), $"{af}.{item.Key} is not null");
                               else if (item.Value == "'$NULL'")
                                   if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is null";
                                   else where.Add(af.ToString(), $"{af}.{item.Key} is null");
                               else if (item.Value.IndexOf('%') != -1)
                                   if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and upper({af}.{item.Key}::text) like upper('{item.Value}')";
                                   else where.Add(af.ToString(), $"upper({af}.{item.Key}::text) like upper('{item.Value}')");
                               else
                               {
                                   var flds = tables.Where(t => t.Key == af.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;
                                   if (where.ContainsKey($"{af}"))
                                   {
                                       if (flds != null)
                                       {
                                           switch (flds.datatype.ToString())
                                           {
                                               case "1":
                                               case "4":
                                               case "3":
                                               case "5": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}"; break;
                                               case "2":
                                               case "6": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = '{item.Value}'"; break;
                                           }
                                       }
                                       else where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}";

                                   }
                                   else
                                   {
                                       if (flds != null)
                                       {
                                           switch (flds.datatype.ToString())
                                           {
                                               case "1":
                                               case "4":
                                               case "3":
                                               case "5": where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}"); break;
                                               case "2":
                                               case "6": where.Add(af.ToString(), $"{af}.{item.Key} = '{item.Value}'"); break;
                                           }
                                       }
                                       else where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}");
                                   }
                               }
                           }
                           else
                           if (item.Value == "'$NOT NULL'")
                               if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is not null";
                               else where.Add(tf.ToString(), $"{tf}.{item.Key} is not null");
                           else if (item.Value == "'$NULL'")
                               if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is null";
                               else where.Add(tf.ToString(), $"{tf}.{item.Key} is null");
                           else if (item.Value.IndexOf('%') != -1)
                               if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and upper({tf}.{item.Key}::text) like upper('{item.Value}')";
                               else where.Add(tf.ToString(), $"upper({tf}.{item.Key}::text) like upper('{item.Value}')");
                           else
                           {
                               var flds = tables.Where(t => t.Key == tf.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;

                               if (where.ContainsKey($"{tf}"))
                               {
                                   if (flds != null)
                                   {
                                       switch (flds.datatype.ToString())
                                       {
                                           case "1":
                                           case "4":
                                           case "3":
                                           case "5": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}"; break;
                                           case "2":
                                           case "6": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = '{item.Value}'"; break;
                                       }
                                   }
                                   else where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}";
                               }
                               else
                               {
                                   if (flds != null)
                                   {
                                       switch (flds.datatype.ToString())
                                       {
                                           case "1":
                                           case "4":
                                           case "3":
                                           case "5": where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}"); break;
                                           case "2":
                                           case "6": where.Add(tf.ToString(), $"{tf}.{item.Key} = '{item.Value}'"); break;
                                       }
                                   }
                                   else where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}");
                               }
                           }
                       }
                   }

                   foreach (var wh in where)
                   {
                       sql += $"{join.Where(j => j.Key == wh.Key).FirstOrDefault().Value} ";
                       if (whereclause.IndexOf("where") != -1) whereclause += $"and {wh.Value} ";
                       else whereclause += $"where {wh.Value} ";
                   }

                   if (string.IsNullOrWhiteSpace(whereclause)) whereclause = "where b.id = -1";

                   sql += whereclause;
                   sql = sql.Trim();

                   using (var conn = new NpgsqlConnection(_rstring))
                   {
                       using (var ExecCommand = new NpgsqlCommand())
                       {
                           conn.Open();
                           ExecCommand.Connection = conn;
                           ExecCommand.CommandText = $"select * from ({sql}) a offset 0 rows fetch first {portion} rows only";
                           ExecCommand.CommandType = CommandType.Text;
                           var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                           while (reader.Read())
                           {
                               Dictionary<string, string> dic = new Dictionary<string, string>();
                               for (int i = 0; i < reader.VisibleFieldCount; i++)
                               {
                                   dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                               }
                               yield return dic;
                           }
                       }
                   }
               }

               public IEnumerable<Dictionary<string, string>> QueryAsPortionListDictionary(Dictionary<string, string> prm, int portion, ref string message)
               {
                   try
                   {
                       return _QueryAsPortionListDictionary(prm, portion);
                   }
                   catch (Exception e)
                   {
                       message = e.Message;
                       return null;
                   }
               }
               private IEnumerable<Dictionary<string, string>> _QueryAsPageListDictionary(Dictionary<string, string> prm, int start, int length, string exaddons = null, string exorder = null)
               {
                   var sql = "select distinct b.* from ";
                   var whereclause = "";
                   var s = 0;
                   char af = 'b';
                   char tf = 'b';
                   var err = string.Empty;
                   Dictionary<string, string> join = new Dictionary<string, string>();
                   Dictionary<string, string> where = new Dictionary<string, string>();
                   Dictionary<string, StTable> tables = new Dictionary<string, StTable>();
                   //Конечный автомат
                   foreach (var item in prm)
                   {
                       if (item.Key.IndexOf("TABLE_dyhys_") != -1)
                       {
                           var tbl = item.Key.Split(new[] { "_dyhys_" }, StringSplitOptions.None);
                           if (tbl.Count() < 3)
                           {
                               var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                               sql += $"{tb} {af} ";
                               tables.Add(af.ToString(), new StTable(decimal.Parse(item.Value), false));
                           }
                           else
                           {
                               s++;
                               var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                               tf = NextAlfabeth(s);
                               join.Add(tf.ToString(), $"left join {tb} {tf} on {tf}.{tbl[2]} = {af}.id");
                               tables.Add(tf.ToString(), new StTable(decimal.Parse(item.Value), false));
                           }
                       }
                       else
                       {
                           if (s == 0)
                           {

                               if (item.Value == "'$NOT NULL'")
                                   if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is not null";
                                   else where.Add(af.ToString(), $"{af}.{item.Key} is not null");
                               else if (item.Value == "'$NULL'")
                                   if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is null";
                                   else where.Add(af.ToString(), $"{af}.{item.Key} is null");
                               else if (item.Value.IndexOf('%') != -1)
                                   if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and upper({af}.{item.Key}::text) like upper('{item.Value}')";
                                   else where.Add(af.ToString(), $"upper({af}.{item.Key}::text) like upper('{item.Value}')");
                               else
                               {
                                   var flds = tables.Where(t => t.Key == af.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;
                                   if (where.ContainsKey($"{af}"))
                                   {
                                       if (flds != null)
                                       {
                                           switch (flds.datatype.ToString())
                                           {
                                               case "1":
                                               case "4":
                                               case "3":
                                               case "5": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}"; break;
                                               case "2":
                                               case "6": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = '{item.Value}'"; break;
                                           }
                                       }
                                       else where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}";

                                   }
                                   else
                                   {
                                       if (flds != null)
                                       {
                                           switch (flds.datatype.ToString())
                                           {
                                               case "1":
                                               case "4":
                                               case "3":
                                               case "5": where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}"); break;
                                               case "2":
                                               case "6": where.Add(af.ToString(), $"{af}.{item.Key} = '{item.Value}'"); break;
                                           }
                                       }
                                       else where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}");
                                   }
                               }
                           }
                           else
                           if (item.Value == "'$NOT NULL'")
                               if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is not null";
                               else where.Add(tf.ToString(), $"{tf}.{item.Key} is not null");
                           else if (item.Value == "'$NULL'")
                               if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is null";
                               else where.Add(tf.ToString(), $"{tf}.{item.Key} is null");
                           else if (item.Value.IndexOf('%') != -1)
                               if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and upper({tf}.{item.Key}::text) like upper('{item.Value}')";
                               else where.Add(tf.ToString(), $"upper({tf}.{item.Key}::text) like upper('{item.Value}')");
                           else
                           {
                               var flds = tables.Where(t => t.Key == tf.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;

                               if (where.ContainsKey($"{tf}"))
                               {
                                   if (flds != null)
                                   {
                                       switch (flds.datatype.ToString())
                                       {
                                           case "1":
                                           case "4":
                                           case "3":
                                           case "5": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}"; break;
                                           case "2":
                                           case "6": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = '{item.Value}'"; break;
                                       }
                                   }
                                   else where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}";
                               }
                               else
                               {
                                   if (flds != null)
                                   {
                                       switch (flds.datatype.ToString())
                                       {
                                           case "1":
                                           case "4":
                                           case "3":
                                           case "5": where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}"); break;
                                           case "2":
                                           case "6": where.Add(tf.ToString(), $"{tf}.{item.Key} = '{item.Value}'"); break;
                                       }
                                   }
                                   else where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}");
                               }
                           }
                       }
                   }

                   foreach (var wh in where)
                   {
                       sql += $"{join.Where(j => j.Key == wh.Key).FirstOrDefault().Value} ";
                       if (whereclause.IndexOf("where") != -1) whereclause += $"and {wh.Value} ";
                       else whereclause += $"where {wh.Value} ";
                   }

                   if (string.IsNullOrWhiteSpace(whereclause)) whereclause = "where b.id = -1";

                   sql += whereclause;
                   sql = sql.Trim();

                   using (var conn = new NpgsqlConnection(_rstring))
                   {
                       using (var ExecCommand = new NpgsqlCommand())
                       {
                           conn.Open();
                           ExecCommand.Connection = conn;
                           ExecCommand.CommandText = $"select * from (select * from ({sql}) az {(!string.IsNullOrWhiteSpace(exaddons) ? $" where {exaddons}{(!string.IsNullOrWhiteSpace(exorder) ? $" {exorder}" : string.Empty)}" : $" {(!string.IsNullOrWhiteSpace(exorder) ? $"{exorder}" : string.Empty)}")}) a offset {start} rows fetch first {length} rows only";
                           ExecCommand.CommandType = CommandType.Text;
                           var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                           while (reader.Read())
                           {
                               Dictionary<string, string> dic = new Dictionary<string, string>();
                               for (int i = 0; i < reader.VisibleFieldCount; i++)
                               {
                                   dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                               }
                               yield return dic;
                           }
                       }
                   }
               }

               public IEnumerable<Dictionary<string, string>> QueryAsPageListDictionary(Dictionary<string, string> prm, int start, int length, ref string message, string exaddons = null, string exorder = null)
               {
                   try
                   {
                       return _QueryAsPageListDictionary(prm, start, length, exaddons, exorder);
                   }
                   catch (Exception e)
                   {
                       message = e.Message;
                       return null;
                   }
               }
       */
        private IEnumerable<Dictionary<string, string>> _QueryAsPageListDictionaryAny(string sql, int start, int length, string exaddons = null, string exorder = null)
        {
            using (var conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (var ExecCommand = new NpgsqlCommand())
                {
                    conn.Open();
                    ExecCommand.Connection = conn;
                    ExecCommand.CommandText = $"select *  from (select a.* from ({sql}) a {(!string.IsNullOrWhiteSpace(exaddons) ? $" where {exaddons} {(!string.IsNullOrWhiteSpace(exorder) ? $"{exorder}" : string.Empty)}" : $" {(!string.IsNullOrWhiteSpace(exorder) ? $"{exorder}" : string.Empty)}")}) zz offset {start} rows fetch first {length} rows only";
                    ExecCommand.CommandType = CommandType.Text;
                    var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        for (int i = 0; i < reader.VisibleFieldCount; i++)
                        {
                            dic.Add(reader.GetName(i).ToUpper(), reader[i].ToString());
                        }
                        yield return dic;
                    }
                }
            }
        }
        public IEnumerable<Dictionary<string, string>> QueryAsPageListDictionaryAny(string sql, int start, int length, ref string message, string exaddons = null, string exorder = null)
        {
            try
            {
                return _QueryAsPageListDictionaryAny(sql, start, length, exaddons, exorder);
            }
            catch (Exception e)
            {
                message = e.Message;
                return null;
            }
        }
        public List<object> ExecuteProc(string refproc, List<IDbDataParameter> param, string shema = null)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                List<object> l = new List<object>();
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = (shema != null ? $"{shema}.{refproc}" : refproc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    NpgsqlCommandBuilder.DeriveParameters(cmd);
                    foreach (var item in param)
                    {
                        if (item.Direction == ParameterDirection.Input)
                        {
                            cmd.Parameters[item.ParameterName].Value = item.Value;
                        }
                    }
                    cmd.ExecuteNonQuery();
                    foreach (var item in param)
                    {
                        if (item.Direction == ParameterDirection.Output)
                        {
                            l.Add(cmd.Parameters[item.ParameterName].Value);
                        }
                    }
                }
                return l;
            }
        }

        public string ExecuteProcNPG(string refproc)
        {
            using (var conn = new NpgsqlConnection(_rstring))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(refproc, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) return reader.GetString(0).ToLower();
                        else return null;
                    }
                }
            }

        }

        public string SerializeObj<T>(T obj)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer xser = new XmlSerializer(typeof(T));
                xser.Serialize(writer, obj);
                return writer.ToString();
            }
        }
        public T Deserialize<T>(XElement XML) where T : class, new()
        {
            using (TextReader reader = new StringReader(XML.ToString()))
            {

                T obj = new T();

                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlReaderSettings settings = new XmlReaderSettings();
                XmlReader XmlReader = XmlReader.Create(reader, settings);

                obj = (T)serializer.Deserialize(XmlReader);
                return obj;

            }
        }
        public XElement RemoveAllNullNodes(XElement xmlDocument)
        {
            if (!xmlDocument.HasElements)
            {
                if (!string.IsNullOrEmpty(xmlDocument.Value))
                {
                    XElement xElement = new XElement(xmlDocument.Name.LocalName);
                    xElement.Value = xmlDocument.Value;
                    return xElement;
                }
                else return null;

            }

            var res = new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNullNodes(el)));
            return res;
        }
        /*
                private int _GetTotalCnt(Dictionary<string, string> prm, string search)
                {
                    var sql = "select distinct b.* from ";
                    var whereclause = "";
                    var s = 0;
                    char af = 'b';
                    char tf = 'b';
                    var err = string.Empty;
                    Dictionary<string, string> join = new Dictionary<string, string>();
                    Dictionary<string, string> where = new Dictionary<string, string>();
                    Dictionary<string, StTable> tables = new Dictionary<string, StTable>();
                    //Конечный автомат
                    foreach (var item in prm)
                    {
                        if (item.Key.IndexOf("TABLE_dyhys_") != -1)
                        {
                            var tbl = item.Key.Split(new[] { "_dyhys_" }, StringSplitOptions.None);
                            if (tbl.Count() < 3)
                            {
                                var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                                sql += $"{tb} {af} ";
                                tables.Add(af.ToString(), new StTable(decimal.Parse(item.Value), false));
                            }
                            else
                            {
                                s++;
                                var tb = GetTableNameByTableId(decimal.Parse(item.Value));
                                tf = NextAlfabeth(s);
                                join.Add(tf.ToString(), $"left join {tb} {tf} on {tf}.{tbl[2]} = {af}.id");
                                tables.Add(tf.ToString(), new StTable(decimal.Parse(item.Value), false));
                            }
                        }
                        else
                        {
                            if (s == 0)
                            {

                                if (item.Value == "'$NOT NULL'")
                                    if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is not null";
                                    else where.Add(af.ToString(), $"{af}.{item.Key} is not null");
                                else if (item.Value == "'$NULL'")
                                    if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} is null";
                                    else where.Add(af.ToString(), $"{af}.{item.Key} is null");
                                else if (item.Value.IndexOf('%') != -1)
                                    if (where.ContainsKey($"{af}")) where[$"{af}"] = $"{where[$"{af}"]} and upper({af}.{item.Key}::text) like upper('{item.Value}')";
                                    else where.Add(af.ToString(), $"upper({af}.{item.Key}::text) like upper('{item.Value}')");
                                else
                                {
                                    var flds = tables.Where(t => t.Key == af.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;
                                    if (where.ContainsKey($"{af}"))
                                    {
                                        if (flds != null)
                                        {
                                            switch (flds.datatype.ToString())
                                            {
                                                case "1":
                                                case "4":
                                                case "3":
                                                case "5": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}"; break;
                                                case "2":
                                                case "6": where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = '{item.Value}'"; break;
                                            }
                                        }
                                        else where[$"{af}"] = $"{where[$"{af}"]} and {af}.{item.Key} = {item.Value}";

                                    }
                                    else
                                    {
                                        if (flds != null)
                                        {
                                            switch (flds.datatype.ToString())
                                            {
                                                case "1":
                                                case "4":
                                                case "3":
                                                case "5": where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}"); break;
                                                case "2":
                                                case "6": where.Add(af.ToString(), $"{af}.{item.Key} = '{item.Value}'"); break;
                                            }
                                        }
                                        else where.Add(af.ToString(), $"{af}.{item.Key} = {item.Value}");
                                    }
                                }
                            }
                            else
                            if (item.Value == "'$NOT NULL'")
                                if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is not null";
                                else where.Add(tf.ToString(), $"{tf}.{item.Key} is not null");
                            else if (item.Value == "'$NULL'")
                                if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} is null";
                                else where.Add(tf.ToString(), $"{tf}.{item.Key} is null");
                            else if (item.Value.IndexOf('%') != -1)
                                if (where.ContainsKey($"{tf}")) where[$"{tf}"] = $"{where[$"{tf}"]} and upper({tf}.{item.Key}::text) like upper('{item.Value}')";
                                else where.Add(tf.ToString(), $"upper({tf}.{item.Key}::text) like upper('{item.Value}')");
                            else
                            {
                                var flds = tables.Where(t => t.Key == tf.ToString()).FirstOrDefault().Value.fields.Where(f => f.Value.name == item.Key).FirstOrDefault().Value;

                                if (where.ContainsKey($"{tf}"))
                                {
                                    if (flds != null)
                                    {
                                        switch (flds.datatype.ToString())
                                        {
                                            case "1":
                                            case "4":
                                            case "3":
                                            case "5": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}"; break;
                                            case "2":
                                            case "6": where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = '{item.Value}'"; break;
                                        }
                                    }
                                    else where[$"{tf}"] = $"{where[$"{tf}"]} and {tf}.{item.Key} = {item.Value}";
                                }
                                else
                                {
                                    if (flds != null)
                                    {
                                        switch (flds.datatype.ToString())
                                        {
                                            case "1":
                                            case "4":
                                            case "3":
                                            case "5": where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}"); break;
                                            case "2":
                                            case "6": where.Add(tf.ToString(), $"{tf}.{item.Key} = '{item.Value}'"); break;
                                        }
                                    }
                                    else where.Add(tf.ToString(), $"{tf}.{item.Key} = {item.Value}");
                                }
                            }
                        }
                    }

                    foreach (var wh in where)
                    {
                        sql += $"{join.Where(j => j.Key == wh.Key).FirstOrDefault().Value} ";
                        if (whereclause.IndexOf("where") != -1) whereclause += $"and {wh.Value} ";
                        else whereclause += $"where {wh.Value} ";
                    }

                    if (string.IsNullOrWhiteSpace(whereclause)) whereclause = "where b.id = -1";

                    sql += whereclause;
                    sql = sql.Trim();
                    sql = $"select count(*) from ({sql}) a {(!string.IsNullOrWhiteSpace(search) ? $" where {search}" : string.Empty)}";

                    using (var conn = new NpgsqlConnection(_rstring))
                    {
                        using (var ExecCommand = new NpgsqlCommand())
                        {
                            conn.Open();
                            ExecCommand.Connection = conn;
                            ExecCommand.CommandText = sql;
                            ExecCommand.CommandType = CommandType.Text;
                            var reader = ExecCommand.ExecuteReader(CommandBehavior.CloseConnection);
                            if (reader.Read())
                            {
                                return int.Parse(reader[0].ToString());
                            }
                            else return 0;
                        }
                    }
                }

                public int GetTotalCnt(Dictionary<string, string> prm, ref string err, string search)
                {
                    try
                    {
                        return _GetTotalCnt(prm, search);
                    }
                    catch (Exception e)
                    {
                        err = e.Message;
                        return 0;
                    }
                }
        */
    }
    public class ODDANP
    {
        public INPRoutine Routine { get; set; }

        public ODDANP(INPRoutine routine)
        {
            Routine = routine;
        }

        public ODDANP()
        {
            /*
            string s = Directory.GetCurrentDirectory();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Обратите внимание на эту часть
                .AddJsonFile("appsettings.json") // Путь к вашему файлу appsettings.json
                .Build();
            */
            /*
            string assemblyLocation = typeof(ConnectionStrings).Assembly.Location;
            string currentDir = System.IO.Directory.GetCurrentDirectory();
            currentDir = System.AppContext.BaseDirectory;
            currentDir = AppDomain.CurrentDomain.BaseDirectory;
            currentDir = Directory.GetCurrentDirectory();
            currentDir = Environment.CurrentDirectory;
            currentDir = System.AppDomain.CurrentDomain.BaseDirectory;
            currentDir = System.Environment.CurrentDirectory;
            //string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            /*
            currentDir = Assembly.Location;
            currentDir = Application.StartupPath;
            currentDir = Application.ExecutablePath;
            */
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(assemblyLocation);
            string filePath = Path.Combine(directory, "appsettings.json");

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile(filePath)
                .Build();

            Routine = new NPRoutine(configuration);
        }
    }
}
