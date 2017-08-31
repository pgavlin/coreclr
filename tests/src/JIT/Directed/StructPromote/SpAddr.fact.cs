using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SpAddr_SpAddr_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SpAddr_SpAddr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SpAddr\\SpAddr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
