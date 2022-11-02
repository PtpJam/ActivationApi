using ActivationApi.Models.Contex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ActivationApi.Models.Repos
{
    public class DeviceRepo : IDeviceRepo<Device>
    {
        protected ActivationScannerContext _context { get; private set; }
        public DeviceRepo()
        {
            _context = new ActivationScannerContext();
        }


        public void Add(Device entity)
        {
           _context.Add(entity);    
            _context.SaveChanges();
        }

        public IEnumerable<Device> Get() => _context.Devices;
        
    }
}
