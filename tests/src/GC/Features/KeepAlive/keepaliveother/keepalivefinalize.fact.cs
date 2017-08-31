using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _KeepAlive_keepaliveother_keepalivefinalize_keepalivefinalize_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivefinalize_keepalivefinalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivefinalize\\keepalivefinalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
