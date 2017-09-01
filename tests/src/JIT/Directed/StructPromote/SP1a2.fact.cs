using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP1a2_SP1a2_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1a2_SP1a2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1a2\\SP1a2.cmd");
        }
    }
}
