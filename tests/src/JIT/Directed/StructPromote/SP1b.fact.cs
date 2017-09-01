using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP1b_SP1b_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1b_SP1b_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1b\\SP1b.cmd");
        }
    }
}
