using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_AddrOfPinnedObject_AddrOfPinnedObject_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_AddrOfPinnedObject_AddrOfPinnedObject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\AddrOfPinnedObject\\AddrOfPinnedObject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
