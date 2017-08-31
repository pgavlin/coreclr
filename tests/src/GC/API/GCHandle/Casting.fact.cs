using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Casting_Casting_
    {
        [Fact]
        public void _GCHandle_Casting_Casting_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Casting\\Casting.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
