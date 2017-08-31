using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _KeepAlive_keepaliveother_keepalivescope_keepalivescope_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivescope_keepalivescope_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivescope\\keepalivescope.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
