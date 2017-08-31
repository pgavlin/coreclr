using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _KeepAlive_keepaliveother_keepalivetypes_keepalivetypes_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivetypes_keepalivetypes_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivetypes\\keepalivetypes.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
