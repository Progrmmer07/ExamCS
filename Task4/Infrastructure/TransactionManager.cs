namespace Task4;

public class TransactionManager
{
    private List<Transaction> transactions = new List<Transaction>();

    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }
    
    public List<Transaction> GetTransactionsByYear(int year)
    {
        return transactions.Where(t => t.Date.Year == year).ToList();
    }

    public decimal GetTotalSalesVolume(DateTime startDate, DateTime endDate)
    {
        decimal totalSalesVolume = 0;

        for (int i = 0; i < transactions.Count; i++)
        {
            Transaction t = transactions[i];
            if (t.Date >= startDate && t.Date <= endDate && t.TransactionType == TransactionType.Purchase)
            {
                totalSalesVolume += t.Amount;
            }
        }

        return totalSalesVolume;
    }

    public Transaction GetFirstTransaction()
    {
        return transactions.OrderBy(t => t.Date).FirstOrDefault();
    }

    public Transaction GetLastTransaction()
    {
        return transactions.OrderByDescending(t => t.Date).FirstOrDefault();
    }
}