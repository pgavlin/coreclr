using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_ToFromIntPtr_ToFromIntPtr_
    {
        [Fact]
        public void _GCHandle_ToFromIntPtr_ToFromIntPtr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\ToFromIntPtr\\ToFromIntPtr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
