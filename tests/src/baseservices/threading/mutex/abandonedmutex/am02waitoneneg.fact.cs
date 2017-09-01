using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_abandonedmutex_am02waitoneneg_am02waitoneneg_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am02waitoneneg_am02waitoneneg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am02waitoneneg\\am02waitoneneg.cmd");
        }
    }
}
