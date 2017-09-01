using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP2b_SP2b_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2b_SP2b_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2b\\SP2b.cmd");
        }
    }
}
