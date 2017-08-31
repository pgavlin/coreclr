using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Normal_Normal_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Normal_Normal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Normal\\Normal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
