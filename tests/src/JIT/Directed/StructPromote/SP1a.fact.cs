using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP1a_SP1a_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1a_SP1a_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1a\\SP1a.cmd");
        }
    }
}
