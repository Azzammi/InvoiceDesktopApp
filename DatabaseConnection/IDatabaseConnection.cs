using System;

namespace DatabaseConnection
{
    public interface IDatabaseConnection
    {
        bool isConnected();
        bool isDisconnected();                
    }
}
