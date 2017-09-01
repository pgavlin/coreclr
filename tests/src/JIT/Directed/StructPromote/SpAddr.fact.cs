using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SpAddr_SpAddr_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SpAddr_SpAddr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SpAddr\\SpAddr.cmd");
        }
    }
}
