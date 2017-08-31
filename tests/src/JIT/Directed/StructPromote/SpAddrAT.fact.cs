using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructPromote_SpAddrAT_SpAddrAT_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SpAddrAT_SpAddrAT_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SpAddrAT\\SpAddrAT.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
