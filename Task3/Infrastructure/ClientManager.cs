namespace Task3;

public class ClientManager<T> where T : Client
{
    private List<T> clients = new List<T>();
    private int nextClientId = 1;

    public bool CreateClient(T client)
    {
        T existingClient = clients.Find(x => x.ClientId == client.ClientId);
        if (existingClient == null)
        {
            client.ClientId = nextClientId++;
            clients.Add(client);
            return true;
        }
        Console.WriteLine("Client already exists.");
        return false;
    }

    public bool Delete(int clientId)
    {
        int res = clients.RemoveAll(x => x.ClientId == clientId);
        return res > 0;
    }

    public T GetClientById(int clientId)
    {
        T client = clients.Find(x => x.ClientId == clientId);
        if (client != null)
        {
            return client;
        }
        else
        {
            return default(T);
        }
    }

    public List<T> GetClients()
    {
        return clients;
    }

    public bool UpdateClient(T client)
    {
        T existingClient = clients.Find(x => x.ClientId == client.ClientId);
        if (existingClient == null)
        {
            return false;
        }
        existingClient.Name = client.Name;
        existingClient.ContactInfo = client.ContactInfo;
        return true;
    }
}