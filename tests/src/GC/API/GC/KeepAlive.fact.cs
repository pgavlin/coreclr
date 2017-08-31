using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_KeepAlive_KeepAlive_
    {
        [OuterLoop]
        [Fact]
        public void _GC_KeepAlive_KeepAlive_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\KeepAlive\\KeepAlive.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
