using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using log4net;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;

using FSCollections;
using System.Windows.Forms;
using System.Data.Common;

namespace InvoiceOTC.Repository.Service
{
    public class InvoiceRepository : IInvoiceRepository
    {
        #region Declaration
        protected string m_Sql;
        protected ILog m_Log;
        protected IDapperContext context;
        protected InvoiceDetailRepository m_Detail;
        #endregion

        #region Constructor
        public InvoiceRepository()
        {
            context = new DapperContext();
            m_Detail = new InvoiceDetailRepository();
        }
        public InvoiceRepository(ILog log)
        {
            m_Log = log;
            context = new DapperContext();
            m_Detail = new InvoiceDetailRepository(log);
        }
        #endregion

        #region Methods
        public int Delete(Invoice obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Delete From Invoice Where invoiceID = @invoiceID";
                result = context.db.Execute(m_Sql, obj);

                foreach(InvoiceDetail detail in obj.detail)
                {
                    m_Detail.Delete(detail);
                }
            }
            catch
            {

            }

            return result;
        }

        private IEnumerable<Invoice> MappingRecordToObj(string sql, object param = null)
        {
            IEnumerable<Invoice> listOfInvoice = null;
            try
            {
                var invoiceDictionary = new Dictionary<int, Invoice>();

                listOfInvoice = context.db.Query<Invoice, InvoiceDetail, Invoice>(
                        sql,
                        (invoice, invoiceDetail) =>
                        {
                            Invoice invoiceEntry;

                            if (!invoiceDictionary.TryGetValue(invoice.invoiceID, out invoiceEntry))
                            {
                                invoiceEntry = invoice;
                                invoiceEntry.detail = new List<InvoiceDetail>();
                            //invoiceEntry.p_Items = new FSBindingList<InvoiceDetail>(detail);
                            invoiceDictionary.Add(invoiceEntry.invoiceID, invoiceEntry);
                            }

                            invoiceEntry.detail.Add(invoiceDetail);
                            return invoiceEntry;
                        },param,
                        splitOn: "detailID")
                    .Distinct();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return listOfInvoice;
        }

        /// <summary>
        /// Using Custom class to achieve sorting ability. Dapper ORM Multi Mapping One to Many
        /// </summary>
        /// <returns></returns>
        public FSBindingList<Invoice> GetAllSorted()
        {
            IList<Invoice> listOfInvoice = new List<Invoice>();
            try
            {
                m_Sql = @"SELECT * FROM Invoice AS A INNER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID;";               

                var invoiceDictionary = new Dictionary<int, Invoice>();

                listOfInvoice = context.db.Query<Invoice, InvoiceDetail, Invoice>(
                        m_Sql,
                        (invoice, invoiceDetail) =>
                        {
                            Invoice invoiceEntry;

                            if (!invoiceDictionary.TryGetValue(invoice.invoiceID, out invoiceEntry))
                            {
                                invoiceEntry = invoice;

                                //Declare the list type first
                                List<InvoiceDetail> detail = new List<InvoiceDetail>();

                                //Convert it to custom list
                                invoiceEntry.p_Items = new FSBindingList<InvoiceDetail>(detail);
                                invoiceDictionary.Add(invoiceEntry.invoiceID, invoiceEntry);
                            }

                            //Add invoiceDetail item to Invoice
                            invoiceEntry.p_Items.Add(invoiceDetail);
                            return invoiceEntry;
                        },
                        splitOn: "rotiID")
                    .Distinct()
                    .ToList();
            }
            catch
            {

            }

            return new FSBindingList<Invoice>(listOfInvoice);
        }

        public IList<Invoice> GetAll()
        {
            IList<Invoice> listOfInvoice = new List<Invoice>();
            try
            {
                m_Sql = @"SELECT * FROM Invoice AS A LEFT OUTER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID;";

                listOfInvoice = MappingRecordToObj(m_Sql).ToList();
            }
            catch
            {

            }
            return listOfInvoice;
        }

        public Invoice GetInvoiceByID(int invoiceID)
        {
            Invoice invoice = null;
            try
            {
                m_Sql = @"SELECT * FROM Invoice AS A INNER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID WHERE A.invoiceID = @invoiceID;";

                invoice = MappingRecordToObj(m_Sql, new { invoiceID }).SingleOrDefault();
            }
            catch
            {

            }      
            return invoice;
        }

        public Invoice GetInvoiceByNomor(string nomorInvoice)
        {
            Invoice invoiceTU = null;
            try
            {
                m_Sql = @"SELECT * FROM Invoice AS A LEFT OUTER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID WHERE A.nomorInvoice = @nomorInvoice;";

                invoiceTU = MappingRecordToObj(m_Sql, new { nomorInvoice }).SingleOrDefault();
            }
            catch
            {

            }
            return invoiceTU;
        }

        public IList<Invoice> GetInvoicesByNomor(string nomorInvoice)
        {
            IList<Invoice> listOfDetail = new List<Invoice>();
            try
            {
                m_Sql = @"SELECT * FROM  Invoice AS A LEFT OUTER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID WHERE A.nomorinvoice LIKE @nomorInvoice;";

                nomorInvoice = string.Format("%{0}%", nomorInvoice);
                listOfDetail = MappingRecordToObj(m_Sql, new { nomorInvoice }).ToList();
            }
            catch
            {

            }
            return listOfDetail;
        }

        public int Save(Invoice obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"INSERT INTO INVOICE (nomorinvoice
                            ,dueDate
                            ,outletCode
                            ,subTotal
                            ,ppn
                            ,total
                            ,issuedDate
                            ,isPPN
                            ,nomorPO
                            ,periode
                            ,pengguna
                            ,idpayment
                            ,isPayed)
                        VALUES 
                            (@nomorInvoice
                            ,@dueDate
                            ,@outletCode
                            ,@subTotal
                            ,@ppn
                            ,@total
                            ,@issuedDate
                            ,@isPPN
                            ,@nomorPO
                            ,@periode
                            ,@pengguna
                            ,@idPayment
                            ,@isPayed); 

                            SELECT currVal('invoiced_seq');";

                //result = context.db.Execute(m_Sql, obj);
                result = context.db.Query<int>(m_Sql, 
                                                    new { obj.nomorInvoice, obj.dueDate,
                                                        obj.outletCode, obj.subTotal,
                                                        obj.ppn, obj.total,
                                                        obj.issuedDate, obj.isPPN,
                                                        obj.nomorPO, obj.periode,
                                                        obj.pengguna, obj.idPayment,
                                                        obj.isPayed }).SingleOrDefault();

                foreach(InvoiceDetail detail in obj.detail)
                {
                    detail.invoiceID = result;
                    m_Detail.Save(detail);
                }
            }
            catch
            {

            }
            return result; 
        }

        public int Update(Invoice obj)
        {
            var result = 0;
            try
            {
                m_Sql = @"Update INVOICE SET nomorinvoice = @nomorInvoice, " +
                        "dueDate = @dueDate, " +
                        "outletCode = @outletCode, " +
                        "subTotal = @subTotal, " +
                        "ppn = @ppn, " +
                        "total = @total, " +
                        "issuedDate = @issuedDate, " +
                        "isPPN = @isPPN, " +
                        "nomorPO = @nomorPO " +
                        //"pengguna = '{0}' " +
                        "WHERE InvoiceID = @invoiceID";

                result = context.db.Execute(m_Sql, obj);

                foreach (InvoiceDetail detail in obj.detail)
                {
                    m_Detail.Update(detail);
                }
            }
            catch
            {
               
            }
            return result;
        }

        public string GetInvoiceID(string nomorInvoice)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
