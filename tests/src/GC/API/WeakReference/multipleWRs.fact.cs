using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_multipleWRs_multipleWRs_
    {
        [Fact]
        public void _WeakReference_multipleWRs_multipleWRs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\multipleWRs\\multipleWRs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
