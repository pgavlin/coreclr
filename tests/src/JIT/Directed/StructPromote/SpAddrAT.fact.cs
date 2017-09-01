using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SpAddrAT_SpAddrAT_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SpAddrAT_SpAddrAT_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SpAddrAT\\SpAddrAT.cmd");
        }
    }
}
