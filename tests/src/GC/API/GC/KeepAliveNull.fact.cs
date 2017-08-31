using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_KeepAliveNull_KeepAliveNull_
    {
        [OuterLoop]
        [Fact]
        public void _GC_KeepAliveNull_KeepAliveNull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\KeepAliveNull\\KeepAliveNull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
