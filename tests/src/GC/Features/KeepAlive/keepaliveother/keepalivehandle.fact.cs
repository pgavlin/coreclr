using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _KeepAlive_keepaliveother_keepalivehandle_keepalivehandle_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivehandle_keepalivehandle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivehandle\\keepalivehandle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
