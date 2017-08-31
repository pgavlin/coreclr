using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_HandleCopy_HandleCopy_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_HandleCopy_HandleCopy_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\HandleCopy\\HandleCopy.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
