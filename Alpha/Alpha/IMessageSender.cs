using System.Threading;
using System.Threading.Tasks;
using Contracts;

namespace Alpha
{
    public interface IMessageSender
    {
        Task Put(WorldMessage message);
    }
}