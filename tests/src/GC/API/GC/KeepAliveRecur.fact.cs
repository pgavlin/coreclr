using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_KeepAliveRecur_KeepAliveRecur_
    {
        [OuterLoop]
        [Fact]
        public void _GC_KeepAliveRecur_KeepAliveRecur_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\KeepAliveRecur\\KeepAliveRecur.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
