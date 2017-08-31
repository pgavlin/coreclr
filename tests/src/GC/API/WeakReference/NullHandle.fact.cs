using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_NullHandle_NullHandle_
    {
        [Fact]
        public void _WeakReference_NullHandle_NullHandle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\NullHandle\\NullHandle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
