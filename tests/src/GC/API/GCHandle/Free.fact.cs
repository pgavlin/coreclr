using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Free_Free_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Free_Free_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Free\\Free.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
