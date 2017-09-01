using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP1_SP1_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1_SP1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1\\SP1.cmd");
        }
    }
}
