using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Target_neg_Target_neg_
    {
        [Fact]
        public void _GCHandle_Target_neg_Target_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Target_neg\\Target_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
