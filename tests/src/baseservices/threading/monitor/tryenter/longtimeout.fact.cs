using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_tryenter_longtimeout_longtimeout_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_tryenter_longtimeout_longtimeout_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\tryenter\\longtimeout\\longtimeout.cmd");
        }
    }
}
