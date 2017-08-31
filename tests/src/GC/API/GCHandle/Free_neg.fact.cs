using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Free_neg_Free_neg_
    {
        [Fact]
        public void _GCHandle_Free_neg_Free_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Free_neg\\Free_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
