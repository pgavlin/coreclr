using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _KeepAlive_keepaliveother_keepalivetry_keepalivetry_
    {
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivetry_keepalivetry_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivetry\\keepalivetry.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
