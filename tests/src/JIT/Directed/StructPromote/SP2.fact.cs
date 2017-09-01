using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP2_SP2_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2_SP2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2\\SP2.cmd");
        }
    }
}
