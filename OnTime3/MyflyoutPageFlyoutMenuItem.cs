using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime3
{
    public class MyflyoutPageFlyoutMenuItem
    {
        public MyflyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(MyflyoutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}