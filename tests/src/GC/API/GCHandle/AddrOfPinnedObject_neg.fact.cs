using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_AddrOfPinnedObject_neg_AddrOfPinnedObject_neg_
    {
        [Fact]
        public void _GCHandle_AddrOfPinnedObject_neg_AddrOfPinnedObject_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\AddrOfPinnedObject_neg\\AddrOfPinnedObject_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
