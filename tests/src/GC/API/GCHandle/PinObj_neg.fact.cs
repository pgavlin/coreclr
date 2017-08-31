using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_PinObj_neg_PinObj_neg_
    {
        [Fact]
        public void _GCHandle_PinObj_neg_PinObj_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\PinObj_neg\\PinObj_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
