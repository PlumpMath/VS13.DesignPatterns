//	File:	PersonGateway.cs
//	Author:	J. Heary
//	Date:	03/26/12
//	Desc:	Sample Table Data Gateway from Patterns of Enterprise Application Architecture.
//	---------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class PersonClient {
        public void main() {
            PersonGateway person = new PersonGateway();
            person.LoadAll();
            person[1]["lastname"] = "Heary";
            person.Holder.Update();
        }
    }
    
    class PersonGateway:DataGateway {
        public override string TableName { get { return "Person"; } }
    }
    
    abstract class DataGateway {
        public DataSetHolder Holder;

        protected DataGateway() { Holder = new DataSetHolder(); }
        protected DataGateway(DataSetHolder holder) { Holder = holder; }
        public abstract string TableName { get; }
        
        public void LoadAll() {
            String commandString = String.Format("SELECT * FROM {0}",TableName);
            Holder.FillData(commandString,TableName);
        }
        public DataTable Table { get { return Holder.Data.Tables[TableName]; } }
        public DataRow this[long key] { get { return Table.Select(String.Format("id={0}",key))[0]; } }
    }
    
    class DataSetHolder {
        private Hashtable DataAdapters = new Hashtable();
        public DataSet Data = new DataSet();
        public DataSetHolder() { }

        //public DataTable this[string tableName] { get { return Data.Tables[tableName]; } }
        public void FillData(string query,string tableName) { }
        public void Update() { }
        public long Insert(string lastName,string firstName,int numberOfDependents) { return 0; }
    }
}
