using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_tryenter_longtimeout_longtimeout_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_tryenter_longtimeout_longtimeout_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\tryenter\\longtimeout\\longtimeout.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
