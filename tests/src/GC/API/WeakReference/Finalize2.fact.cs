using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_Finalize2_Finalize2_
    {
        [Fact]
        public void _WeakReference_Finalize2_Finalize2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\Finalize2\\Finalize2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
