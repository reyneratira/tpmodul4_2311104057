class KodePos
{
    private static Dictionary<string, string> kodePosTable = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public static string GetKodePos(string kelurahan)
    {
        return kodePosTable.ContainsKey(kelurahan) ? kodePosTable[kelurahan] : "Kode pos tidak ditemukan";
    }
}

class DoorMachine
{
    private enum State { Locked, Unlocked }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Locked;
        Console.WriteLine("Pintu terkunci");
    }

    public void Unlock()
    {
        currentState = State.Unlocked;
        Console.WriteLine("Pintu tidak terkunci");
    }

    public void Lock()
    {
        currentState = State.Locked;
        Console.WriteLine("Pintu terkunci");
    }
}

class Program
{
    static void Main()
    {
        // Table-driven approach
        Console.WriteLine("Masukkan kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine("Kode Pos: " + KodePos.GetKodePos(kelurahan));

        // State-based construction
        DoorMachine door = new DoorMachine();
        Console.WriteLine("Membuka pintu...");
        door.Unlock();
        Console.WriteLine("Mengunci pintu kembali...");
        door.Lock();
    }
}