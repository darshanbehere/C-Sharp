using System;
using System.Data;
using System.Data.SqlClient;
class ShowAccount{
public static void Main(){
  SqlConnection scon;
  SqlDataAdapter sda;
  DataSet ds;
  int cnt;
  double bal;
  string nm;
  try{
    scon = new SqlConnection(server=******\\SqlEXPRESS;uid=sa;pwd=******;database="santiago");
    sda = new SqlAdapter("select * from accouts where acctype='saving';",scon);
    ds = new DataSet();
    sda.fill(ds,"acc");
    cnt = ds.Tables["acc"].Rows.Count;
    for(int i=0;i<cnt;i++){
      nm = Convert.ToString(ds.Tables["acc"].Rows[i]["accnm"]);
      bal = Convert.ToDouble(ds.Tables["acc"].Rows[i]["balance"]);
      Console.WriteLine(nm+"\t"+bal);
    }
  }
  catch(Exception ex){
    Console.WriteLine(ex.getMessage)
  }
}
}
