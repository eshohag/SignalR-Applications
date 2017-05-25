using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace HitCounterApp
{
    [HubName("hitCounterHub")]
    public class HitCounterHub : Hub
    {
        static int _hitCount = 0;
        public void RecordHit()
        {
            _hitCount += 1;
            Clients.All.onRecordHit(_hitCount);
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            _hitCount -= 1;
            Clients.All.onRecordHit(_hitCount);
            return base.OnDisconnected(stopCalled);
        }
    }
}